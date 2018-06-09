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
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelDishName
            // 
            this.labelDishName.AutoSize = true;
            this.labelDishName.Location = new System.Drawing.Point(90, 12);
            this.labelDishName.Name = "labelDishName";
            this.labelDishName.Size = new System.Drawing.Size(65, 13);
            this.labelDishName.TabIndex = 2;
            this.labelDishName.Text = "Select Pizza";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(221, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelDishSize
            // 
            this.labelDishSize.AutoSize = true;
            this.labelDishSize.Location = new System.Drawing.Point(218, 12);
            this.labelDishSize.Name = "labelDishSize";
            this.labelDishSize.Size = new System.Drawing.Size(27, 13);
            this.labelDishSize.TabIndex = 5;
            this.labelDishSize.Text = "Size";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(349, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // labelDishKind
            // 
            this.labelDishKind.AutoSize = true;
            this.labelDishKind.Location = new System.Drawing.Point(349, 12);
            this.labelDishKind.Name = "labelDishKind";
            this.labelDishKind.Size = new System.Drawing.Size(28, 13);
            this.labelDishKind.TabIndex = 7;
            this.labelDishKind.Text = "Kind";
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(383, 171);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 9;
            this.butDel.Text = "Delete";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Dish Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butDrink
            // 
            this.butDrink.Location = new System.Drawing.Point(478, 39);
            this.butDrink.Name = "butDrink";
            this.butDrink.Size = new System.Drawing.Size(75, 23);
            this.butDrink.TabIndex = 12;
            this.butDrink.Text = "Drink Menu";
            this.butDrink.UseVisualStyleBackColor = true;
            this.butDrink.Click += new System.EventHandler(this.butDrink_Click);
            // 
            // errorLab2
            // 
            this.errorLab2.AutoSize = true;
            this.errorLab2.ForeColor = System.Drawing.Color.Brown;
            this.errorLab2.Location = new System.Drawing.Point(383, 420);
            this.errorLab2.Name = "errorLab2";
            this.errorLab2.Size = new System.Drawing.Size(29, 13);
            this.errorLab2.TabIndex = 14;
            this.errorLab2.Text = "Error";
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.Location = new System.Drawing.Point(12, 171);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(365, 264);
            this.listBoxOrder.TabIndex = 15;
            this.listBoxOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxOrder_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kind";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price";
            // 
            // labelDrinkSize
            // 
            this.labelDrinkSize.AutoSize = true;
            this.labelDrinkSize.Location = new System.Drawing.Point(218, 52);
            this.labelDrinkSize.Name = "labelDrinkSize";
            this.labelDrinkSize.Size = new System.Drawing.Size(27, 13);
            this.labelDrinkSize.TabIndex = 24;
            this.labelDrinkSize.Text = "Size";
            // 
            // comboBoxDrinkSize
            // 
            this.comboBoxDrinkSize.FormattingEnabled = true;
            this.comboBoxDrinkSize.Location = new System.Drawing.Point(221, 68);
            this.comboBoxDrinkSize.Name = "comboBoxDrinkSize";
            this.comboBoxDrinkSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDrinkSize.TabIndex = 23;
            this.comboBoxDrinkSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrinkSize_SelectedIndexChanged);
            // 
            // labelDrinkName
            // 
            this.labelDrinkName.AutoSize = true;
            this.labelDrinkName.Location = new System.Drawing.Point(90, 52);
            this.labelDrinkName.Name = "labelDrinkName";
            this.labelDrinkName.Size = new System.Drawing.Size(65, 13);
            this.labelDrinkName.TabIndex = 22;
            this.labelDrinkName.Text = "Select Drink";
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.DisplayMember = "Id";
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(93, 68);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDrink.TabIndex = 21;
            this.comboBoxDrink.ValueMember = "Id";
            this.comboBoxDrink.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrink_SelectedIndexChanged);
            // 
            // butAddDrink
            // 
            this.butAddDrink.Location = new System.Drawing.Point(12, 66);
            this.butAddDrink.Name = "butAddDrink";
            this.butAddDrink.Size = new System.Drawing.Size(75, 23);
            this.butAddDrink.TabIndex = 20;
            this.butAddDrink.Text = "Add";
            this.butAddDrink.UseVisualStyleBackColor = true;
            this.butAddDrink.Click += new System.EventHandler(this.butAddDrink_Click);
            // 
            // butSubmitOrder
            // 
            this.butSubmitOrder.Location = new System.Drawing.Point(383, 230);
            this.butSubmitOrder.Name = "butSubmitOrder";
            this.butSubmitOrder.Size = new System.Drawing.Size(75, 23);
            this.butSubmitOrder.TabIndex = 25;
            this.butSubmitOrder.Text = "Submit";
            this.butSubmitOrder.UseVisualStyleBackColor = true;
            this.butSubmitOrder.Click += new System.EventHandler(this.butSubmitOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridOrder.Location = new System.Drawing.Point(478, 171);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(496, 263);
            this.dataGridOrder.TabIndex = 27;
            this.dataGridOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrder_CellContentClick);
            // 
            // butChangeStatus
            // 
            this.butChangeStatus.Location = new System.Drawing.Point(559, 141);
            this.butChangeStatus.Name = "butChangeStatus";
            this.butChangeStatus.Size = new System.Drawing.Size(93, 23);
            this.butChangeStatus.TabIndex = 28;
            this.butChangeStatus.Text = "Change Status";
            this.butChangeStatus.UseVisualStyleBackColor = true;
            this.butChangeStatus.Click += new System.EventHandler(this.butChangeStatus_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(658, 142);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 29;
            // 
            // butProfit
            // 
            this.butProfit.Location = new System.Drawing.Point(820, 139);
            this.butProfit.Name = "butProfit";
            this.butProfit.Size = new System.Drawing.Size(75, 23);
            this.butProfit.TabIndex = 30;
            this.butProfit.Text = "Profit";
            this.butProfit.UseVisualStyleBackColor = true;
            this.butProfit.Visible = false;
            this.butProfit.Click += new System.EventHandler(this.butProfit_Click);
            // 
            // butLook
            // 
            this.butLook.Location = new System.Drawing.Point(478, 142);
            this.butLook.Name = "butLook";
            this.butLook.Size = new System.Drawing.Size(75, 23);
            this.butLook.TabIndex = 31;
            this.butLook.Text = "Look Into";
            this.butLook.UseVisualStyleBackColor = true;
            this.butLook.Click += new System.EventHandler(this.butLook_Click);
            // 
            // butKindMenu
            // 
            this.butKindMenu.Location = new System.Drawing.Point(478, 68);
            this.butKindMenu.Name = "butKindMenu";
            this.butKindMenu.Size = new System.Drawing.Size(75, 23);
            this.butKindMenu.TabIndex = 32;
            this.butKindMenu.Text = "Kind Menu";
            this.butKindMenu.UseVisualStyleBackColor = true;
            this.butKindMenu.Click += new System.EventHandler(this.butKindMenu_Click);
            // 
            // butSize
            // 
            this.butSize.Location = new System.Drawing.Point(478, 98);
            this.butSize.Name = "butSize";
            this.butSize.Size = new System.Drawing.Size(75, 23);
            this.butSize.TabIndex = 33;
            this.butSize.Text = "Size Menu";
            this.butSize.UseVisualStyleBackColor = true;
            this.butSize.Click += new System.EventHandler(this.butSize_Click);
            // 
            // butLog
            // 
            this.butLog.Location = new System.Drawing.Point(899, 10);
            this.butLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(75, 23);
            this.butLog.TabIndex = 34;
            this.butLog.Text = "Log in";
            this.butLog.UseVisualStyleBackColor = true;
            this.butLog.Visible = false;
            this.butLog.Click += new System.EventHandler(this.butLog_Click);
            // 
            // butReg
            // 
            this.butReg.Location = new System.Drawing.Point(899, 39);
            this.butReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(75, 23);
            this.butReg.TabIndex = 35;
            this.butReg.Text = "Register";
            this.butReg.UseVisualStyleBackColor = true;
            this.butReg.Visible = false;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // labelConn
            // 
            this.labelConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelConn.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelConn.Location = new System.Drawing.Point(899, 68);
            this.labelConn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(75, 40);
            this.labelConn.TabIndex = 36;
            this.labelConn.Text = "Connected ";
            // 
            // butAdmPnl
            // 
            this.butAdmPnl.Location = new System.Drawing.Point(899, 110);
            this.butAdmPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAdmPnl.Name = "butAdmPnl";
            this.butAdmPnl.Size = new System.Drawing.Size(75, 22);
            this.butAdmPnl.TabIndex = 37;
            this.butAdmPnl.Text = "AdminPanel";
            this.butAdmPnl.UseVisualStyleBackColor = true;
            this.butAdmPnl.Visible = false;
            this.butAdmPnl.Click += new System.EventHandler(this.butAdmPnl_Click);
            // 
            // butLogOut
            // 
            this.butLogOut.Location = new System.Drawing.Point(899, 140);
            this.butLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(75, 22);
            this.butLogOut.TabIndex = 38;
            this.butLogOut.Text = "Log out";
            this.butLogOut.UseVisualStyleBackColor = true;
            this.butLogOut.Visible = false;
            this.butLogOut.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 450);
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
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
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

