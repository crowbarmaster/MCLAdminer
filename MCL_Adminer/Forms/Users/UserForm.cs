using System;
using System.Windows.Forms;

namespace MCL_Adminer
{
    public partial class UserForm : Form
    {
        public User WorkingUser = null;
        SQLHandler sQLHandler = new SQLHandler();
        public UserForm()
        {
            InitializeComponent();
            Shown += OnShow;
            button1.Click += delegate (object sender, EventArgs e) { button1_Click(sender, e); };
            button2.Click += delegate (object sender, EventArgs e) { button2_Click(sender, e); };
            FormClosing += delegate (object o, FormClosingEventArgs e)
            {
                FormProvider.ManageUsers.Show();
                Dispose();
            };
        }

        private void OnShow(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            if (WorkingUser != null && WorkingUser.id != "NA")
            {
                textBox1.Text = WorkingUser.id;
                textBox2.Text = WorkingUser.shift;
                textBox3.Text = WorkingUser.firstName;
                textBox4.Text = WorkingUser.lastName;
                textBox5.Text = WorkingUser.bldg;
            }
            else
            {
                WorkingUser = new User();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox2 != null && textBox3 != null && textBox4 != null && textBox5 != null)
            {
                WorkingUser.shift = textBox2.Text;
                WorkingUser.firstName = textBox3.Text;
                WorkingUser.lastName = textBox4.Text;
                WorkingUser.fullName = textBox3.Text + " " + textBox4.Text;
                WorkingUser.bldg = textBox5.Text;
            }
            bool update = false;
            string outRooms = "";
            foreach (User user in Globals.UserList)
            {
                if (user.id == WorkingUser.id)
                {
                    user.shift = WorkingUser.shift;
                    user.firstName = WorkingUser.firstName;
                    user.lastName = WorkingUser.lastName;
                    user.fullName = WorkingUser.fullName;
                    user.bldg = WorkingUser.bldg;
                    user.rooms = WorkingUser.rooms;
                    update = true;
                }

            }
            foreach(string s in WorkingUser.rooms)
            {
                outRooms = outRooms + s + ";";
            }
            outRooms = outRooms.Substring(0, outRooms.Length - 1);
            if (update)
            {

                string[] sqlData = new string[]
{
                        "`shift`='" + WorkingUser.shift + "'",
                        "`fname`='" + WorkingUser.firstName + "'",
                        "`lname`='" + WorkingUser.lastName + "'",
                        "`bldg`='" + WorkingUser.bldg + "'",
                        "`rooms`='" + outRooms + "'"
};
                string[] cond = new string[]
                {
                        "uid=" + WorkingUser.id
                };
                sQLHandler.Update("users", sqlData, cond);
            }
            else
            {
                string[] Keys = new string[]
{
                        "`shift`",
                        "`fname`",
                        "`lname`",
                        "`bldg`",
                        "`rooms`"
};
                string[] Vals = new string[]
                {
                        "'" + textBox2.Text + "'",
                        "'" + textBox2.Text + "'",
                        "'" + textBox2.Text + "'",
                        "'" + textBox2.Text + "'",
                        "'" + outRooms + "'"
                };
                sQLHandler.Insert("users", Keys, Vals);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProvider.UserRoomSelect.user = WorkingUser;
            FormProvider.UserRoomSelect.Show();
        }
    }
}
