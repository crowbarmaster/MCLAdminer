using System;
using System.Windows.Forms;

namespace MCL_Adminer
{
    public partial class ReportSelect : Form
    {
        public ReportSelect()
        {
            InitializeComponent();
            foreach (User user in Globals.UserList)
            {
                listBox1.Items.Add(user.fullName);
            }
            listBox1.SelectedIndexChanged += listbox1_SelectedIndexChanged;
            button1.Click += button1_Click;
            FormClosing += delegate (object o, FormClosingEventArgs e)
            {
                FormProvider.MainMenu.Show();
            };
        }
        public void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (User user in Globals.UserList)
            {
                if (user.fullName == listBox1.SelectedItem.ToString())
                {
                    foreach (Reports reports in Globals.RptList)
                    {
                        if (reports.userID == user.id)
                        {
                            listBox2.Items.Add(reports.date);
                        }
                    }
                }
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedUser = listBox1.SelectedItem.ToString();
                string uid = "";
                foreach (User usr in Globals.UserList)
                {
                    if (usr.fullName == selectedUser)
                    {
                        uid = usr.id;
                    }
                }
                if (listBox2.SelectedItem != null)
                {
                    string selectedDate = listBox2.SelectedItem.ToString();
                    if (selectedDate != null)
                    {
                        FormProvider.PrintReport.Report(uid, selectedDate);
                        FormProvider.PrintReport.Show();
                        Hide();
                    }
                }
            }
        }
    }
}
