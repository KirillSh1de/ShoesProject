using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using pr_2._3.Models;
using pr_2._3.Properties;

namespace pr_2._3 {
	public partial class FormOrders : Form {
		public User _currentUser { get; private set; }
		public bool _isGuest { get; private set; }

		public FormOrders(User user, bool guest) {
			InitializeComponent();

			var colCode = new DataGridViewTextBoxColumn();
			colCode.Name = "colCode";
			colCode.HeaderText = "Код заказа";
			colCode.FillWeight = 15;

			var colOrderDate = new DataGridViewTextBoxColumn();
			colOrderDate.Name = "colOrderDate";
			colOrderDate.HeaderText = "Дата заказа";
			colOrderDate.FillWeight = 15;

			var colDeliveryDate = new DataGridViewTextBoxColumn();
			colDeliveryDate.Name = "colDeliveryDate";
			colDeliveryDate.HeaderText = "Дата доставки";
			colDeliveryDate.FillWeight = 15;

			var colDeliveryPoint = new DataGridViewTextBoxColumn();
			colDeliveryPoint.Name = "colDeliveryPoint";
			colDeliveryPoint.HeaderText = "Пункт выдачи";
			colDeliveryPoint.FillWeight = 25;
			colDeliveryPoint.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			var colStatus = new DataGridViewTextBoxColumn();
			colStatus.Name = "colStatus";
			colStatus.HeaderText = "Статус";
			colStatus.FillWeight = 20;

			var colDetails = new DataGridViewTextBoxColumn();
			colDetails.Name = "colDetails";
			colDetails.HeaderText = "Детали заказа";
			colDetails.FillWeight = 30;
			colDetails.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			dgvOrders.Columns.AddRange(
			[
				colCode, colOrderDate, colDeliveryDate,
				colDeliveryPoint, colStatus, colDetails
			]);

			_currentUser = user;
			_isGuest = guest;

			lblUserName.Text = _isGuest ? "Гость" : _currentUser.FullName;

			LoadOrders();
		}

		private void LoadOrders() {
			try {
				using (var db = new ShopDbContext()) {
					var orders = db.Orders
						.Include(i => i.Status)
						.Include(i => i.DeliveryPoint)
						.Include(i => i.ProductsOrders)
							.ThenInclude(tp => tp.Product)
						.Where(w => w.User == _currentUser.Id)
						.OrderByDescending(o => o.OrderDate)
						.ToList();

					dgvOrders.SuspendLayout();
					dgvOrders.Rows.Clear();

					foreach (var order in orders) {
						int rowIndex = dgvOrders.Rows.Add();
						var row = dgvOrders.Rows[rowIndex];

						row.Cells["colCode"].Value = order.Code;
						row.Cells["colOrderDate"].Value = order.OrderDate.ToString("dd.MM.yyyy");

						if (order.DeliveryDate.HasValue) {
							row.Cells["colDeliveryDate"].Value = order.DeliveryDate.Value.ToString("dd.MM.yyyy");
						} else {
							row.Cells["colDeliveryDate"].Value = "Не назначена";
						}

						row.Cells["colDeliveryPoint"].Value = order.DeliveryPoint?.Address ?? "Не указан";
						row.Cells["colStatus"].Value = order.Status?.StatusName ?? "Не определен";

						row.Cells["colDetails"].Value = FormatOrderDetails(order);

						ApplyRowStyles(row, order);
					}

					dgvOrders.ResumeLayout();
					dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
				}
			} catch (Exception ex) {
				MessageBox.Show(
					$"Ошибка загрузки заказов: {ex.Message}",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void ShowDemoOrders() {
			dgvOrders.SuspendLayout();
			dgvOrders.Rows.Clear();

			var demoOrders = new[]
			{
				new {
					Code = "DEMO001",
					OrderDate = "01.01.2024",
					DeliveryDate = "05.01.2024",
					DeliveryPoint = "Центральный пункт выдачи, ул. Ленина, 10",
					Status = "Доставлен",
					Details = "Наушники - 2 шт.\nМышь компьютерная - 1 шт.\nКлавиатура - 1 шт."
				},
				new {
					Code = "DEMO002",
					OrderDate = "15.01.2024",
					DeliveryDate = "20.01.2024",
					DeliveryPoint = "Пункт выдачи на Московской, д. 25",
					Status = "В обработке",
					Details = "Монитор 24\" - 1 шт.\nКабель HDMI - 2 шт."
				},
				new {
					Code = "DEMO003",
					OrderDate = "25.01.2024",
					DeliveryDate = "30.01.2024",
					DeliveryPoint = "Складской комплекс, пр. Победы, 45",
					Status = "Отправлен",
					Details = "Ноутбук - 1 шт.\nСумка для ноутбука - 1 шт."
				}
			};

			foreach (var demoOrder in demoOrders) {
				int rowIndex = dgvOrders.Rows.Add();
				var row = dgvOrders.Rows[rowIndex];

				row.Cells["colCode"].Value = demoOrder.Code;
				row.Cells["colOrderDate"].Value = demoOrder.OrderDate;
				row.Cells["colDeliveryDate"].Value = demoOrder.DeliveryDate;
				row.Cells["colDeliveryPoint"].Value = demoOrder.DeliveryPoint;
				row.Cells["colStatus"].Value = demoOrder.Status;
				row.Cells["colDetails"].Value = demoOrder.Details;

				ApplyDemoRowStyles(row, demoOrder.Status);
			}

			dgvOrders.ResumeLayout();
			dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
		}

		private string FormatOrderDetails(Order order) {
			StringBuilder details = new StringBuilder();
			decimal totalAmount = 0;

			details.AppendLine("Состав заказа:");

			foreach (var orderProduct in order.OrderProducts) {
				decimal itemTotal = orderProduct.Quantity * orderProduct.PricePerUnit;
				totalAmount += itemTotal;

				details.AppendLine($"• {orderProduct.Product.Description}");
				details.AppendLine($"  {orderProduct.Quantity} шт. × {orderProduct.PricePerUnit:C} = {itemTotal:C}");
			}

			details.AppendLine($"\nИтого: {totalAmount:C}");

			return details.ToString();
		}

		private void ApplyRowStyles(DataGridViewRow row, Order order) {
			string status = order.Status?.StatusName ?? "";

			// Цветовая схема по статусам
			switch (status.ToLower()) {
				case "новый":
					row.DefaultCellStyle.BackColor = Color.LightYellow;
					break;
				case "в обработке":
					row.DefaultCellStyle.BackColor = Color.LightBlue;
					break;
				case "отправлен":
				case "доставляется":
					row.DefaultCellStyle.BackColor = Color.LightGreen;
					break;
				case "доставлен":
					row.DefaultCellStyle.BackColor = Color.LightGray;
					row.DefaultCellStyle.ForeColor = Color.DarkGray;
					break;
				case "отменен":
					row.DefaultCellStyle.BackColor = Color.LightCoral;
					break;
				default:
					row.DefaultCellStyle.BackColor = Color.White;
					break;
			}

		}

		private void ApplyDemoRowStyles(DataGridViewRow row, string status) {
			switch (status.ToLower()) {
				case "доставлен":
					row.DefaultCellStyle.BackColor = Color.LightGray;
					row.DefaultCellStyle.ForeColor = Color.DarkGray;
					break;
				case "в обработке":
					row.DefaultCellStyle.BackColor = Color.LightBlue;
					break;
				case "отправлен":
					row.DefaultCellStyle.BackColor = Color.LightGreen;
					break;
			}
		}

		private void Btn_log_Click_1(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		protected override void OnFormClosing(FormClosingEventArgs e) {
			base.OnFormClosing(e);
		}
	}
}