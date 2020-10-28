namespace MCL_Adminer
{
	// Token: 0x02000003 RID: 3
	public partial class UserForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002B9C File Offset: 0x00000D9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002BD4 File Offset: 0x00000DD4
		private void InitializeComponent()
		{
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.textBox6 = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.Location = new global::System.Drawing.Point(143, 85);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(29, 29);
			this.textBox1.TabIndex = 0;
			this.textBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox2.Location = new global::System.Drawing.Point(483, 85);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(29, 29);
			this.textBox2.TabIndex = 3;
			this.button1.Location = new global::System.Drawing.Point(143, 176);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(100, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Assigned Rooms";
			this.button1.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(250, 28);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(131, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Add/edit users";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(22, 88);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(115, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Database ID:";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(427, 88);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(50, 24);
			this.label4.TabIndex = 9;
			this.label4.Text = "Shift:";
			this.textBox5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox5.Location = new global::System.Drawing.Point(143, 129);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new global::System.Drawing.Size(100, 29);
			this.textBox5.TabIndex = 1;
			this.textBox6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox6.Location = new global::System.Drawing.Point(483, 129);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new global::System.Drawing.Size(100, 29);
			this.textBox6.TabIndex = 4;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(34, 132);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(103, 24);
			this.label6.TabIndex = 8;
			this.label6.Text = "First name:";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(376, 132);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(101, 24);
			this.label7.TabIndex = 10;
			this.label7.Text = "Last name:";
			this.button2.Location = new global::System.Drawing.Point(267, 91);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(92, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Save user";
			this.button2.UseVisualStyleBackColor = true;
			this.textBox3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox3.Location = new global::System.Drawing.Point(483, 172);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(100, 29);
			this.textBox3.TabIndex = 12;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(394, 175);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(83, 24);
			this.label3.TabIndex = 13;
			this.label3.Text = "Building:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(620, 228);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox6);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox5);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Name = "Form1";
			this.Text = "Form1";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000C RID: 12
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.TextBox textBox6;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label label3;
	}
}
