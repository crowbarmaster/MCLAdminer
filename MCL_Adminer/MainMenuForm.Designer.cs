namespace MCL_Adminer
{
	public partial class MainMenuForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(187, 138);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(99, 21);
			this.button1.TabIndex = 0;
			this.button1.Text = "Generate report";
			this.button1.UseVisualStyleBackColor = true;
			this.button2.Location = new global::System.Drawing.Point(187, 96);
			this.button2.Margin = new global::System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(99, 21);
			this.button2.TabIndex = 1;
			this.button2.Text = "Manage users";
			this.button2.UseVisualStyleBackColor = true;
			this.button3.Location = new global::System.Drawing.Point(187, 56);
			this.button3.Margin = new global::System.Windows.Forms.Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(99, 21);
			this.button3.TabIndex = 2;
			this.button3.Text = "Manage rooms";
			this.button3.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(304, 245);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Name = "MainMenuForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.Button button1;
		private global::System.Windows.Forms.Button button2;
		private global::System.Windows.Forms.Button button3;
	}
}
