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
        int i = 1;
        public Form1()
        {
            InitializeComponent();

            data = new DataClasses1DataContext();
            var result = from Dish in data.Dishes
                         select Dish.name;

            comboBox1.DataSource = result;

            var result2 = from Size in data.Sizes
                         select Size.text ;

            comboBox2.DataSource = result2;

            var result3 = from Kind in data.Kinds
                          select Kind.text;

            comboBox3.DataSource = result3;

            listBox1.Items.Insert(0, "Name\t\tSize\tKind\tPrice");
            listBox1.Items.Insert(1, "--------------------------------------------------------------------------");


        }

        private void descriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            var result = (from Dish in data.Dishes
                         join ItemDetail in data.ItemDetails on Dish.Id equals ItemDetail.idItem
                         where Dish.name == comboBox1.Text
                         select ItemDetail.price).SingleOrDefault();
            
            
            listBox1.Items.Insert(i, comboBox1.Text + "\t\t" + comboBox2.Text + "\t" + comboBox3.Text + "\t" + result );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
