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
    public partial class Form2 : Form
    {
        DataClasses1DataContext data;
        Drink toUpdateDrink;
        DrinkDetail toUpdateDetail;
        public Form2()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();

            loadDrink();

            var result = from size in data.Sizes
                         where size.Id > 10
                         select new { Id = size.Id, text = size.text, value = (Convert.ToDecimal(size.value) / 1000 + " L").Replace("0", string.Empty) };


            comboBoxSize.DisplayMember = "value";
            comboBoxSize.ValueMember = "Id";
            comboBoxSize.DataSource = result;

            var result2 = from kind in data.Kinds
                          where kind.Id > 10
                          select new { Id = kind.Id, text = kind.text };

            comboBoxKind.DisplayMember = "text";
            comboBoxKind.ValueMember = "Id";
            comboBoxKind.DataSource = result2;
        }
        private void loadDrink()
        {
            var result = from dish in data.Drinks
                         select new { dish.Id, dish.name, dish.Description.decription, dish.adults };

            dataGridDrink.DataSource = result;

            for (int i = 0; i < dataGridDrink.Columns.Count; i++)
            {
                dataGridDrink.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void loadDrinkDetail()
        {

            int selected = getSelectedIdx(dataGridDrink, "Id");

            var result = from drinkDetail in data.DrinkDetails
                         where drinkDetail.idDrink == selected
                         select new { drinkDetail.Id, drinkDetail.availability, Size = drinkDetail.Size.text, Kind = drinkDetail.Kind.text, drinkDetail.price, drinkDetail.tax };

            dataGridDetail.DataSource = result;

        }

        private int getSelectedIdx(DataGridView dataGridView, String columnName)
        {
           
               int idx = dataGridView.SelectedCells[0].RowIndex;
          
            DataGridViewRow selectedRow = dataGridView.Rows[idx];

            int selected = Convert.ToInt32(selectedRow.Cells[columnName].Value);

            return selected;
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



        private void butAddDrink_Click(object sender, EventArgs e)
        {
            Description description;
            if (!textBoxName.Text.Equals(""))
            {
                if (textBoxDesc.Text.Equals(""))
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
                        decription = textBoxDesc.Text
                    };

                }

                data.Descriptions.InsertOnSubmit(description);
                data.SubmitChanges();

                Drink drink = new Drink
                {
                    name = textBoxName.Text,
                    idDescription = description.Id,
                    adults = checkBoxIsAdult.Checked
                };

                data.Drinks.InsertOnSubmit(drink);
                data.SubmitChanges();

                DrinkDetail drinkDetail = new DrinkDetail
                {
                    availability = false,
                    idSize = 1,
                    idKind = 1,
                    price = 0,
                    tax = 0,
                    Drink = drink
                };

                data.DrinkDetails.InsertOnSubmit(drinkDetail);
                data.SubmitChanges();

                loadDrink();

                errorHide();
            }
            else
            {
                errorShow("Drink name isEmpty!");
            }
        }

        private void butDelDrink_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridDrink, "Id");

            var count = (from drinkDetails in data.DrinkDetails
                         where drinkDetails.idDrink == selected
                         select drinkDetails).Count();

            if (count == 0)
            {
                var result = (from drink in data.Drinks
                              where drink.Id == selected
                              select drink).First();


                data.Drinks.DeleteOnSubmit(result);

                data.SubmitChanges();

                errorHide();
                loadDrink();
            }
            else
            {
                errorShow("Before delete Dish, delete all Details");
            }
        }

        private void butShowDetail_Click(object sender, EventArgs e)
        {
            loadDrinkDetail();
        }

        private void butDelDetail_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = getSelectedIdx(dataGridDetail, "Id");

                DrinkDetail result = data.DrinkDetails.SingleOrDefault(x => x.Id == selected);

                data.DrinkDetails.DeleteOnSubmit(result);

                data.SubmitChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            loadDrinkDetail();
        }

        private void butEditDrink_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridDrink, "Id");

            Drink result = data.Drinks.SingleOrDefault(x => x.Id == selected);

            textBoxName.Text = result.name;
            try
            {
                textBoxDesc.Text = result.Description.decription;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            toUpdateDrink = result;
        }

        private void butSaveDrink_Click(object sender, EventArgs e)
        {
            toUpdateDrink.name = textBoxName.Text;
            toUpdateDrink.Description.decription = textBoxDesc.Text;
            toUpdateDrink.adults = checkBoxIsAdult.Checked;

            data.SubmitChanges();
            loadDrink();
        }

        private void butAddDetail_Click(object sender, EventArgs e)
        {
            DrinkDetail drinkDetail = null;
            
            if (!textBoxPrice.Text.Equals("") || !textBoxTax.Text.Equals(""))
            {

                drinkDetail = new DrinkDetail
                {
                    availability = checkBoxAva.Checked,
                    idSize = Convert.ToByte(comboBoxSize.SelectedValue),
                    idKind = Convert.ToByte(comboBoxKind.SelectedValue),
                    price = Convert.ToDecimal(textBoxPrice.Text),
                    tax = Convert.ToInt32(textBoxTax.Text),
                    idDrink = getSelectedIdx(dataGridDrink, "Id")
                };


                data.DrinkDetails.InsertOnSubmit(drinkDetail);
                data.SubmitChanges();

                loadDrinkDetail();

                errorHide();
            }
            else
            {
                errorShow("Need PRICE and TAX!");
            }
        }

        private void butEditDetail_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridDetail, "Id");

            toUpdateDetail = data.DrinkDetails.SingleOrDefault(x => x.Id == selected);

            checkBoxAva.Checked = Convert.ToBoolean(toUpdateDetail.availability);
            comboBoxSize.SelectedValue = toUpdateDetail.idSize;
            comboBoxKind.SelectedValue = toUpdateDetail.idKind;
            textBoxPrice.Text = toUpdateDetail.price.ToString();
            textBoxTax.Text = toUpdateDetail.tax.ToString();
        }

        private void butSaveDetail_Click(object sender, EventArgs e)
        {
            toUpdateDetail.availability = checkBoxAva.Checked;
            toUpdateDetail.idSize = Convert.ToByte(comboBoxSize.SelectedValue);
            toUpdateDetail.idKind = Convert.ToByte(comboBoxKind.SelectedValue);
            toUpdateDetail.price = Convert.ToDecimal(textBoxPrice.Text);
            toUpdateDetail.tax = Convert.ToInt32(textBoxTax.Text);

            data.SubmitChanges();
            loadDrinkDetail();
        }
    }
}
