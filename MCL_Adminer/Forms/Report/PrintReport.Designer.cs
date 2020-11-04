namespace MCL_Adminer
{
	public partial class PrintReport : global::System.Windows.Forms.Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdesks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdesks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carpet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroomC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroomS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeight = 69;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Sdesks,
            this.tdesks,
            this.Floor,
            this.Handles,
            this.Carpet,
            this.BroomC,
            this.BroomS,
            this.Sani});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView1.Location = new System.Drawing.Point(0, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 600);
            this.dataGridView1.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.HeaderText = "Room:";
            this.ID.MinimumWidth = 15;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 92;
            // 
            // Date
            // 
            this.Date.HeaderText = "Time cleaned:";
            this.Date.MinimumWidth = 15;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 132;
            // 
            // Sdesks
            // 
            this.Sdesks.HeaderText = "Std desk/chairs:";
            this.Sdesks.MinimumWidth = 15;
            this.Sdesks.Name = "Sdesks";
            this.Sdesks.ReadOnly = true;
            this.Sdesks.Width = 145;
            // 
            // tdesks
            // 
            this.tdesks.HeaderText = "Tch desk/chair:";
            this.tdesks.MinimumWidth = 15;
            this.tdesks.Name = "tdesks";
            this.tdesks.ReadOnly = true;
            this.tdesks.Width = 139;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Floors:";
            this.Floor.MinimumWidth = 15;
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.Width = 93;
            // 
            // Handles
            // 
            this.Handles.HeaderText = "Door Handles:";
            this.Handles.MinimumWidth = 15;
            this.Handles.Name = "Handles";
            this.Handles.ReadOnly = true;
            this.Handles.Width = 135;
            // 
            // Carpet
            // 
            this.Carpet.HeaderText = "Carpet(s):";
            this.Carpet.MinimumWidth = 15;
            this.Carpet.Name = "Carpet";
            this.Carpet.ReadOnly = true;
            this.Carpet.Width = 115;
            // 
            // BroomC
            // 
            this.BroomC.HeaderText = "Broom cleaned:";
            this.BroomC.MinimumWidth = 15;
            this.BroomC.Name = "BroomC";
            this.BroomC.ReadOnly = true;
            this.BroomC.Width = 143;
            // 
            // BroomS
            // 
            this.BroomS.HeaderText = "Broom Sanitized:";
            this.BroomS.MinimumWidth = 15;
            this.BroomS.Name = "BroomS";
            this.BroomS.ReadOnly = true;
            this.BroomS.Width = 152;
            // 
            // Sani
            // 
            this.Sani.HeaderText = "Sanitizer checked:";
            this.Sani.MinimumWidth = 15;
            this.Sani.Name = "Sani";
            this.Sani.ReadOnly = true;
            this.Sani.Width = 161;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1028, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 80);
            this.button1.TabIndex = 16;
            this.button1.Text = "Print preview";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1028, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 80);
            this.button2.TabIndex = 17;
            this.button2.Text = "Page Setup";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1028, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 80);
            this.button3.TabIndex = 18;
            this.button3.Text = "Print (Select printer)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PrintReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 697);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintReport";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		private global::System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.DataGridView dataGridView1;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Sdesks;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn tdesks;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Floor;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Handles;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Carpet;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn BroomC;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn BroomS;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Sani;
		private global::System.Windows.Forms.Button button1;
		private global::System.Drawing.Printing.PrintDocument printDocument1;
		private global::System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
