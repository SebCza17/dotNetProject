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
    public partial class FormBill : Form
    {
        DataClasses1DataContext data;
        FormMain form1;
        List<MyItems> myItems;
        public FormBill(FormMain form1, List<MyItems> menuItems)
        {
            InitializeComponent();
            this.form1 = form1;
            myItems = menuItems;
            data = new DataClasses1DataContext();
            decimal toPay = 0;
            try
            {
                foreach (var item in menuItems)
                {
                    if (item.type.Equals("Dish"))
                    {
                        var result = (from dishDetail in data.DishDetails
                                      where dishDetail.Id == item.id
                                      select dishDetail).First();

                        listBoxOrder.Items.Insert(0, result.Dish.name + "\t\t" + (Convert.ToDecimal(result.Size.value) / 1000 + " L").Replace("0", string.Empty) + "\t" + result.Kind.text + "\t" + (result.price + " zł").Replace("000", string.Empty));
                        toPay += (decimal)result.price;
                    }
                    else
                    {
                        var result = (from drinkDetail in data.DrinkDetails
                                      where drinkDetail.Id == item.id
                                      select drinkDetail).First();

                        listBoxOrder.Items.Insert(0, result.Drink.name + "\t\t" + (Convert.ToDecimal(result.Size.value) / 1000 + " L").Replace("0", string.Empty) + "\t" + result.Kind.text + "\t" + (result.price + " zł").Replace("000", string.Empty));
                        toPay += (decimal)result.price;
                    }
                }


                labelSum.Text = (toPay + " zł").Replace("000", string.Empty);


                var result2 = from kind in data.Kinds
                              where kind.Id > 50
                              select new { kind.Id, kind.text };

                comboBoxKind.DisplayMember = "text";
                comboBoxKind.ValueMember = "Id";
                comboBoxKind.DataSource = result2;
            }
            catch (Exception ex)
            {
                form1.lostConnection();
            }
        }


        public FormBill(List<MyItems> menuItems)
        {
            InitializeComponent();
            myItems = menuItems;
            data = new DataClasses1DataContext();
            decimal toPay = 0;
            try
            {
                foreach (var item in menuItems)
                {
                    if (item.type.Equals("Dish"))
                    {
                        var result = (from dishDetail in data.DishDetails
                                      where dishDetail.Id == item.id
                                      select dishDetail).First();

                        listBoxOrder.Items.Insert(0, result.Dish.name + "\t\t" + (Convert.ToDecimal(result.Size.value) / 1000 + " L").Replace("0", string.Empty) + "\t" + result.Kind.text + "\t" + (result.price + " zł").Replace("000", string.Empty));
                        toPay += (decimal)result.price;
                    }
                    else
                    {
                        var result = (from drinkDetail in data.DrinkDetails
                                      where drinkDetail.Id == item.id
                                      select drinkDetail).First();

                        listBoxOrder.Items.Insert(0, result.Drink.name + "\t\t" + (Convert.ToDecimal(result.Size.value) / 1000 + " L").Replace("0", string.Empty) + "\t" + result.Kind.text + "\t" + (result.price + " zł").Replace("000", string.Empty));
                        toPay += (decimal)result.price;
                    }
                }


                labelSum.Text = (toPay + " zł").Replace("000", string.Empty);


                var result2 = from kind in data.Kinds
                              where kind.Id > 50
                              select new { kind.Id, kind.text };

                comboBoxKind.DisplayMember = "text";
                comboBoxKind.ValueMember = "Id";
                comboBoxKind.DataSource = result2;
                comboBoxKind.Enabled = false;

                butAdd.Enabled = false;
                butBack.Enabled = false;
            }
            catch (Exception ex)
            {
                form1.lostConnection();
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;

            Description desc = new Description();
            try
            {
                desc.decription = textBoxOrderDesc.Text;
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                desc.decription = "Null";
            }

            data.Descriptions.InsertOnSubmit(desc);
            data.SubmitChanges();

            Order order = new Order();
            order.Description = desc;
            order.startDateTime = myDateTime;
            order.idKind = (byte) comboBoxKind.SelectedValue;
            order.idStatus = 1;
            
            
            data.Orders.InsertOnSubmit(order);
            data.SubmitChanges();

            foreach (var item in myItems)
            {
                try
                {
                    if (item.type.Equals("Dish"))
                    {
                        var result = (from dishDetail in data.DishDetails
                                      where dishDetail.Id == item.id
                                      select dishDetail).First();

                        OrderDish orderDish = new OrderDish();
                        orderDish.idOrder = order.Id;
                        orderDish.idDishDetail = result.Id;
                        data.OrderDishes.InsertOnSubmit(orderDish);
                        data.SubmitChanges();
                    }
                    else
                    {
                        var result = (from drinkDetail in data.DrinkDetails
                                      where drinkDetail.Id == item.id
                                      select drinkDetail).First();


                        OrderDrink orderDrink = new OrderDrink();
                        orderDrink.idOrder = order.Id;
                        orderDrink.idDrinkDetail = result.Id;
                        data.OrderDrinks.InsertOnSubmit(orderDrink);
                        data.SubmitChanges();
                    }
                }catch(Exception ex)
                {
                    form1.lostConnection();
                }
            }

            


            this.Close();
            form1.clearAll();
            form1.loadBox();
        }
        
    }
}
