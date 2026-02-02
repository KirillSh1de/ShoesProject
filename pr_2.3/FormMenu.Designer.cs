namespace pr_2._3 {
	partial class FormMenu {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			panelFill = new Panel();
			lblUserName = new Label();
			btnLogoutMenu = new Button();
			btnOpenOrders = new Button();
			btnOpenProducts = new Button();
			panelFill.SuspendLayout();
			SuspendLayout();
			// 
			// panelFill
			// 
			panelFill.Controls.Add(lblUserName);
			panelFill.Controls.Add(btnLogoutMenu);
			panelFill.Controls.Add(btnOpenOrders);
			panelFill.Controls.Add(btnOpenProducts);
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 0);
			panelFill.Name = "panelFill";
			panelFill.Size = new Size(423, 313);
			panelFill.TabIndex = 0;
			// 
			// lblUserName
			// 
			lblUserName.AutoSize = true;
			lblUserName.Location = new Point(12, 18);
			lblUserName.Name = "lblUserName";
			lblUserName.Size = new Size(45, 19);
			lblUserName.TabIndex = 4;
			lblUserName.Text = "label1";
			lblUserName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnLogoutMenu
			// 
			btnLogoutMenu.AutoSize = true;
			btnLogoutMenu.Location = new Point(327, 12);
			btnLogoutMenu.Name = "btnLogoutMenu";
			btnLogoutMenu.Size = new Size(84, 30);
			btnLogoutMenu.TabIndex = 3;
			btnLogoutMenu.Text = "Выход";
			btnLogoutMenu.UseVisualStyleBackColor = true;
			btnLogoutMenu.Click += BtnLogoutMenu_Click;
			// 
			// btnOpenOrders
			// 
			btnOpenOrders.Location = new Point(227, 99);
			btnOpenOrders.Name = "btnOpenOrders";
			btnOpenOrders.Size = new Size(184, 87);
			btnOpenOrders.TabIndex = 1;
			btnOpenOrders.Text = "Заказы";
			btnOpenOrders.UseVisualStyleBackColor = true;
			btnOpenOrders.Click += BtnOpenOrders_Click;
			// 
			// btnOpenProducts
			// 
			btnOpenProducts.Location = new Point(12, 99);
			btnOpenProducts.Name = "btnOpenProducts";
			btnOpenProducts.Size = new Size(184, 87);
			btnOpenProducts.TabIndex = 0;
			btnOpenProducts.Text = "Список";
			btnOpenProducts.UseVisualStyleBackColor = true;
			btnOpenProducts.Click += BtnOpenProducts_Click;
			// 
			// FormMenu
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(423, 313);
			Controls.Add(panelFill);
			Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			Name = "FormMenu";
			Text = "Меню";
			panelFill.ResumeLayout(false);
			panelFill.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelFill;
		private Button btnOpenOrders;
		private Button btnOpenProducts;
		private Label lblUserName;
		private Button btnLogoutMenu;
	}
}