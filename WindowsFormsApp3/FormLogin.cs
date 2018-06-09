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
        private FormFirst form11;
        DataClasses1DataContext data;

        public FormLogin(FormFirst form11)
        {
            InitializeComponent();
            this.form11 = form11;
            data = new DataClasses1DataContext();
        }

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
                    FormMain formMain = new FormMain(this);
                    formMain.Show();
                    form11.Hide();
                    if (result.user.role.Equals("admin"))
                    {
                        formMain.Admin = true;
                    }
                    formMain.Loggedin = true;
                    formMain.loadBox();
                    this.Close();
                 }
            }
            else { MessageBox.Show("Enter login and password"); }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
