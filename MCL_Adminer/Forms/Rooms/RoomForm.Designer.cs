namespace MCL_Adminer
{
	public partial class RoomForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.checkedListBox1 = new global::System.Windows.Forms.CheckedListBox();
			base.SuspendLayout();
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.Location = new global::System.Drawing.Point(130, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(50, 26);
			this.textBox1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(130, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(129, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Add/edit room";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(47, 45);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(77, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Room ID:";
			this.textBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox2.Location = new global::System.Drawing.Point(13, 115);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(246, 26);
			this.textBox2.TabIndex = 1;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(47, 92);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(162, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Teacher/Room name:";
			this.button1.Location = new global::System.Drawing.Point(130, 237);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(129, 25);
			this.button1.TabIndex = 11;
			this.button1.Text = "Save room";
			this.button1.UseVisualStyleBackColor = true;
			this.checkedListBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new global::System.Drawing.Point(285, 42);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new global::System.Drawing.Size(198, 220);
			this.checkedListBox1.TabIndex = 12;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(489, 280);
			base.Controls.Add(this.checkedListBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Name = "RoomForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		private global::System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.TextBox textBox1;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.Label label2;
		private global::System.Windows.Forms.TextBox textBox2;
		private global::System.Windows.Forms.Label label6;
		private global::System.Windows.Forms.Button button1;
		private global::System.Windows.Forms.CheckedListBox checkedListBox1;
	}
}
