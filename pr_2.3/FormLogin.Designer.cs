namespace pr_2._3
{
    partial class FormLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
			panel1 = new Panel();
			txtPass = new TextBox();
			txtLog = new TextBox();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			label1 = new Label();
			btn_log_guest = new Button();
			btn_log = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(txtPass);
			panel1.Controls.Add(txtLog);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(btn_log_guest);
			panel1.Controls.Add(btn_log);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(484, 361);
			panel1.TabIndex = 0;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(76, 233);
			txtPass.Name = "txtPass";
			txtPass.Size = new Size(340, 29);
			txtPass.TabIndex = 6;
			txtPass.UseSystemPasswordChar = true;
			// 
			// txtLog
			// 
			txtLog.Location = new Point(76, 163);
			txtLog.Name = "txtLog";
			txtLog.Size = new Size(340, 29);
			txtLog.TabIndex = 5;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.White;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
			pictureBox1.Location = new Point(169, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(155, 110);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(212, 202);
			label2.Name = "label2";
			label2.Size = new Size(69, 21);
			label2.TabIndex = 3;
			label2.Text = "Пароль";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(216, 132);
			label1.Name = "label1";
			label1.Size = new Size(61, 21);
			label1.TabIndex = 2;
			label1.Text = "Логин";
			// 
			// btn_log_guest
			// 
			btn_log_guest.AutoSize = true;
			btn_log_guest.Location = new Point(149, 313);
			btn_log_guest.Name = "btn_log_guest";
			btn_log_guest.Size = new Size(194, 31);
			btn_log_guest.TabIndex = 1;
			btn_log_guest.Text = "ВОЙТИ КАК ГОСТЬ";
			btn_log_guest.UseVisualStyleBackColor = true;
			btn_log_guest.Click += Btn_log_guest_Click;
			// 
			// btn_log
			// 
			btn_log.AutoSize = true;
			btn_log.Location = new Point(204, 272);
			btn_log.Name = "btn_log";
			btn_log.Size = new Size(84, 31);
			btn_log.TabIndex = 0;
			btn_log.Text = "ВОЙТИ";
			btn_log.UseVisualStyleBackColor = true;
			btn_log.Click += Btn_log_Click;
			// 
			// FormLog
			// 
			AutoScaleDimensions = new SizeF(10F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(484, 361);
			Controls.Add(panel1);
			Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			Name = "FormLog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Авторизация";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label2;
		private Label label1;
		private Button btn_log_guest;
		private Button btn_log;
		private TextBox txtPass;
		private TextBox txtLog;
	}
}
