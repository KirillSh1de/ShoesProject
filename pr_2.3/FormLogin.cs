using System.Data;
using pr_2._3.Models;

namespace pr_2._3 {
	public partial class FormLog : Form {
		public User CurrentUser { get; private set; }

		public bool IsGuest { get; private set; }

		public FormLog() {
			InitializeComponent();
		}

		private void Btn_log_Click(object sender, EventArgs e) {
			if (String.IsNullOrWhiteSpace(txtLog.Text) || String.IsNullOrWhiteSpace(txtPass.Text)) {
				MessageBox.Show(
					"¬ведите логин и пароль",
					"ќшибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			using (var db = new ShopDbContext()) {
				var user = db.Users
					.Where(w => w.Login == txtLog.Text && w.Pass == txtPass.Text)
					.FirstOrDefault();

				if (user != null) {
					CurrentUser = user;
					IsGuest = false;
					this.DialogResult = DialogResult.OK;
					this.Close();
				} else {
					MessageBox.Show(
						"¬ведите логин и пароль",
						"ќшибка",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}

		}

		private void Btn_log_guest_Click(object sender, EventArgs e) 
		{
			CurrentUser = null;
			IsGuest = true;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
