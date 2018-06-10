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

            data.ExecuteCommand("CREATE TABLE [dbo].[Description] ([Id]         INT           IDENTITY(1, 1) NOT NULL,[decription] VARCHAR(200) NULL,PRIMARY KEY CLUSTERED([Id] ASC)); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[Kind] ([Id]   TINYINT      NOT NULL,[text] VARCHAR(50) NULL,PRIMARY KEY CLUSTERED([Id] ASC)); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[Size] ([Id]    TINYINT      NOT NULL,[text]  VARCHAR(50) NULL, [value] INT          NULL,PRIMARY KEY CLUSTERED([Id] ASC)); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[Status] ([Id]   TINYINT      NOT NULL,[text] VARCHAR(50) NULL,PRIMARY KEY CLUSTERED([Id] ASC)); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[Profit] ([Id]     INT   IDENTITY(1, 1) NOT NULL,[date]   DATE  NULL,[inCash] MONEY NULL,[onHand] MONEY NULL,[tax]    MONEY NULL,PRIMARY KEY CLUSTERED([Id] ASC)); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[Drink] ([Id]            INT           IDENTITY(1, 1) NOT NULL,[name]          VARCHAR(100) NULL,[adults]        BIT           NULL,[idDescription] INT           NULL, PRIMARY KEY CLUSTERED([Id] ASC),FOREIGN KEY([idDescription]) REFERENCES[dbo].[Description]([Id])); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[Dish] ( [Id]            INT           IDENTITY(1, 1) NOT NULL,[name]          VARCHAR(100) NULL,[idDescription] INT           NULL, PRIMARY KEY CLUSTERED([Id] ASC),FOREIGN KEY([idDescription]) REFERENCES[dbo].[Description]([Id])); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[DishDetail] ([Id]           INT     IDENTITY(1, 1) NOT NULL,[availability] BIT     NULL,[idSize]       TINYINT NULL, [idKind]       TINYINT NULL,[price]        MONEY   NULL,[tax]          INT     NULL,[idDish]       INT     NOT NULL,PRIMARY KEY CLUSTERED([Id] ASC),FOREIGN KEY([idSize]) REFERENCES[dbo].[Size]([Id]),FOREIGN KEY([idKind]) REFERENCES[dbo].[Kind]([Id]),FOREIGN KEY([idDish]) REFERENCES[dbo].[Dish]([Id])); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[DrinkDetail] ([Id]           INT     IDENTITY(1, 1) NOT NULL,[availability] BIT     NULL,[idSize]       TINYINT NULL,[idKind]       TINYINT NULL, [price]        MONEY   NULL,[tax]          INT     NULL,[idDrink]      INT     NOT NULL,PRIMARY KEY CLUSTERED([Id] ASC),FOREIGN KEY([idSize]) REFERENCES[dbo].[Size]([Id]),FOREIGN KEY([idKind]) REFERENCES[dbo].[Kind]([Id]), FOREIGN KEY([idDrink]) REFERENCES[dbo].[Drink]([Id])); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[Order] ([Id]            INT      IDENTITY(1, 1) NOT NULL,[idStatus]      TINYINT  NULL,[idKind]        TINYINT  NULL,[startDateTime] DATETIME NULL,[endDateTime]   DATETIME NULL,[idDescription] INT      NULL,PRIMARY KEY CLUSTERED([Id] ASC), FOREIGN KEY([idDescription]) REFERENCES[dbo].[Description]([Id]),FOREIGN KEY([idKind]) REFERENCES[dbo].[Kind]([Id]),FOREIGN KEY([idStatus]) REFERENCES[dbo].[Status]([Id])); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[OrderDish] ([Id]           INT IDENTITY(1, 1) NOT NULL,[idOrder]      INT NOT NULL,[idDishDetail] INT NOT NULL,PRIMARY KEY CLUSTERED([Id] ASC),FOREIGN KEY([idDishDetail]) REFERENCES[dbo].[DishDetail]([Id]),FOREIGN KEY([idOrder]) REFERENCES[dbo].[Order]([Id])); ");
            data.ExecuteCommand("CREATE TABLE [dbo].[OrderDrink] ([Id]            INT IDENTITY(1, 1) NOT NULL,[idOrder]       INT NOT NULL,[idDrinkDetail] INT NOT NULL,PRIMARY KEY CLUSTERED([Id] ASC),FOREIGN KEY([idDrinkDetail]) REFERENCES[dbo].[DrinkDetail]([Id]),FOREIGN KEY([idOrder]) REFERENCES[dbo].[Order]([Id])); ");

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

            data.ExecuteCommand("INSERT INTO [dbo].[Description] ([decription]) VALUES (N'Sos pomidorowy, Ser')");
            data.ExecuteCommand("INSERT INTO [dbo].[Dish] ([name], [idDescription]) VALUES (N'Margarita', 1)");
            data.ExecuteCommand("INSERT INTO [dbo].[DishDetail] ([availability], [idSize], [idKind], [price], [tax], [idDish]) VALUES (1,1,1,10,1,1)");

            data.ExecuteCommand("INSERT INTO [dbo].[Description] ([decription]) VALUES (N'Sos pomidorowy, Ser, Ananas, Szynka')");
            data.ExecuteCommand("INSERT INTO [dbo].[Dish] ([name], [idDescription]) VALUES (N'Hawajska', 2)");
            data.ExecuteCommand("INSERT INTO [dbo].[DishDetail] ([availability], [idSize], [idKind], [price], [tax], [idDish]) VALUES (1,1,1,10,1,2)");

            formHandler.Refresh();
            formHandler.loadBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
