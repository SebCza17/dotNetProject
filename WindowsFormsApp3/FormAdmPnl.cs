using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class FormAdmPnl : Form
    {
        DataClasses1DataContext data;
        FormMain formHandler;
        User toUpdateUser;
        public FormAdmPnl(FormMain form1)
        {
            InitializeComponent();
            formHandler = form1;
            data = new DataClasses1DataContext();

            loadUsers();

            //var result = from user in data.Users
            //             select new { Id=user.IdUser,value=user.nick };

            //comboBoxUser.DisplayMember = "value";
            //comboBoxUser.ValueMember = "Id";
            //comboBoxUser.DataSource = result;

            comboBoxRole.DisplayMember = "Text";
            comboBoxRole.ValueMember = "Value";
            var items = new[] {
                new { Text = "Admin", Value = "admin" },
                new { Text = "Employee", Value = "employee" }
            };
            comboBoxRole.DataSource = items;

        }

        private void loadUsers()
        {
            var result = from user in data.Users
                         select new {user.IdUser, user.nick,user.pass, user.role};

            dataGridView1.DataSource = result;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private int getSelectedIdx(DataGridView dataGridView, String columnName)
        {
            int idx = dataGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView.Rows[idx];

            int selected = Convert.ToInt32(selectedRow.Cells[columnName].Value);

            return selected;
        }

        private void buttonSAve_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridView1, "IdUser");
            toUpdateUser = data.Users.SingleOrDefault(x => x.IdUser == selected);
            toUpdateUser.role = comboBoxRole.SelectedValue.ToString();
            data.SubmitChanges();
            loadUsers();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            int selected = getSelectedIdx(dataGridView1, "IdUser");
            toUpdateUser = data.Users.SingleOrDefault(x => x.IdUser == selected);
            
            data.Users.DeleteOnSubmit(toUpdateUser);
            data.SubmitChanges();
            loadUsers();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.ExecuteCommand("DROP TABLE [dbo].[OrderDish]");
            data.ExecuteCommand("DROP TABLE [dbo].[OrderDrink]");
            data.ExecuteCommand("DROP TABLE [dbo].[DishDetail]");
            data.ExecuteCommand("DROP TABLE [dbo].[DrinkDetail]");
            data.ExecuteCommand("DROP TABLE [dbo].[Order]");
            data.ExecuteCommand("DROP TABLE [dbo].[Status]");
            data.ExecuteCommand("DROP TABLE [dbo].[Kind]");
            data.ExecuteCommand("DROP TABLE [dbo].[Size]");
            data.ExecuteCommand("DROP TABLE [dbo].[Profit]");
            data.ExecuteCommand("DROP TABLE [dbo].[Drink]");
            data.ExecuteCommand("DROP TABLE [dbo].[Dish]");
            data.ExecuteCommand("DROP TABLE [dbo].[Description]");


            data.ExecuteCommand("create table [dbo].[description] ([id] int identity(1, 1) not null,[decription] varchar(200) null,primary key clustered([id] asc)); ");
            data.ExecuteCommand("create table [dbo].[kind] ([id] tinyint not null,[text] varchar(50) null,primary key clustered([id] asc)); ");
            data.ExecuteCommand("create table [dbo].[size] ([id] tinyint not null,[text]  varchar(50) null,[value] int null,primary key clustered([id] asc)); ");
            data.ExecuteCommand("create table [dbo].[status] ([id] tinyint not null,[text] varchar(50) null,primary key clustered([id] asc)); ");
            data.ExecuteCommand("create table [dbo].[profit] ([id] int identity(1, 1) not null,[date]   date  null,[incash] money null,[onhand] money null,[tax] money null,primary key clustered([id] asc)); ");
            data.ExecuteCommand("create table [dbo].[drink] ([id] int identity(1, 1) not null,[name] varchar(100) null,[adults] bit null,[iddescription] int null,primary key clustered([id] asc),foreign key([iddescription]) references[dbo].[description]([id])); ");
            data.ExecuteCommand("create table [dbo].[dish] ([id] int identity(1, 1) not null,[name] varchar(100) null,[iddescription] int null,primary key clustered([id] asc),foreign key([iddescription]) references[dbo].[description]([id])); ");
            //data.executecommand("create table [dbo].[users] ([iduser] int identity(1, 1) not null,[nick]   varchar(50) not null,[pass]   varchar(50) not null,[role]   varchar(50) default('guest') null,primary key clustered([iduser] asc)); ");
            data.ExecuteCommand("create table [dbo].[dishdetail] ([id] int identity(1, 1) not null,[availability] bit null,[idsize]  tinyint null,[idkind] tinyint null,[price] money null,[tax] int null,[iddish] int not null,primary key clustered([id] asc),foreign key([idsize]) references[dbo].[size]([id]),foreign key([idkind]) references[dbo].[kind]([id]),foreign key([iddish]) references[dbo].[dish]([id])); ");
            data.ExecuteCommand("create table [dbo].[drinkdetail] ([id] int identity(1, 1) not null,[availability] bit null,[idsize] tinyint null,[idkind] tinyint null,[price] money null,[tax] int null,[iddrink] int not null,primary key clustered([id] asc),foreign key([idsize]) references[dbo].[size]([id]),foreign key([idkind]) references[dbo].[kind]([id]),foreign key([iddrink]) references[dbo].[drink]([id])); ");
            data.ExecuteCommand("create table [dbo].[order] ([id]  int identity(1, 1) not null,[idstatus] tinyint null, [idkind] tinyint null,[startdatetime] datetime null,[enddatetime] datetime null,[iddescription] int null,primary key clustered([id] asc),foreign key([iddescription]) references[dbo].[description]([id]),foreign key([idkind]) references[dbo].[kind]([id]),foreign key([idstatus]) references[dbo].[status]([id])); ");
            data.ExecuteCommand("create table [dbo].[orderdish] ([id] int identity(1, 1) not null,[idorder] int not null,[iddishdetail] int not null,primary key clustered([id] asc),foreign key([iddishdetail]) references[dbo].[dishdetail]([id]),foreign key([idorder]) references[dbo].[order]([id])); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[OrderDrink] ([Id] INT IDENTITY(1, 1) NOT NULL, [idOrder] INT NOT NULL,[idDrinkDetail] INT NOT NULL,PRIMARY KEY CLUSTERED([Id] ASC),FOREIGN KEY([idDrinkDetail]) REFERENCES[dbo].[DrinkDetail]([Id]),FOREIGN KEY([idOrder]) REFERENCES[dbo].[Order]([Id])); ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (1, N'Thin')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (2, N'Thick')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (3, N'Italian')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (11, N'Beer')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (12, N'Vodka')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (13, N'Wine')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (14, N'Ice Tea')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (15, N'Fizzy')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (16, N'Coffee')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (51, N'in Restaurant')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (52, N'Takeaway')");
            data.ExecuteCommand("INSERT INTO [dbo].[Kind] ([Id], [text]) VALUES (53, N'Delivery')");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (1, N'Small', 26)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (2, N'Medium', 35)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (3, N'Large', 46)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (4, N'XLarge', 54)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (11, N'Tiny', 330)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (12, N'Small', 500)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (13, N'Medium', 750)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (14, N'Large', 1000)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (15, N'Big', 1500)");
            data.ExecuteCommand("INSERT INTO [dbo].[Size] ([Id], [text], [value]) VALUES (16, N'XBig', 2000)");
            data.ExecuteCommand("INSERT INTO [dbo].[Status] ([Id], [text]) VALUES (1, N'Open')");
            data.ExecuteCommand("INSERT INTO [dbo].[Status] ([Id], [text]) VALUES (2, N'Close')");
            data.ExecuteCommand("INSERT INTO [dbo].[Status] ([Id], [text]) VALUES (3, N'Canceled')");
        }
    }
}
