using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class FormAdmPnl : Form
    {
        DataClasses1DataContext data;
        FormMain formHandler;
        User toUpdateUser;
        public FormAdmPnl(FormMain form1)
        {
            InitializeComponent();
            formHandler = form1;
            data = new DataClasses1DataContext();

            loadUsers();

            //var result = from user in data.Users
            //             select new { Id=user.IdUser,value=user.nick };

            //comboBoxUser.DisplayMember = "value";
            //comboBoxUser.ValueMember = "Id";
            //comboBoxUser.DataSource = result;

            comboBoxRole.DisplayMember = "Text";
            comboBoxRole.ValueMember = "Value";
            var items = new[] {
                new { Text = "Admin", Value = "admin" },
                new { Text = "Employee", Value = "employee" }
            };
            comboBoxRole.DataSource = items;

        }

        private void loadUsers()
        {
            var result = from user in data.Users
                         select new {user.IdUser, user.nick,user.pass, user.role};

            dataGridView1.DataSource = result;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private int getSelectedIdx(DataGridView dataGridView, String columnName)
        {
            int idx = dataGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView.Rows[idx];

            int selected = Convert.ToInt32(selectedRow.Cells[columnName].Value);

            return selected;
        }

        private void buttonSAve_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridView1, "IdUser");
            toUpdateUser = data.Users.SingleOrDefault(x => x.IdUser == selected);
            toUpdateUser.role = comboBoxRole.SelectedValue.ToString();
            data.SubmitChanges();
            loadUsers();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridView1, "IdUser");
            toUpdateUser = data.Users.SingleOrDefault(x => x.IdUser == selected);
            
            data.Users.DeleteOnSubmit(toUpdateUser);
            data.SubmitChanges();
            loadUsers();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
