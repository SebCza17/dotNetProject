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
    public partial class FormKind : Form
    {
        DataClasses1DataContext data;
        FormMain form1;
        Kind toUpdate;
        public FormKind(FormMain form1)
        {
            InitializeComponent();
            this.form1 = form1;
            data = new DataClasses1DataContext();

            refresh();
        }

        private void refresh()
        {
            var result = from kind in data.Kinds
                         select kind;

            dataGridKind.DataSource = result;
        }
        private void errorShow(String s)
        {
            labError.Text = s;
            labError.Visible = true;
        }

        private void errorHide()
        {
            labError.Visible = false;
        }

        private int getSelectedIdx(DataGridView dataGridView, String columnName)
        {

            int idx = dataGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView.Rows[idx];

            int selected = Convert.ToInt32(selectedRow.Cells[columnName].Value);

            return selected;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = getSelectedIdx(dataGridKind, "Id");

                var result = (from kind in data.Kinds
                              where kind.Id == idx
                              select kind).First();

                data.Kinds.DeleteOnSubmit(result);
                data.SubmitChanges();
                refresh();
                form1.loadBox();
                errorHide();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                errorShow("You can not delete while it is somewhere used");
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Kind kind = new Kind();
                kind.Id = Convert.ToByte(textBoxId.Text);
                kind.text = textBoxText.Text;

                data.Kinds.InsertOnSubmit(kind);
                data.SubmitChanges();
                refresh();
                errorHide();
                form1.loadBox();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                errorShow("Wrong data in!");
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            int idx = getSelectedIdx(dataGridKind, "Id");

            var result = (from kind in data.Kinds
                         where kind.Id == idx
                         select kind).First();
            
            textBoxText.Text = result.text.ToString();

            toUpdate = result;

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {
                toUpdate.text = textBoxText.Text;
                data.SubmitChanges();
                refresh();
                errorHide();
                form1.loadBox();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                errorShow("Nothing to change");
            }

        }
    }
}
