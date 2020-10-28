namespace MCL_Adminer
{
	// Token: 0x02000008 RID: 8
	public partial class PrintReport : global::System.Windows.Forms.Form
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00004BB8 File Offset: 0x00002DB8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004BF0 File Offset: 0x00002DF0
		private void InitializeComponent()
		{
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sdesks = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tdesks = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Floor = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Handles = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Carpet = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BroomC = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BroomS = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sani = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new global::System.Windows.Forms.Button();
			this.printDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.button2 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView1.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView1.ClipboardCopyMode = global::System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridView1.ColumnHeadersHeight = 69;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.ID,
				this.Date,
				this.Sdesks,
				this.tdesks,
				this.Floor,
				this.Handles,
				this.Carpet,
				this.BroomC,
				this.BroomS,
				this.Sani
			});
			this.dataGridView1.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridView1.ImeMode = global::System.Windows.Forms.ImeMode.Disable;
			this.dataGridView1.Location = new global::System.Drawing.Point(0, 20);
			this.dataGridView1.Margin = new global::System.Windows.Forms.Padding(0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 50;
			this.dataGridView1.Size = new global::System.Drawing.Size(1000, 600);
			this.dataGridView1.TabIndex = 15;
			this.ID.HeaderText = "Room:";
			this.ID.MinimumWidth = 15;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 63;
			this.Date.HeaderText = "Time cleaned:";
			this.Date.MinimumWidth = 15;
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.Width = 91;
			this.Sdesks.HeaderText = "Std desk/chairs:";
			this.Sdesks.MinimumWidth = 15;
			this.Sdesks.Name = "Sdesks";
			this.Sdesks.ReadOnly = true;
			this.Sdesks.Width = 101;
			this.tdesks.HeaderText = "Tch desk/chair:";
			this.tdesks.MinimumWidth = 15;
			this.tdesks.Name = "tdesks";
			this.tdesks.ReadOnly = true;
			this.tdesks.Width = 99;
			this.Floor.HeaderText = "Floors:";
			this.Floor.MinimumWidth = 15;
			this.Floor.Name = "Floor";
			this.Floor.ReadOnly = true;
			this.Floor.Width = 63;
			this.Handles.HeaderText = "Door Handles:";
			this.Handles.MinimumWidth = 15;
			this.Handles.Name = "Handles";
			this.Handles.ReadOnly = true;
			this.Handles.Width = 92;
			this.Carpet.HeaderText = "Carpet(s):";
			this.Carpet.MinimumWidth = 15;
			this.Carpet.Name = "Carpet";
			this.Carpet.ReadOnly = true;
			this.Carpet.Width = 77;
			this.BroomC.HeaderText = "Broom cleaned:";
			this.BroomC.MinimumWidth = 15;
			this.BroomC.Name = "BroomC";
			this.BroomC.ReadOnly = true;
			this.BroomC.Width = 97;
			this.BroomS.HeaderText = "Broom Sanitized:";
			this.BroomS.MinimumWidth = 15;
			this.BroomS.Name = "BroomS";
			this.BroomS.ReadOnly = true;
			this.BroomS.Width = 102;
			this.Sani.HeaderText = "Sanitizer checked:";
			this.Sani.MinimumWidth = 15;
			this.Sani.Name = "Sani";
			this.Sani.ReadOnly = true;
			this.Sani.Width = 110;
			this.button1.Location = new global::System.Drawing.Point(1028, 119);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(220, 80);
			this.button1.TabIndex = 16;
			this.button1.Text = "Print...";
			this.button1.UseVisualStyleBackColor = true;
			this.button2.Location = new global::System.Drawing.Point(1028, 370);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(220, 80);
			this.button2.TabIndex = 17;
			this.button2.Text = "Page Setup";
			this.button2.UseVisualStyleBackColor = true;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new global::System.Drawing.Size(1264, 697);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.dataGridView1);
			base.Name = "PrintReport";
			base.Padding = new global::System.Windows.Forms.Padding(20);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PrintReport";
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400003A RID: 58
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.DataGridViewTextBoxColumn ID;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Date;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Sdesks;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.DataGridViewTextBoxColumn tdesks;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Floor;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Handles;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Carpet;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.DataGridViewTextBoxColumn BroomC;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.DataGridViewTextBoxColumn BroomS;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Sani;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000047 RID: 71
		private global::System.Drawing.Printing.PrintDocument printDocument1;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Button button2;
	}
}
