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
		}
	}
}
