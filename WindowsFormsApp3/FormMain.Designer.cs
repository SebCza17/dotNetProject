namespace WindowsFormsApp3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDishName = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelDishSize = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelDishKind = new System.Windows.Forms.Label();
            this.butDel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butDrink = new System.Windows.Forms.Button();
            this.errorLab2 = new System.Windows.Forms.Label();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDrinkSize = new System.Windows.Forms.Label();
            this.comboBoxDrinkSize = new System.Windows.Forms.ComboBox();
            this.labelDrinkName = new System.Windows.Forms.Label();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.butAddDrink = new System.Windows.Forms.Button();
            this.butSubmitOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.butChangeStatus = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.butProfit = new System.Windows.Forms.Button();
            this.butLook = new System.Windows.Forms.Button();
            this.butKindMenu = new System.Windows.Forms.Button();
            this.butSize = new System.Windows.Forms.Button();
            this.butLog = new System.Windows.Forms.Button();
            this.butReg = new System.Windows.Forms.Button();
            this.labelConn = new System.Windows.Forms.Label();
            this.butAdmPnl = new System.Windows.Forms.Button();
            this.butLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelDishName
            // 
            this.labelDishName.AutoSize = true;
            this.labelDishName.Location = new System.Drawing.Point(135, 18);
            this.labelDishName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDishName.Name = "labelDishName";
            this.labelDishName.Size = new System.Drawing.Size(96, 20);
            this.labelDishName.TabIndex = 2;
            this.labelDishName.Text = "Select Pizza";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(332, 43);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelDishSize
            // 
            this.labelDishSize.AutoSize = true;
            this.labelDishSize.Location = new System.Drawing.Point(327, 18);
            this.labelDishSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDishSize.Name = "labelDishSize";
            this.labelDishSize.Size = new System.Drawing.Size(40, 20);
            this.labelDishSize.TabIndex = 5;
            this.labelDishSize.Text = "Size";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(524, 43);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(180, 28);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // labelDishKind
            // 
            this.labelDishKind.AutoSize = true;
            this.labelDishKind.Location = new System.Drawing.Point(524, 18);
            this.labelDishKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDishKind.Name = "labelDishKind";
            this.labelDishKind.Size = new System.Drawing.Size(40, 20);
            this.labelDishKind.TabIndex = 7;
            this.labelDishKind.Text = "Kind";
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(574, 263);
            this.butDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(112, 35);
            this.butDel.TabIndex = 9;
            this.butDel.Text = "Delete";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(717, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Dish Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butDrink
            // 
            this.butDrink.Location = new System.Drawing.Point(717, 60);
            this.butDrink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDrink.Name = "butDrink";
            this.butDrink.Size = new System.Drawing.Size(112, 35);
            this.butDrink.TabIndex = 12;
            this.butDrink.Text = "Drink Menu";
            this.butDrink.UseVisualStyleBackColor = true;
            this.butDrink.Click += new System.EventHandler(this.butDrink_Click);
            // 
            // errorLab2
            // 
            this.errorLab2.AutoSize = true;
            this.errorLab2.ForeColor = System.Drawing.Color.Brown;
            this.errorLab2.Location = new System.Drawing.Point(574, 646);
            this.errorLab2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLab2.Name = "errorLab2";
            this.errorLab2.Size = new System.Drawing.Size(44, 20);
            this.errorLab2.TabIndex = 14;
            this.errorLab2.Text = "Error";
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 20;
            this.listBoxOrder.Location = new System.Drawing.Point(18, 263);
            this.listBoxOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(546, 404);
            this.listBoxOrder.TabIndex = 15;
            this.listBoxOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxOrder_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kind";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price";
            // 
            // labelDrinkSize
            // 
            this.labelDrinkSize.AutoSize = true;
            this.labelDrinkSize.Location = new System.Drawing.Point(327, 80);
            this.labelDrinkSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrinkSize.Name = "labelDrinkSize";
            this.labelDrinkSize.Size = new System.Drawing.Size(40, 20);
            this.labelDrinkSize.TabIndex = 24;
            this.labelDrinkSize.Text = "Size";
            // 
            // comboBoxDrinkSize
            // 
            this.comboBoxDrinkSize.FormattingEnabled = true;
            this.comboBoxDrinkSize.Location = new System.Drawing.Point(332, 105);
            this.comboBoxDrinkSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDrinkSize.Name = "comboBoxDrinkSize";
            this.comboBoxDrinkSize.Size = new System.Drawing.Size(180, 28);
            this.comboBoxDrinkSize.TabIndex = 23;
            this.comboBoxDrinkSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrinkSize_SelectedIndexChanged);
            // 
            // labelDrinkName
            // 
            this.labelDrinkName.AutoSize = true;
            this.labelDrinkName.Location = new System.Drawing.Point(135, 80);
            this.labelDrinkName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrinkName.Name = "labelDrinkName";
            this.labelDrinkName.Size = new System.Drawing.Size(95, 20);
            this.labelDrinkName.TabIndex = 22;
            this.labelDrinkName.Text = "Select Drink";
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.DisplayMember = "Id";
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(140, 105);
            this.comboBoxDrink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(180, 28);
            this.comboBoxDrink.TabIndex = 21;
            this.comboBoxDrink.ValueMember = "Id";
            this.comboBoxDrink.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrink_SelectedIndexChanged);
            // 
            // butAddDrink
            // 
            this.butAddDrink.Location = new System.Drawing.Point(18, 102);
            this.butAddDrink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddDrink.Name = "butAddDrink";
            this.butAddDrink.Size = new System.Drawing.Size(112, 35);
            this.butAddDrink.TabIndex = 20;
            this.butAddDrink.Text = "Add";
            this.butAddDrink.UseVisualStyleBackColor = true;
            this.butAddDrink.Click += new System.EventHandler(this.butAddDrink_Click);
            // 
            // butSubmitOrder
            // 
            this.butSubmitOrder.Location = new System.Drawing.Point(574, 354);
            this.butSubmitOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSubmitOrder.Name = "butSubmitOrder";
            this.butSubmitOrder.Size = new System.Drawing.Size(112, 35);
            this.butSubmitOrder.TabIndex = 25;
            this.butSubmitOrder.Text = "Submit";
            this.butSubmitOrder.UseVisualStyleBackColor = true;
            this.butSubmitOrder.Click += new System.EventHandler(this.butSubmitOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 309);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(717, 263);
            this.dataGridOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(744, 404);
            this.dataGridOrder.TabIndex = 27;
            this.dataGridOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrder_CellContentClick);
            // 
            // butChangeStatus
            // 
            this.butChangeStatus.Location = new System.Drawing.Point(838, 217);
            this.butChangeStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butChangeStatus.Name = "butChangeStatus";
            this.butChangeStatus.Size = new System.Drawing.Size(140, 35);
            this.butChangeStatus.TabIndex = 28;
            this.butChangeStatus.Text = "Change Status";
            this.butChangeStatus.UseVisualStyleBackColor = true;
            this.butChangeStatus.Click += new System.EventHandler(this.butChangeStatus_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(987, 218);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(180, 28);
            this.comboBoxStatus.TabIndex = 29;
            // 
            // butProfit
            // 
            this.butProfit.Location = new System.Drawing.Point(1230, 214);
            this.butProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butProfit.Name = "butProfit";
            this.butProfit.Size = new System.Drawing.Size(112, 35);
            this.butProfit.TabIndex = 30;
            this.butProfit.Text = "Profit";
            this.butProfit.UseVisualStyleBackColor = true;
            this.butProfit.Visible = false;
            this.butProfit.Click += new System.EventHandler(this.butProfit_Click);
            // 
            // butLook
            // 
            this.butLook.Location = new System.Drawing.Point(717, 218);
            this.butLook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butLook.Name = "butLook";
            this.butLook.Size = new System.Drawing.Size(112, 35);
            this.butLook.TabIndex = 31;
            this.butLook.Text = "Look Into";
            this.butLook.UseVisualStyleBackColor = true;
            this.butLook.Click += new System.EventHandler(this.butLook_Click);
            // 
            // butKindMenu
            // 
            this.butKindMenu.Location = new System.Drawing.Point(717, 105);
            this.butKindMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butKindMenu.Name = "butKindMenu";
            this.butKindMenu.Size = new System.Drawing.Size(112, 35);
            this.butKindMenu.TabIndex = 32;
            this.butKindMenu.Text = "Kind Menu";
            this.butKindMenu.UseVisualStyleBackColor = true;
            this.butKindMenu.Click += new System.EventHandler(this.butKindMenu_Click);
            // 
            // butSize
            // 
            this.butSize.Location = new System.Drawing.Point(717, 151);
            this.butSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSize.Name = "butSize";
            this.butSize.Size = new System.Drawing.Size(112, 35);
            this.butSize.TabIndex = 33;
            this.butSize.Text = "Size Menu";
            this.butSize.UseVisualStyleBackColor = true;
            this.butSize.Click += new System.EventHandler(this.butSize_Click);
            // 
            // butLog
            // 
            this.butLog.Location = new System.Drawing.Point(1349, 15);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(112, 35);
            this.butLog.TabIndex = 34;
            this.butLog.Text = "Log in";
            this.butLog.UseVisualStyleBackColor = true;
            this.butLog.Click += new System.EventHandler(this.butLog_Click);
            // 
            // butReg
            // 
            this.butReg.Location = new System.Drawing.Point(1349, 60);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(112, 35);
            this.butReg.TabIndex = 35;
            this.butReg.Text = "Register";
            this.butReg.UseVisualStyleBackColor = true;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // labelConn
            // 
            this.labelConn.AutoSize = true;
            this.labelConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelConn.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelConn.Location = new System.Drawing.Point(1344, 141);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(113, 25);
            this.labelConn.TabIndex = 36;
            this.labelConn.Text = "Connected ";
            // 
            // butAdmPnl
            // 
            this.butAdmPnl.Location = new System.Drawing.Point(1349, 169);
            this.butAdmPnl.Name = "butAdmPnl";
            this.butAdmPnl.Size = new System.Drawing.Size(112, 34);
            this.butAdmPnl.TabIndex = 37;
            this.butAdmPnl.Text = "AdminPanel";
            this.butAdmPnl.UseVisualStyleBackColor = true;
            this.butAdmPnl.Visible = false;
            // 
            // butLogOut
            // 
            this.butLogOut.Location = new System.Drawing.Point(1349, 215);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(112, 34);
            this.butLogOut.TabIndex = 38;
            this.butLogOut.Text = "Log out";
            this.butLogOut.UseVisualStyleBackColor = true;
            this.butLogOut.Visible = false;
            this.butLogOut.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1480, 693);
            this.Controls.Add(this.butLogOut);
            this.Controls.Add(this.butAdmPnl);
            this.Controls.Add(this.labelConn);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.butLog);
            this.Controls.Add(this.butSize);
            this.Controls.Add(this.butKindMenu);
            this.Controls.Add(this.butLook);
            this.Controls.Add(this.butProfit);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.butChangeStatus);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butSubmitOrder);
            this.Controls.Add(this.labelDrinkSize);
            this.Controls.Add(this.comboBoxDrinkSize);
            this.Controls.Add(this.labelDrinkName);
            this.Controls.Add(this.comboBoxDrink);
            this.Controls.Add(this.butAddDrink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.errorLab2);
            this.Controls.Add(this.butDrink);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.labelDishKind);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.labelDishSize);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelDishName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDishName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelDishSize;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelDishKind;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butDrink;
        private System.Windows.Forms.Label errorLab2;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDrinkSize;
        private System.Windows.Forms.ComboBox comboBoxDrinkSize;
        private System.Windows.Forms.Label labelDrinkName;
        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.Button butAddDrink;
        private System.Windows.Forms.Button butSubmitOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.Button butChangeStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button butProfit;
        private System.Windows.Forms.Button butLook;
        private System.Windows.Forms.Button butKindMenu;
        private System.Windows.Forms.Button butSize;
        private System.Windows.Forms.Button butLog;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.Label labelConn;
        private System.Windows.Forms.Button butAdmPnl;
        private System.Windows.Forms.Button butLogOut;
    }
}

