using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pr_2._3 {
	public partial class FormMenu : Form {
		private User _currentUser;
		private bool _isGuest;

		public FormMenu(User currentUser, bool isGuest) {
			InitializeComponent();
			_currentUser = currentUser;
			_isGuest = isGuest;

			SetupMenuForUser();
		}

		private void SetupMenuForUser() {
			if (_isGuest) {
				btnOpenOrders.Enabled = false;
			} else if (_currentUser != null) {
			}

			lblUserName.Text = _isGuest
				? "Вы вошли как гость"
				: $"Вы вошли как: {_currentUser?.Login}";
		}

		private void BtnOpenProducts_Click(object sender, EventArgs e) {
			using (var formProducts = new FormProducts(_currentUser, _isGuest)) {
				formProducts.ShowDialog();
			}
		}

		private void BtnOpenOrders_Click(object sender, EventArgs e) {
			if (_isGuest) {
				MessageBox.Show(
					"Для просмотра заказов необходимо авторизоваться",
					"Информация",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				return;
			}
			try {
				if (_currentUser == null) {
					MessageBox.Show("Ошибка: пользователь не определен", "Ошибка");
					return;
				}

				using (var formOrders = new FormOrders(_currentUser, _isGuest)) {
					formOrders.ShowDialog();
				}
			} catch (Exception ex) {
				MessageBox.Show($"Ошибка при открытии формы заказов: {ex.Message}", "Ошибка");
			}
		}

		private void BtnLogoutMenu_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}