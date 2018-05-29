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
        int idx = 1;
        public Form1()
        {
            InitializeComponent();
            
            data = new DataClasses1DataContext();

            var result = from dish in data.Dishes
                         join dishDetail in data.DishDetails on dish.Id equals dishDetail.idDish
                         join size in data.Sizes on dishDetail.idSize equals size.Id
                         where dishDetail.availability == true
                         select size.text;

            listBox1.Items.Insert(0, "Name\t\tSize\tKind\tPrice");
            listBox1.Items.Insert(1, "-------------------------------------------------------------------------------------------");


        }

        private void descriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idx++;
            var result = (from Dish in data.Dishes
                         join DishDetail in data.DishDetails on Dish.Id equals DishDetail.idDish
                        where Dish.name == comboBox1.Text && DishDetail.Size.text == comboBox2.Text && DishDetail.Kind.text == comboBox3.Text
                        select DishDetail.price).SingleOrDefault();


            listBox1.Items.Insert(idx, comboBox1.Text + "\t\t" + comboBox2.Text + "\t" + comboBox3.Text + "\t" + result );
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                idx--;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
