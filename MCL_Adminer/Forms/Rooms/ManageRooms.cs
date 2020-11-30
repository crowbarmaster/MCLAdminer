using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MCL_Adminer
{
    public partial class ManageRooms : Form
    {
        int oldIndex;
        public ManageRooms()
        {
            InitializeComponent();
            foreach (Room room in Globals.RoomList)
            {
                listBox1.Items.Add(room.ID);
            }
            button1.Click += delegate (object sender, EventArgs e)
            {
                button1_Click(sender, e);
            };
            button2.Click += delegate (object sender, EventArgs e)
            {
                button2_Click(sender, e);
            };
            button3.Click += delegate (object sender, EventArgs e)
            {
                button3_Click(sender, e);
            };
            FormClosing += delegate (object o, FormClosingEventArgs e)
            {
                FormProvider.MainMenu.Show();
                Dispose();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oldIndex = listBox1.SelectedIndex;
            FormProvider.RoomForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oldIndex = listBox1.SelectedIndex;
            if (listBox1.SelectedItem != null)
            {
                foreach (Room room in Globals.RoomList)
                {
                    if (listBox1.SelectedItem.ToString() == room.ID)
                    {
                        FormProvider.RoomForm.WorkingRoom = room;
                    }
                }
                FormProvider.RoomForm.Show();
                Hide();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<Room> tmp = Globals.RoomList;
            oldIndex = listBox1.SelectedIndex;
            if (listBox1.SelectedItem != null)
            {
                foreach (Room room in tmp)
                {
                    if (listBox1.SelectedItem.ToString() == room.ID)
                    {
                        Globals.RoomList.Remove(room);
                        new SQLHandler().Delete("rooms", $"rid={room.ID}");
                        break;
                    }
                }
                UpdateList();
            }
        }
        
        public void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (Room rm in Globals.RoomList)
            {
                listBox1.Items.Add(rm.ID);
            }
            if (oldIndex > 0 && oldIndex < Globals.RoomList.Count)
            {
                listBox1.SetSelected(oldIndex, true);
            }
            else if (oldIndex == Globals.RoomList.Count && Globals.RoomList.Count > 0)
            {
                listBox1.SetSelected(Globals.RoomList.Count - 1, true);
            }
        }
    }
}
