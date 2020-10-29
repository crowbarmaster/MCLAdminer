using System;
using System.Linq;
using System.Windows.Forms;

namespace MCL_Adminer
{
    public partial class UserRoomSelect : Form
    {
        public User user = null;
        public UserRoomSelect()
        {
            InitializeComponent();
            button1.Click += delegate (object sender, EventArgs e) { button1_Click(sender, e); };
            button2.Click += delegate (object sender, EventArgs e) { button2_Click(sender, e); };
            button3.Click += delegate (object sender, EventArgs e) { button3_Click(sender, e); };
            Shown += OnShown;
        }

        private void button1_Click(object s, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            if (index >= listBox1.Items.Count)
            {
                listBox1.SetSelected(index - 1, true);
            }
            else if (listBox1.Items.Count > 0)
            {
                listBox1.SetSelected(index, true);
            }
        }

        private void button2_Click (object s, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                if (index >= listBox2.Items.Count)
                {
                    listBox2.SetSelected(index - 1, true);
                }
                else if (listBox2.Items.Count > 0)
                {
                    listBox2.SetSelected(index, true);
                }
            }
        }

        private void button3_Click (object s, EventArgs e)
        {
            if(user != null && listBox2.Items.Count > 0)
            {
                user.rooms = listBox1.Items.OfType<string>().ToArray();
            }
            UserForm userForm = FormProvider.UserForm;
            userForm.Show();
            Dispose();
        }

        private void OnShown (object s, EventArgs e)
        {
            foreach (Room room in Globals.RoomList)
            {
                if (user != null && !user.rooms.Contains(room.ID))
                {
                    listBox1.Items.Add(room.ID);
                }
            }

            if (user != null && user.rooms.Length > 0)
            {
                listBox2.Items.AddRange(user.rooms);
            }
        }
    }
}
