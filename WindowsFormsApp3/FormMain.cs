using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormMain : Form
    {
        DataClasses1DataContext data;
        private List<MyItems> myItems = new List<MyItems>();
        private int ndx = 0;
        public FormMain()
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

            try
            {
                var result6 = from order in data.Orders
                              select new { order.Id, Kind = order.Kind.text, Status = order.Status.text, order.startDateTime, order.endDateTime, order.Description.decription };

                dataGridOrder.DataSource = result6;
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            for (int i = 0; i < dataGridOrder.Columns.Count; i++)
            {
                dataGridOrder.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            var result7 = from status in data.Status
                          where status.Id > 1
                          select status;

            comboBoxStatus.DisplayMember = "text";
            comboBoxStatus.ValueMember = "Id";
            comboBoxStatus.DataSource = result7;

        }
        private int getSelectedIdx(DataGridView dataGridView, String columnName)
        {

            int idx = dataGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView.Rows[idx];

            int selected = Convert.ToInt32(selectedRow.Cells[columnName].Value);

            return selected;
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
            FormDrink formDrink = new FormDrink(this);
            formDrink.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDish form3 = new FormDish(this);
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



                listBoxOrder.Items.Insert(listBoxOrder.Items.Count, result.name + "\t\t" + result.value + "\t\t" + result.text + "\t\t" + result.price);
                errorHide();

                myItems.Add(new MyItems { n = ndx, id = result.Id, type = "Dish"});
                ndx++;

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



                listBoxOrder.Items.Insert(listBoxOrder.Items.Count, result.name + "\t\t" + result.value + "\t\t" + result.text + "\t\t" + result.price);
                errorHide();


                myItems.Add(new MyItems { n = ndx, id = result.Id, type = "Drink" });
                ndx++;

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
                myItems.RemoveAt(listBoxOrder.SelectedIndex);
                listBoxOrder.Items.RemoveAt(listBoxOrder.SelectedIndex);
                ndx--;
                
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
            FormBill form4 = new FormBill(this, myItems);
            form4.Show();
        }

        public void clearAll()
        {
            listBoxOrder.Items.Clear();
            myItems.Clear();
            ndx = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void butChangeStatus_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;


            int idx = getSelectedIdx(dataGridOrder, "Id");

            var result = (from order in data.Orders
                          where order.Id == idx
                          select order).First();

            if (result.idStatus == 1)
            {
                result.idStatus = (byte)comboBoxStatus.SelectedValue;
                result.endDateTime = myDateTime;

                data.SubmitChanges();

                if (Convert.ToByte(comboBoxStatus.SelectedValue) == 2)
                {

                    var result2 = from profit in data.Profits
                                  where profit.date == result.endDateTime.Value.Date
                                  select profit;

                    decimal toPay = 0;
                    decimal withoutTax = 0;

                    foreach (var dish in result.OrderDishes)
                    {
                        toPay += (decimal)dish.DishDetail.price;
                        withoutTax += (decimal)(dish.DishDetail.price * 100 / (100 + dish.DishDetail.tax));
                    }
                    foreach (var drink in result.OrderDrinks)
                    {
                        toPay += (decimal)drink.DrinkDetail.price;
                        withoutTax += (decimal)(drink.DrinkDetail.price * 100 / (100 + drink.DrinkDetail.tax));
                    }

                    Console.WriteLine(toPay);
                    Console.WriteLine(withoutTax);

                    if (result2.Count() == 0)
                    {
                        Console.WriteLine("Nowy" + result2);

                        Profit profit = new Profit();
                        profit.date = result.endDateTime.Value.Date;
                        profit.inCash = toPay;
                        profit.onHand = withoutTax;
                        profit.tax = toPay - withoutTax;

                        data.Profits.InsertOnSubmit(profit);
                        data.SubmitChanges();

                    }
                    else
                    {
                        Console.WriteLine("Stary" + result2);

                        foreach (var profit in result2)
                        {
                            profit.inCash += toPay;
                            profit.onHand += withoutTax;
                            profit.tax += toPay - withoutTax;

                            data.SubmitChanges();
                        }


                    }
                }
            }

            loadBox();

        }

        private void butProfit_Click(object sender, EventArgs e)
        {
            FormProfit formProfit = new FormProfit();
            formProfit.Show();
        }

        private void butLook_Click(object sender, EventArgs e)
        {
            int idx = getSelectedIdx(dataGridOrder, "Id");
            List<MyItems> myItems = new List<MyItems>();
            int ndx = 0;

            var result = (from order in data.Orders
                         where order.Id == idx
                         select order).First();

            foreach (var dish in result.OrderDishes)
            {
                myItems.Add(new MyItems { id = dish.DishDetail.Id, n = ndx, type = "Dish" });
                ndx++;
            }
            foreach (var drink in result.OrderDrinks)
            {
                myItems.Add(new MyItems { id = drink.DrinkDetail.Id, n = ndx, type = "Drink" });
                ndx++;
            }

            FormBill form4 = new FormBill(myItems);
            form4.Show();
        }

        private void butKindMenu_Click(object sender, EventArgs e)
        {
            FormKind formKind = new FormKind(this);
            formKind.Show();

        }

        private void butSize_Click(object sender, EventArgs e)
        {
            FormSize formSize = new FormSize(this);
            formSize.Show();
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.Show();
        }

        private void dataGridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butReg_Click(object sender, EventArgs e)
        {
            FormRegister form8 = new FormRegister(this);
            form8.Show();
        }
    }
    

    
}
