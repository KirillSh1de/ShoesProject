namespace pr_2._3 {
	partial class FormOrders {
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
			dgvOrders = new DataGridView();
			panelTop = new Panel();
			lblUserName = new Label();
			btn_log = new Button();
			((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
			panelTop.SuspendLayout();
			SuspendLayout();
			// 
			// dgvOrders
			// 
			dgvOrders.AllowUserToAddRows = false;
			dgvOrders.AllowUserToDeleteRows = false;
			dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvOrders.BackgroundColor = Color.White;
			dgvOrders.BorderStyle = BorderStyle.None;
			dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOrders.ColumnHeadersVisible = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Window;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvOrders.DefaultCellStyle = dataGridViewCellStyle1;
			dgvOrders.Dock = DockStyle.Fill;
			dgvOrders.Location = new Point(0, 50);
			dgvOrders.MultiSelect = false;
			dgvOrders.Name = "dgvOrders";
			dgvOrders.ReadOnly = true;
			dgvOrders.RowHeadersVisible = false;
			dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvOrders.Size = new Size(739, 440);
			dgvOrders.TabIndex = 3;
			// 
			// panelTop
			// 
			panelTop.Controls.Add(lblUserName);
			panelTop.Controls.Add(btn_log);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(10);
			panelTop.Size = new Size(739, 50);
			panelTop.TabIndex = 2;
			// 
			// lblUserName
			// 
			lblUserName.AutoSize = true;
			lblUserName.Dock = DockStyle.Right;
			lblUserName.Location = new Point(600, 10);
			lblUserName.Name = "lblUserName";
			lblUserName.Size = new Size(45, 19);
			lblUserName.TabIndex = 2;
			lblUserName.Text = "label1";
			lblUserName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btn_log
			// 
			btn_log.AutoSize = true;
			btn_log.Dock = DockStyle.Right;
			btn_log.Location = new Point(645, 10);
			btn_log.Name = "btn_log";
			btn_log.Size = new Size(84, 30);
			btn_log.TabIndex = 1;
			btn_log.Text = "Выход";
			btn_log.UseVisualStyleBackColor = true;
			btn_log.Click += Btn_log_Click_1;
			// 
			// FormOrders
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(739, 490);
			Controls.Add(dgvOrders);
			Controls.Add(panelTop);
			Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			Name = "FormOrders";
			Text = "FormOrders";
			((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
			panelTop.ResumeLayout(false);
			panelTop.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvOrders;
		private Panel panelTop;
		private Label lblUserName;
		private Button btn_log;
	}
}