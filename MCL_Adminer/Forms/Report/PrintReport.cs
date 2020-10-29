using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MCL_Adminer
{
	public partial class PrintReport : Form
	{
		public PrintReport()
		{
			InitializeComponent();
			printDocument1.DefaultPageSettings.Landscape = true;
			printDocument1.PrintPage += printDocument1_PrintPage;
			printDocument1.BeginPrint += printDocument1_BeginPrint;
			button1.Click += button1_Click;
			button2.Click += button2_Click;
            FormClosing += delegate(object o, FormClosingEventArgs e)
			{
				FormProvider.MainMenu.Show();
			};
		}
		public string MakeTwo(int input)
		{

			if (input < 10)
			{
				return "0" + input.ToString();
			}
			return input.ToString();
		}
		public string CharToBool(char input)
		{
			if (input == '0')
			{
				return "No";
			}
			return "Yes";
		}

		public void Report(string uid, string date)
		{
			Console.WriteLine("Started Report!!");
			headerDate = date;
			userName = User.getUsernameByID(uid);
			DataGridView DataGrid = dataGridView1;
			foreach (Reports reports in Globals.RptList)
			{
				foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, string[]>>> user in reports.data)
				{
					if (uid == user.Key)
					{
						foreach (KeyValuePair<string, Dictionary<string, string[]>> dates in user.Value)
						{
							if (date == dates.Key)
							{
								foreach (KeyValuePair<string, string[]> kvp in reports.data[uid][date])
								{
									char[] explode = kvp.Value[2].ToCharArray();
									string[] fixTime = kvp.Value[1].Split('.');
									fixHour = Convert.ToInt32(fixTime[0]);
									if (fixHour > 12)
									{
										fixHour -= 12;
										suffix = "PM";
									}
									else
									{
										suffix = "AM";
									}
									outTime = MakeTwo(fixHour) + ":" + MakeTwo(Convert.ToInt32(fixTime[1])) + ":" + MakeTwo(Convert.ToInt32(fixTime[2])) + " " + suffix;
									DataGridViewRowCollection rows = DataGrid.Rows;
									object[] values = new string[]
									{
										kvp.Value[0],
										outTime,
										CharToBool(explode[0]),
										CharToBool(explode[1]),
										CharToBool(explode[2]),
										CharToBool(explode[3]),
										CharToBool(explode[4]),
										CharToBool(explode[5]),
										CharToBool(explode[6]),
										CharToBool(explode[7])
									};
									rows.Add(values);
								}
							}
						}
					}
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
			PrintDialog printDialog = new PrintDialog();
			PageSetupDialog pageSetupDialog = new PageSetupDialog();
			printPreviewDialog.Document = printDocument1;
			printPreviewDialog.ShowDialog();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			new PageSetupDialog
			{
				Document = printDocument1,
				AllowOrientation = true
			}.ShowDialog();
		}
		private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			try
			{
				strFormat = new StringFormat();
				strFormat.Alignment = StringAlignment.Near;
				strFormat.LineAlignment = StringAlignment.Center;
				strFormat.Trimming = StringTrimming.EllipsisCharacter;
				arrColumnLefts.Clear();
				arrColumnWidths.Clear();
				iCellHeight = 0;
				iRow = 0;
				bFirstPage = true;
				bNewPage = true;
				iTotalWidth = 0;
				foreach (object obj in dataGridView1.Columns)
				{
					DataGridViewColumn dgvGridCol = (DataGridViewColumn)obj;
					iTotalWidth += dgvGridCol.Width;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			try
			{
				int iLeftMargin = e.MarginBounds.Left;
				int iTopMargin = e.MarginBounds.Top;
				bool bMorePagesToPrint = false;
				if (bFirstPage)
				{
					foreach (object obj in dataGridView1.Columns)
					{
						DataGridViewColumn GridCol = (DataGridViewColumn)obj;
						int iTmpWidth = (int)Math.Floor((double)GridCol.Width / (double)iTotalWidth * (double)iTotalWidth * ((double)e.MarginBounds.Width / (double)iTotalWidth));
						iHeaderHeight = (int)e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, iTmpWidth).Height + 11;
						arrColumnLefts.Add(iLeftMargin);
						arrColumnWidths.Add(iTmpWidth);
						iLeftMargin += iTmpWidth;
					}
				}
				while (iRow <= dataGridView1.Rows.Count - 1)
				{
					DataGridViewRow GridRow = dataGridView1.Rows[iRow];
					iCellHeight = GridRow.Height + 5;
					int iCount = 0;
					if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
					{
						bNewPage = true;
						bFirstPage = false;
						bMorePagesToPrint = true;
						break;
					}
					if (bNewPage)
					{
						e.Graphics.DrawString("Cleaning summary for " + userName, new Font(dataGridView1.Font, FontStyle.Bold), Brushes.Black, (float)e.MarginBounds.Left, (float)e.MarginBounds.Top - e.Graphics.MeasureString("Cleaning summary for " + userName, new Font(dataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13f);
						e.Graphics.DrawString("Date: " + headerDate, new Font(dataGridView1.Font, FontStyle.Bold), Brushes.Black, (float)e.MarginBounds.Left + ((float)e.MarginBounds.Width - e.Graphics.MeasureString("Date: " + headerDate, new Font(dataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Width), (float)e.MarginBounds.Top - e.Graphics.MeasureString("Cleaning summary for " + userName, new Font(new Font(dataGridView1.Font, FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13f);
						iTopMargin = e.MarginBounds.Top;
						foreach (object obj2 in dataGridView1.Columns)
						{
							DataGridViewColumn GridCol2 = (DataGridViewColumn)obj2;
							e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int)arrColumnLefts[iCount], iTopMargin, (int)arrColumnWidths[iCount], iHeaderHeight));
							e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount], iTopMargin, (int)arrColumnWidths[iCount], iHeaderHeight));
							e.Graphics.DrawString(GridCol2.HeaderText, GridCol2.InheritedStyle.Font, new SolidBrush(GridCol2.InheritedStyle.ForeColor), new RectangleF((float)((int)arrColumnLefts[iCount]), (float)iTopMargin, (float)((int)arrColumnWidths[iCount]), (float)iHeaderHeight), strFormat);
							iCount++;
						}
						bNewPage = false;
						iTopMargin += iHeaderHeight;
					}
					iCount = 0;
					foreach (object obj3 in GridRow.Cells)
					{
						DataGridViewCell Cel = (DataGridViewCell)obj3;
						if (Cel.Value != null)
						{
							e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font, new SolidBrush(Cel.InheritedStyle.ForeColor), new RectangleF((float)((int)arrColumnLefts[iCount]), (float)iTopMargin, (float)((int)arrColumnWidths[iCount]), (float)iCellHeight), strFormat);
						}
						e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount], iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));
						iCount++;
					}
					iRow++;
					iTopMargin += iCellHeight;
				}
				if (bMorePagesToPrint)
				{
					e.HasMorePages = true;
				}
				else
				{
					e.HasMorePages = false;
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		private string suffix;
		private int fixHour;
		private string outTime;
		private string headerDate;
		private string userName;
		private StringFormat strFormat;
		private ArrayList arrColumnLefts = new ArrayList();
		private ArrayList arrColumnWidths = new ArrayList();
		private int iCellHeight = 0;
		private int iTotalWidth = 0;
		private int iRow = 0;
		private bool bFirstPage = false;
		private bool bNewPage = false;
		private int iHeaderHeight = 0;
	}
}
