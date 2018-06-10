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
    public partial class FormRegister : Form
    {
        private FormMain form1;
        private FormFirst form11;
        DataClasses1DataContext data;

        public FormRegister(FormMain form1)
        {
            InitializeComponent();
            this.form1 = form1;
            data = new DataClasses1DataContext();
        }

        public FormRegister(FormFirst form11)
        {
            InitializeComponent();
            this.form11 = form11;
            data = new DataClasses1DataContext();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBoxLog.Text.Equals("") || !textBoxPass.Text.Equals(""))
            {
                try
                {
                    var result = (from user in data.Users
                                  where user.nick == textBoxLog.Text
                                  select new { user }).FirstOrDefault();
                    if (result == null)
                    {
                        User toUpdateUser = new User
                        {
                            nick = textBoxLog.Text,
                            pass = PasswordHash.getHash(textBoxPass.Text),
                            role = "employees"
                        };
                        data.Users.InsertOnSubmit(toUpdateUser);
                        data.SubmitChanges();
                        labelMsg.Text = "User registred";
                        labelMsg.Visible = true;
                    }
                    else
                    {
                        labelMsg.Text = "User already exist!";
                        labelMsg.Visible = true;
                    }

                    //asdasiduasjnkasdasndjkasdnasjkdasdunkasjd

                }catch(Exception ex)
                {
                    
                }
            }
            else { MessageBox.Show("Enter login and password"); }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
