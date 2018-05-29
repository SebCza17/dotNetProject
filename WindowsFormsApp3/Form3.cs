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
    public partial class Form3 : Form
    {
        DataClasses1DataContext data;
        Dish toUpdate;
        public Form3()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();


            loadDish();

        }

        private void loadDish()
        {
            var result = from dish in data.Dishes
                         select new { dish.Id, dish.name, dish.Description.decription };

            dataGridView1.DataSource = result;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private int getSelectedIdx(String columnName)
        {
            int idx = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[idx];

            int selected = Convert.ToInt32(selectedRow.Cells[columnName].Value);

            return selected;
        }

        private void errorLog(String s)
        {
            label2.Text = s;
            label2.Visible = true;
        }

        private void errorEnd()
        {
            label2.Visible = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx("Id");
           

            var result = from dishDetail in data.DishDetails
                         where dishDetail.idDish == selected
                         select new {dishDetail.Id, dishDetail.availability, Size = dishDetail.Size.text, Kind = dishDetail.Kind.text, dishDetail.tax }  ;
            
            dataGridView2.DataSource = result;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Description description;
            if (!textBox1.Text.Equals(""))
            {
                if (textBox2.Text.Equals(""))
                {
                    description = new Description
                    {
                        decription = "Null"
                    };
                }
                else
                {
                    description = new Description
                    {
                        decription = textBox2.Text
                    };
                
                }
                data.Descriptions.InsertOnSubmit(description);

                data.SubmitChanges();

                Dish dish = new Dish
                {
                    name = textBox1.Text,
                    idDescription = description.Id

                };

                data.Dishes.InsertOnSubmit(dish);

                data.SubmitChanges();

                loadDish();

                errorEnd();
            }
            else
            {
                errorLog("Dish name isEmpty!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx("Id");

            var result = (from dish in data.Dishes
                          where dish.Id == selected
                          select dish).First();

            data.Dishes.DeleteOnSubmit(result);

            data.SubmitChanges();

            loadDish();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx("Id");

            Dish result = data.Dishes.SingleOrDefault(x => x.Id == selected);

            textBox1.Text = result.name;
            try
            {
                textBox2.Text = result.Description.decription;
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            toUpdate = result;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            toUpdate.name = textBox1.Text;
            toUpdate.Description.decription = textBox2.Text;

            data.SubmitChanges();
            loadDish();
            
        }
    }
}
