using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MCL_Adminer
{
	public partial class RoomForm : Form
	{
		public RoomForm()
		{
			InitializeComponent();
            Shown += OnShow;
			button1.Click += delegate(object sender, EventArgs e)
			{
				button1_Click(sender, e);
			};
            FormClosing += delegate(object o, FormClosingEventArgs e)
			{
				ManageRooms rooms = FormProvider.ManageRooms;
				rooms.Show();
                Dispose();
			};
			foreach (string check in bools)
			{
				checkedListBox1.Items.Add(check);
			}
		}
		public char boolToChar(bool input)
		{
			if (input)
			{
				return '1';
			}
			return '0';
		}
		private void OnShow(object sender, EventArgs e)
		{
			if (WorkingRoom != null)
			{
				textBox1.Text = WorkingRoom.ID;
				textBox1.Enabled = false;
				textBox2.Text = WorkingRoom.tName;
				checkedListBox1.SetItemChecked(0, WorkingRoom.hasS);
				checkedListBox1.SetItemChecked(1, WorkingRoom.hasT);
				checkedListBox1.SetItemChecked(2, WorkingRoom.hasFloor);
				checkedListBox1.SetItemChecked(3, WorkingRoom.hasCarpet);
				checkedListBox1.SetItemChecked(4, WorkingRoom.hasBRoom);
				checkedListBox1.SetItemChecked(5, WorkingRoom.hasSani);
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (WorkingRoom != null)
			{
				if (textBox1.Text != null && textBox2.Text != null)
				{
					Globals.RoomList.Remove(WorkingRoom);
					WorkingRoom.ID = textBox1.Text;
					WorkingRoom.tName = textBox2.Text;
					WorkingRoom.hasS = checkedListBox1.GetItemChecked(0);
					WorkingRoom.hasT = checkedListBox1.GetItemChecked(1);
					WorkingRoom.hasFloor = checkedListBox1.GetItemChecked(2);
					WorkingRoom.hasCarpet = checkedListBox1.GetItemChecked(3);
					WorkingRoom.hasBRoom = checkedListBox1.GetItemChecked(4);
					WorkingRoom.hasSani = checkedListBox1.GetItemChecked(5);
					Globals.RoomList.Add(WorkingRoom);
					char[] data = new char[] {'0','0','0','0','0','0'};
					for (int i = 0; i < 6; i++)
					{
						data[i] = boolToChar(checkedListBox1.GetItemChecked(i));
					}
					string[] sqlData = new string[]
					{
						"`rid`='" + WorkingRoom.ID + "'",
						"`tname`='" + WorkingRoom.tName + "'",
						"`data`='" + new string(data) + "'"
					};
					string[] cond = new string[]
					{
						"rid=" + WorkingRoom.ID
					};
					SQLHandler.Update("rooms", sqlData, cond);
					Console.WriteLine("Updated WorkingRoom ref!");
					ManageRooms rooms = FormProvider.ManageRooms;
					rooms.Show();
                    Dispose();
				}
			}
			else
			{
				if (textBox1.Text != null && textBox2.Text != null)
				{
					Room room = new Room();
					room.ID = textBox1.Text;
					room.tName = textBox2.Text;
					room.hasS = checkedListBox1.GetItemChecked(0);
					room.hasT = checkedListBox1.GetItemChecked(1);
					room.hasFloor = checkedListBox1.GetItemChecked(2);
					room.hasCarpet = checkedListBox1.GetItemChecked(3);
					room.hasBRoom = checkedListBox1.GetItemChecked(4);
					room.hasSani = checkedListBox1.GetItemChecked(5);
					foreach (Room rm in Globals.RoomList)
					{
						if (rm.ID == room.ID)
						{
							return;
						}
					}
					Globals.RoomList.Add(room);
					Console.WriteLine("Added room with ID: " + room.ID);
					char[] data2 = new char[]
					{
						'0',
						'0',
						'0',
						'0',
						'0',
						'0'
					};
					for (int j = 0; j < 6; j++)
					{
						data2[j] = boolToChar(checkedListBox1.GetItemChecked(j));
					}
					string[] Keys = new string[]
					{
						"`rid`",
						"`tname`",
						"`data`"
					};
					string[] Vals = new string[]
					{
						"'" + room.ID + "'",
						"'" + room.tName + "'",
						"'" + new string(data2) + "'"
					};
					SQLHandler.Insert("rooms", Keys, Vals);
					ManageRooms rooms2 = FormProvider.ManageRooms;
					rooms2.Show();
                    Dispose();
				}
			}
		}

		private SQLHandler SQLHandler = new SQLHandler();
		public Room WorkingRoom = null;
		private string[] bools = new string[]
		{
			"Has student desks",
			"Has teacher desk(s)",
			"Has hard floor",
			"Has carpet(s)",
			"Has/is bathroom",
			"Has sanitizer"
		};
	}
}
