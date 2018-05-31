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
    public partial class Form1 : Form
    {
        DataClasses1DataContext data;
        public Form1()
        {
            InitializeComponent();
            
            data = new DataClasses1DataContext();

            loadBox();

        }
        public void loadBox()
        {
            var result = from dish in data.Dishes
                         select new { Id = dish.Id, name = dish.name };

            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = result;

            var result2 = from size in data.Sizes
                          where size.Id < 10
                          select new { Id = size.Id, value = size.value };

            comboBox2.DisplayMember = "value";
            comboBox2.ValueMember = "Id";
            comboBox2.DataSource = result2;

            var result3 = from kind in data.Kinds
                          where kind.Id < 10
                          select new { Id = kind.Id, text = kind.text };

            comboBox3.DisplayMember = "text";
            comboBox3.ValueMember = "Id";
            comboBox3.DataSource = result3;


            var result4 = from drink in data.Drinks
                          select new { drink.Id, drink.name };

            comboBoxDrink.DisplayMember = "name";
            comboBoxDrink.ValueMember = "Id";
            comboBoxDrink.DataSource = result4;

            var result5 = from size in data.Sizes
                          where size.Id > 10
                          select new { size.Id, size.value };

            comboBoxDrinkSize.DisplayMember = "value";
            comboBoxDrinkSize.ValueMember = "Id";
            comboBoxDrinkSize.DataSource = result5;



        }


        private void errorShow(String s)
        {
            errorLab2.Text = s;
            errorLab2.Visible = true;
        }

        private void errorHide()
        {
            errorLab2.Visible = false;
        }

        private void butDrink_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var result = (from dish in data.Dishes
                              join dishDetail in data.DishDetails on dish.Id equals dishDetail.idDish
                              where dish.Id == Convert.ToInt32(comboBox1.SelectedValue)
                              && dishDetail.idSize == Convert.ToInt32(comboBox2.SelectedValue)
                              && dishDetail.idKind == Convert.ToInt32(comboBox3.SelectedValue)
                              && dishDetail.availability == true
                              select new { dish.name, dishDetail.Size.value, dishDetail.Kind.text, dishDetail.price }).First();



                listBoxOrder.Items.Insert(0, result.name + "\t\t" + result.value + "\t\t" + result.text + "\t\t" + result.price);
                errorHide();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                errorShow("Unavailable Dish");
            }

            
            
        }
        
    }

    
}
