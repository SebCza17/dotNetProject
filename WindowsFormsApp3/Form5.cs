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
    public partial class Form5 : Form
    {
        DataClasses1DataContext data;
        public Form5()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();

            dateTimeOd.Format = DateTimePickerFormat.Custom;
            dateTimeOd.CustomFormat = "dd.MM.yyyy 00:01";


            dateTimeDo.Format = DateTimePickerFormat.Custom;
            dateTimeDo.CustomFormat = "dd.MM.yyyy 23:59";
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            var result = from profit in data.Profits
                         where profit.date >= dateTimeOd.Value.Date && profit.date <= dateTimeDo.Value.Date
                         select profit;

            dataGridOrder.DataSource = result;
        }
    }
}
