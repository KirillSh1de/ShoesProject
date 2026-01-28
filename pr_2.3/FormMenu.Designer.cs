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
			SuspendLayout();
			// 
			// panelFill
			// 
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 0);
			panelFill.Name = "panelFill";
			panelFill.Size = new Size(484, 361);
			panelFill.TabIndex = 0;
			// 
			// FormMenu
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(484, 361);
			Controls.Add(panelFill);
			Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4, 4, 4, 4);
			Name = "FormMenu";
			Text = "FormMenu";
			ResumeLayout(false);
		}

		#endregion

		private Panel panelFill;
	}
}