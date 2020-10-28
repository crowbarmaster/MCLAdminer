using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MCL_Adminer
{
	public partial class ManageRooms : Form
	{
		public ManageRooms()
		{
			InitializeComponent();
			foreach (Room room in Globals.RoomList)
			{
				listBox1.Items.Add(room.ID);
			}
			button1.Click += delegate(object sender, EventArgs e)
			{
				button1_Click(sender, e);
			};
			button2.Click += delegate(object sender, EventArgs e)
			{
				button2_Click(sender, e);
			};
			button3.Click += delegate(object sender, EventArgs e)
			{
				button3_Click(sender, e);
			};
            FormClosing += delegate(object o, FormClosingEventArgs e)
			{
				MainMenuForm main = FormProvider.MainMenu;
				main.Show();
                Dispose();
			};
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RoomForm form = FormProvider.RoomForm;
			form.Show();
            Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			RoomForm form = FormProvider.RoomForm;
			if (listBox1.SelectedItem != null)
			{
				foreach (Room room in Globals.RoomList)
				{
					if (listBox1.SelectedItem.ToString() == room.ID)
					{
						form.WorkingRoom = room;
					}
				}
				form.Show();
                Hide();
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			RoomForm form = FormProvider.RoomForm;
			if (listBox1.SelectedItem != null)
			{
				foreach (Room room in Globals.RoomList)
				{
					if (listBox1.SelectedItem.ToString() == room.ID)
					{
						Globals.RoomList.Remove(room);
					}
				}
			}
		}
	}
}
