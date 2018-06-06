using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormLogin : Form
    {
        private FormMain form1;
        DataClasses1DataContext data;

        public FormLogin(FormMain form1)
        {
            InitializeComponent();
            this.form1 = form1;
            data = new DataClasses1DataContext();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (!textBoxLog.Text.Equals("") || !textBoxPass.Text.Equals(""))
            {
                User toUpdateUser = new User
                {
                    nick = textBoxLog.Text,
                    pass = textBoxPass.Text
                };
                //data.Users.InsertOnSubmit(toUpdateUser);
                //data.SubmitChanges();

                //do sprawdzania czy dodało użytkownika micek30
                var result = (from user in data.Users
                              where user.nick == textBoxLog.Text
                              where user.pass == textBoxPass.Text
                              select new { user}).FirstOrDefault();
                if (result == null)
                {
                    labelMsg.Text = "User not found";
                    labelMsg.Visible = true;
                }
                else
                {
                    labelMsg.Text = "Zalogowano !!!";
                    labelMsg.Visible = true;
                        }
            }
            else { MessageBox.Show("Enter login and password"); }
        }
    }
}
