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
    public partial class FormDish : Form
    {
        DataClasses1DataContext data;
        Dish toUpdateDish;
        DishDetail toUpdateDetail;
        FormMain formHandler;
        public FormDish(FormMain form)
        {
            try
            {
                InitializeComponent();
                formHandler = form;
                data = new DataClasses1DataContext();

                loadDish();

                var result = from size in data.Sizes
                             where size.Id < 10
                             select new { Id = size.Id, text = size.text, value = size.value + " d(cm)" };


                comboBoxSize.DisplayMember = "value";
                comboBoxSize.ValueMember = "Id";
                comboBoxSize.DataSource = result;

                var result2 = from kind in data.Kinds
                              where kind.Id < 10
                              select new { Id = kind.Id, text = kind.text };

                comboBoxKind.DisplayMember = "text";
                comboBoxKind.ValueMember = "Id";
                comboBoxKind.DataSource = result2;
            }catch(Exception ex)
            {
                form.lostConnection();
            }
        }

        private void loadDish()
        {
            try
            {
                var result = from dish in data.Dishes
                             select new { dish.Id, dish.name, dish.Description.decription };

                dataGridView1.DataSource = result;

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }catch(Exception ex)
            {
                formHandler.lostConnection();
            }
        }

        private void loadDishDetail()
        {
            try
            {
                int selected = getSelectedIdx(dataGridView1, "Id");

                var result = from dishDetail in data.DishDetails
                             where dishDetail.idDish == selected
                             select new { dishDetail.Id, dishDetail.availability, Size = dishDetail.Size.text, Kind = dishDetail.Kind.text, dishDetail.price, dishDetail.tax };

                dataGridView2.DataSource = result;
            }catch(Exception ex)
            {
                formHandler.lostConnection();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            loadDishDetail();
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

                DishDetail dishDetail = new DishDetail
                {
                    availability = false,
                    idSize = 1,
                    idKind = 1,
                    price = 0,
                    tax = 0,
                    Dish = dish
                };

                data.DishDetails.InsertOnSubmit(dishDetail);
                data.SubmitChanges();

                loadDish();

                errorHide();
            }
            else
            {
                errorShow("Dish name isEmpty!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = getSelectedIdx(dataGridView1, "Id");

                var count = (from dishDetails in data.DishDetails
                             where dishDetails.idDish == selected
                             select dishDetails).Count();

                if (count == 0)
                {
                    var result = (from dish in data.Dishes
                                  where dish.Id == selected
                                  select dish).First();


                    data.Dishes.DeleteOnSubmit(result);

                    data.SubmitChanges();

                    errorHide();
                    loadDish();
                }
                else
                {
                    errorShow("Before delete Dish, delete all Details");
                }
            }catch(Exception ex)
            {
                formHandler.lostConnection();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridView1, "Id");

            Dish result = data.Dishes.SingleOrDefault(x => x.Id == selected);

            textBox1.Text = result.name;
            try
            {
                textBox2.Text = result.Description.decription;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            toUpdateDish = result;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                toUpdateDish.name = textBox1.Text;
                toUpdateDish.Description.decription = textBox2.Text;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }


            data.SubmitChanges();
            loadDish();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = getSelectedIdx(dataGridView2, "Id");

                DishDetail result = data.DishDetails.SingleOrDefault(x => x.Id == selected);

                data.DishDetails.DeleteOnSubmit(result);

                data.SubmitChanges();
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            loadDishDetail();
        }

        private void butAddDetail_Click(object sender, EventArgs e)
        {
            DishDetail dishDetail = null;



            if (!textBoxPrice.Text.Equals("") || !textBoxTax.Text.Equals(""))
            {

                dishDetail = new DishDetail
                {
                    availability = checkBox1.Checked,
                    idSize = Convert.ToByte(comboBoxSize.SelectedValue),
                    idKind = Convert.ToByte(comboBoxKind.SelectedValue),
                    price = Convert.ToDecimal(textBoxPrice.Text),
                    tax = Convert.ToInt32(textBoxTax.Text),
                    idDish = getSelectedIdx(dataGridView1, "Id")
                };


                data.DishDetails.InsertOnSubmit(dishDetail);
                data.SubmitChanges();

                loadDishDetail();

                errorHide();
            }
            else
            {
                errorShow("Need PRICE and TAX!");
            }
            

        }

        private void butEditDetail_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridView2, "Id");

            toUpdateDetail = data.DishDetails.SingleOrDefault(x => x.Id == selected);

            checkBox1.Checked = Convert.ToBoolean(toUpdateDetail.availability);
            comboBoxSize.SelectedValue = toUpdateDetail.idSize;
            comboBoxKind.SelectedValue = toUpdateDetail.idKind;
            textBoxPrice.Text = toUpdateDetail.price.ToString();
            textBoxTax.Text = toUpdateDetail.tax.ToString();

        }

        private void butSaveDetail_Click(object sender, EventArgs e)
        {
            toUpdateDetail.availability = checkBox1.Checked;
            toUpdateDetail.idSize = Convert.ToByte(comboBoxSize.SelectedValue);
            toUpdateDetail.idKind = Convert.ToByte(comboBoxKind.SelectedValue);
            toUpdateDetail.price = Convert.ToDecimal(textBoxPrice.Text);
            toUpdateDetail.tax = Convert.ToInt32(textBoxTax.Text);

            data.SubmitChanges();
            loadDishDetail();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            formHandler.loadBox();

            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
