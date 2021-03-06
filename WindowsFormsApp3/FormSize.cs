﻿using System;
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
    public partial class FormSize : Form
    {
        DataClasses1DataContext data;
        FormMain form1;
        Size toUpdate;
        public FormSize(FormMain form1)
        {
            InitializeComponent();
            this.form1 = form1;
            data = new DataClasses1DataContext();

            refresh();
        }

        private void refresh()
        {
            try
            {
                var result = from size in data.Sizes
                             select size;

                dataGridSize.DataSource = result;
            }
            catch (Exception ex)
            {
                this.Close();
                form1.lostConnection();
            }
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
                int idx = getSelectedIdx(dataGridSize, "Id");

                var result = (from size in data.Sizes
                              where size.Id == idx
                              select size).First();

                data.Sizes.DeleteOnSubmit(result);
                try{ data.SubmitChanges(); }catch(System.Data.SqlClient.SqlException ex) {Console.WriteLine(ex); }
                refresh();
                form1.loadBox();
                errorHide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                form1.lostConnection();
                errorShow("You can not delete while it is somewhere used");
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Size size = new Size();
                size.Id = Convert.ToByte(textBoxId.Text);
                size.text = textBoxText.Text;
                size.value = Convert.ToInt32(textBoxValue.Text);

                data.Sizes.InsertOnSubmit(size);
                try{ data.SubmitChanges(); }catch(System.Data.SqlClient.SqlException ex) {Console.WriteLine(ex); }
                refresh();
                errorHide();
                form1.loadBox();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                errorShow("Wrong data in!");
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            int idx = getSelectedIdx(dataGridSize, "Id");
            try
            {
                var result = (from size in data.Sizes
                              where size.Id == idx
                              select size).First();

                textBoxText.Text = result.text.ToString();
                textBoxValue.Text = result.value.ToString();

                toUpdate = result;
            }
            catch (Exception ex)
            {
                form1.lostConnection();
            }

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {
                toUpdate.text = textBoxText.Text;
                toUpdate.value = Convert.ToInt32(textBoxValue.Text);
                try{ data.SubmitChanges(); }catch(System.Data.SqlClient.SqlException ex) {Console.WriteLine(ex); }
                refresh();
                errorHide();
                form1.loadBox();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                errorShow("Nothing to change");
            }

        }
    }
}
