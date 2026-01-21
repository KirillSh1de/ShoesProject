namespace pr_2._3 {
	partial class FormProducts {
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			panelTop = new Panel();
			dgvProducts = new DataGridView();
			btn_log = new Button();
			lblUserName = new Label();
			panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.Controls.Add(lblUserName);
			panelTop.Controls.Add(btn_log);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(10);
			panelTop.Size = new Size(734, 50);
			panelTop.TabIndex = 0;
			// 
			// dgvProducts
			// 
			dgvProducts.AllowUserToAddRows = false;
			dgvProducts.AllowUserToDeleteRows = false;
			dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvProducts.BackgroundColor = Color.White;
			dgvProducts.BorderStyle = BorderStyle.None;
			dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Window;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
			dgvProducts.Dock = DockStyle.Fill;
			dgvProducts.Location = new Point(0, 50);
			dgvProducts.MultiSelect = false;
			dgvProducts.Name = "dgvProducts";
			dgvProducts.ReadOnly = true;
			dgvProducts.RowHeadersVisible = false;
			dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProducts.Size = new Size(734, 461);
			dgvProducts.TabIndex = 1;
			// 
			// btn_log
			// 
			btn_log.AutoSize = true;
			btn_log.Dock = DockStyle.Right;
			btn_log.Location = new Point(640, 10);
			btn_log.Name = "btn_log";
			btn_log.Size = new Size(84, 30);
			btn_log.TabIndex = 1;
			btn_log.Text = "Войти";
			btn_log.UseVisualStyleBackColor = true;
			// 
			// lblUserName
			// 
			lblUserName.AutoSize = true;
			lblUserName.Dock = DockStyle.Right;
			lblUserName.Location = new Point(595, 10);
			lblUserName.Name = "lblUserName";
			lblUserName.Size = new Size(45, 19);
			lblUserName.TabIndex = 2;
			lblUserName.Text = "label1";
			lblUserName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// FormProducts
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(734, 511);
			Controls.Add(dgvProducts);
			Controls.Add(panelTop);
			Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4, 4, 4, 4);
			Name = "FormProducts";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Список товаров";
			panelTop.ResumeLayout(false);
			panelTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTop;
		private DataGridView dgvProducts;
		private Button btn_log;
		private Label lblUserName;
	}
}