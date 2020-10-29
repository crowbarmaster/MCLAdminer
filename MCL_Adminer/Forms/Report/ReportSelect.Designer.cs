namespace MCL_Adminer
{
	// Token: 0x0200000A RID: 10
	public partial class ReportSelect : global::System.Windows.Forms.Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00005AEC File Offset: 0x00003CEC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005B24 File Offset: 0x00003D24
		private void InitializeComponent()
		{
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.listBox2 = new global::System.Windows.Forms.ListBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.listBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 37;
			this.listBox1.Location = new global::System.Drawing.Point(54, 126);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(241, 559);
			this.listBox1.TabIndex = 0;
			this.listBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 37;
			this.listBox2.Location = new global::System.Drawing.Point(380, 126);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new global::System.Drawing.Size(251, 559);
			this.listBox2.TabIndex = 1;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Location = new global::System.Drawing.Point(706, 333);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(212, 71);
			this.button1.TabIndex = 2;
			this.button1.Text = "Show report";
			this.button1.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(47, 69);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(184, 37);
			this.label1.TabIndex = 3;
			this.label1.Text = "Select user:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(373, 69);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(184, 37);
			this.label2.TabIndex = 4;
			this.label2.Text = "Select date:";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new global::System.Drawing.Size(964, 697);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.listBox2);
			base.Controls.Add(this.listBox1);
			base.Name = "ReportSelect";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReportSelect";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000051 RID: 81
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.ListBox listBox2;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label label2;
	}
}
