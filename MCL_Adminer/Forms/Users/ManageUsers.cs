using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MCL_Adminer
{
	public partial class ManageUsers : Form
	{
		public ManageUsers()
		{
			InitializeComponent();
			foreach (User user in Globals.UserList)
			{
				listBox1.Items.Add(user.fullName);
			}
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            FormClosing += delegate (object o, FormClosingEventArgs e)
            {
                FormProvider.MainMenu.Show();
                Dispose();
            };
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                foreach(User user in Globals.UserList)
                {
                    if(listBox1.SelectedItem.ToString() == user.fullName)
                    {
                        FormProvider.UserForm.WorkingUser = user;
                    }
                }
                FormProvider.UserForm.Show();
                Hide();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormProvider.UserForm.WorkingUser = new User();
            FormProvider.UserForm.Show();
            Hide();
        }
    }
}
