using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using pr_2._3.Models;
using pr_2._3.Properties;

namespace pr_2._3 {
	public partial class FormProducts : Form {
		public User CurrentUser { get; private set; }

		public bool IsGuest { get; private set; }

		public FormProducts(User user, bool guest) {
			InitializeComponent();

			var colPhoto = new DataGridViewImageColumn();
			colPhoto.Name = "colPhoto";
			colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
			colPhoto.Width = 200;
			colPhoto.FillWeight = 30;

			var colInfo = new DataGridViewTextBoxColumn();
			colInfo.Name = "colInfo";
			colInfo.FillWeight = 60;
			colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			var colDiscout = new DataGridViewTextBoxColumn();
			colDiscout.Name = "colDiscout";
			colDiscout.FillWeight = 10;
			colDiscout.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			dgvProducts.Columns.AddRange(
			[
				colPhoto,colInfo,colDiscout
			]);

			CurrentUser = user;
			IsGuest = guest;

			lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

			LoadProducts();
		}

		private void LoadProducts() 
		{
			try {
				using (var db = new ShopDbContext()) {
					var products = db.Products
						.Include(i => i.Category)
						.Include(i => i.Manufacturer)
						.Include(i => i.Supplier)
						.Include(i => i.Measure)
						.ToList();

					dgvProducts.SuspendLayout();
					dgvProducts.Rows.Clear();

					foreach (var product in products) {
						int rowIndex = dgvProducts.Rows.Add();
						var row = dgvProducts.Rows[rowIndex];

						row.Cells["colPhoto"].Value = LoadProductImage(product.PhotoUrl);

						row.Cells["colInfo"].Value = FormatProductInfo(product);

						row.Cells["colDiscount"].Value = $"{product.Discount}%";
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(
					$"Ошибка загрузки : {ex.Message}",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private string FormatProductInfo(Product product)
		{
			string priceText;

			if (product.Discount > 0) {
				decimal finalPrice = product.Price * (100 - product.Discount) / 100;
				priceText = $"Цена: {product.Price:C} -> {finalPrice:C}";
			} else {
				priceText = $"Цена: {product.Price:C}";
			}

			return $"{product.Category.CategoryName} | {product.ProductType.ProdType} " + Environment.NewLine +
				$"Описание товара: {product.Description}" + Environment.NewLine +
				$"Производитель: {product.Manufacturer.ManufacturerName}" + Environment.NewLine +
				$"Поставщик: {product.Supplier.SupplierName}" + Environment.NewLine +
				$"Цена: {priceText}" + Environment.NewLine +
				$"Единица измерения: {product.Measure.MeasureName}" + Environment.NewLine +
				$"Количество на складе: {product.CointInStock}" + Environment.NewLine;

		}

		private Image? LoadProductImage(string photoUrl) {
			if (!String.IsNullOrEmpty(photoUrl) && System.IO.File.Exists(photoUrl)) {
				return Image.FromFile(photoUrl);
			}

			Bitmap bmp = new Bitmap(150, 100);
			using (Graphics g = Graphics.FromImage(bmp)) {
				g.Clear(Color.White);
				g.DrawRectangle(Pens.LightGray, 0, 0, 149, 99);


			}
			return Resources.picture;

		}
	}
}
