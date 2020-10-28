using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MCL_Adminer
{
	public partial class UserForm : Form
	{
		public User WorkingUser = null;
		public UserForm()
		{
			InitializeComponent();
			Shown += OnShow;
			button1.Click += delegate (object sender, EventArgs e) {button1_Click(sender, e);};
			button2.Click += delegate (object sender, EventArgs e) {button2_Click(sender, e);};
			FormClosing += delegate (object o, FormClosingEventArgs e)
			{
				ManageUsers users = FormProvider.ManageUsers;
				users.Show();
				Dispose();
			};
		}

		private void OnShow(object sender, EventArgs e)
		{
			if(WorkingUser != null)
            {
				textBox1.Text = WorkingUser.id;
				textBox1.Enabled = false;
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

        }

		private void button2_Click(object sender, EventArgs e)
        {
			UserRoomSelect select = new UserRoomSelect();
			select.user = WorkingUser;
			select.Show();
        }
	}
}
