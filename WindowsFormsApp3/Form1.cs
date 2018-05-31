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
        List<int> dishOrderList = new List<int>();
        List<int> drinkOrderList = new List<int>();
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
                          select new { Id = size.Id, value = size.value + " d(cm)" };

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
                          select new { size.Id, value = (Convert.ToDecimal(size.value) / 1000 + " L").Replace("0", string.Empty) };

            comboBoxDrinkSize.DisplayMember = "value";
            comboBoxDrinkSize.ValueMember = "Id";
            comboBoxDrinkSize.DataSource = result5;



        }

        private Boolean inDishStock()
        {
            var result = from dishDetail in data.DishDetails
                          where dishDetail.idDish == Convert.ToInt32(comboBox1.SelectedValue)
                               && dishDetail.idSize == Convert.ToInt32(comboBox2.SelectedValue)
                               && dishDetail.idKind == Convert.ToInt32(comboBox3.SelectedValue)
                               && dishDetail.availability == true
                          select dishDetail;

            
            return result.Count() > 0;
        }

        private Boolean inDrinkStock()
        {
            var result = from drinkDetail in data.DrinkDetails
                         where drinkDetail.idDrink == Convert.ToInt32(comboBoxDrink.SelectedValue)
                              && drinkDetail.idSize == Convert.ToInt16(comboBoxDrinkSize.SelectedValue)
                              && drinkDetail.availability == true
                         select drinkDetail;
            
            return result.Count() > 0;
        }

        private void setRedDishLabel()
        {
            labelDishName.ForeColor = Color.Red;
            labelDishSize.ForeColor = Color.Red;
            labelDishKind.ForeColor = Color.Red;
        }
        private void setBlackDishLabel()
        {
            labelDishName.ForeColor = Color.Black;
            labelDishSize.ForeColor = Color.Black;
            labelDishKind.ForeColor = Color.Black;
        }

        private void setRedDrinkLabel()
        {
            labelDrinkName.ForeColor = Color.Red;
            labelDrinkSize.ForeColor = Color.Red;
        }
        private void setBlackDrinkLabel()
        {
            labelDrinkName.ForeColor = Color.Black;
            labelDrinkSize.ForeColor = Color.Black;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
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
                              select new { dish.name, dishDetail.Size.value, dishDetail.Kind.text, price = (dishDetail.price + " zł").Replace("000", string.Empty), dishDetail.Id}).First();



                listBoxOrder.Items.Insert(0, result.name + "\t\t" + result.value + "\t\t" + result.text + "\t\t" + result.price);
                errorHide();

                dishOrderList.Add(result.Id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                errorShow("Unavailable Dish");
            }
            
            
            
        }

        private void butAddDrink_Click(object sender, EventArgs e)
        {
            try
            {
                var result = (from drink in data.Drinks
                              join drinkDetail in data.DrinkDetails on drink.Id equals drinkDetail.idDrink
                              where drink.Id == Convert.ToInt32(comboBoxDrink.SelectedValue)
                              && drinkDetail.idSize == Convert.ToInt32(comboBoxDrinkSize.SelectedValue)
                              && drinkDetail.availability == true
                              select new { drink.name,value = (Convert.ToDecimal(drinkDetail.Size.value) / 1000 + " L").Replace("0", string.Empty),
                                  drinkDetail.Kind.text, price = (drinkDetail.price + " zł").Replace("000", string.Empty), drinkDetail.Id}).First();



                listBoxOrder.Items.Insert(0, result.name + "\t\t" + result.value + "\t\t" + result.text + "\t\t" + result.price);
                errorHide();


                drinkOrderList.Add(result.Id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }
            
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxOrder.Items.RemoveAt(listBoxOrder.SelectedIndex);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!inDishStock())
            {
                setRedDishLabel();
            }
            else
            {
                setBlackDishLabel();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!inDishStock())
            {
                setRedDishLabel();
            }
            else
            {
                setBlackDishLabel();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inDishStock())
            {
                setRedDishLabel();
            }
            else
            {
                setBlackDishLabel();
            }
        }

        private void comboBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inDrinkStock())
            {
                setRedDrinkLabel();
                
            }
            else
            {
                setBlackDrinkLabel();
            }
        }

        private void comboBoxDrinkSize_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!inDrinkStock())
            {
                setRedDrinkLabel();
            }
            else
            {
                setBlackDrinkLabel();
            }
        }

        private void butSubmitOrder_Click(object sender, EventArgs e)
        {
            foreach(var item in dishOrderList)
            {
                Console.WriteLine(item);
            }
        }
    }

    
}
