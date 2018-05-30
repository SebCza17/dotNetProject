namespace WindowsFormsApp3
{
    partial class Form2
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
            this.butSaveDetail = new System.Windows.Forms.Button();
            this.butEditDetail = new System.Windows.Forms.Button();
            this.checkBoxAva = new System.Windows.Forms.CheckBox();
            this.errorLab2 = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butAddDetail = new System.Windows.Forms.Button();
            this.butSaveDrink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.butEditDrink = new System.Windows.Forms.Button();
            this.butDelDrink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.butAddDrink = new System.Windows.Forms.Button();
            this.butDelDetail = new System.Windows.Forms.Button();
            this.dataGridDetail = new System.Windows.Forms.DataGridView();
            this.butShowDetail = new System.Windows.Forms.Button();
            this.dataGridDrink = new System.Windows.Forms.DataGridView();
            this.checkBoxIsAdult = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // butSaveDetail
            // 
            this.butSaveDetail.Location = new System.Drawing.Point(268, 353);
            this.butSaveDetail.Name = "butSaveDetail";
            this.butSaveDetail.Size = new System.Drawing.Size(75, 23);
            this.butSaveDetail.TabIndex = 53;
            this.butSaveDetail.Text = "Save";
            this.butSaveDetail.UseVisualStyleBackColor = true;
            this.butSaveDetail.Click += new System.EventHandler(this.butSaveDetail_Click);
            // 
            // butEditDetail
            // 
            this.butEditDetail.Location = new System.Drawing.Point(186, 353);
            this.butEditDetail.Name = "butEditDetail";
            this.butEditDetail.Size = new System.Drawing.Size(75, 23);
            this.butEditDetail.TabIndex = 52;
            this.butEditDetail.Text = "Edit Detail";
            this.butEditDetail.UseVisualStyleBackColor = true;
            this.butEditDetail.Click += new System.EventHandler(this.butEditDetail_Click);
            // 
            // checkBoxAva
            // 
            this.checkBoxAva.AutoSize = true;
            this.checkBoxAva.Location = new System.Drawing.Point(75, 389);
            this.checkBoxAva.Name = "checkBoxAva";
            this.checkBoxAva.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAva.TabIndex = 51;
            this.checkBoxAva.UseVisualStyleBackColor = true;
            // 
            // errorLab2
            // 
            this.errorLab2.AutoSize = true;
            this.errorLab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLab2.ForeColor = System.Drawing.Color.Brown;
            this.errorLab2.Location = new System.Drawing.Point(333, 173);
            this.errorLab2.Name = "errorLab2";
            this.errorLab2.Size = new System.Drawing.Size(29, 13);
            this.errorLab2.TabIndex = 50;
            this.errorLab2.Text = "Error";
            this.errorLab2.Visible = false;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(75, 489);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(100, 20);
            this.textBoxTax.TabIndex = 49;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(75, 463);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 48;
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Location = new System.Drawing.Point(75, 436);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKind.TabIndex = 47;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(75, 409);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSize.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Kind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Availability";
            // 
            // butAddDetail
            // 
            this.butAddDetail.Location = new System.Drawing.Point(104, 354);
            this.butAddDetail.Name = "butAddDetail";
            this.butAddDetail.Size = new System.Drawing.Size(75, 23);
            this.butAddDetail.TabIndex = 40;
            this.butAddDetail.Text = "Add Details";
            this.butAddDetail.UseVisualStyleBackColor = true;
            this.butAddDetail.Click += new System.EventHandler(this.butAddDetail_Click);
            // 
            // butSaveDrink
            // 
            this.butSaveDrink.Location = new System.Drawing.Point(369, 99);
            this.butSaveDrink.Name = "butSaveDrink";
            this.butSaveDrink.Size = new System.Drawing.Size(75, 23);
            this.butSaveDrink.TabIndex = 39;
            this.butSaveDrink.Text = "Save";
            this.butSaveDrink.UseVisualStyleBackColor = true;
            this.butSaveDrink.Click += new System.EventHandler(this.butSaveDrink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Description:";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(515, 71);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(151, 20);
            this.textBoxDesc.TabIndex = 37;
            // 
            // butEditDrink
            // 
            this.butEditDrink.Location = new System.Drawing.Point(369, 69);
            this.butEditDrink.Name = "butEditDrink";
            this.butEditDrink.Size = new System.Drawing.Size(75, 23);
            this.butEditDrink.TabIndex = 36;
            this.butEditDrink.Text = "Edit Drink";
            this.butEditDrink.UseVisualStyleBackColor = true;
            this.butEditDrink.Click += new System.EventHandler(this.butEditDrink_Click);
            // 
            // butDelDrink
            // 
            this.butDelDrink.Location = new System.Drawing.Point(369, 11);
            this.butDelDrink.Name = "butDelDrink";
            this.butDelDrink.Size = new System.Drawing.Size(75, 23);
            this.butDelDrink.TabIndex = 35;
            this.butDelDrink.Text = "Delete Drink";
            this.butDelDrink.UseVisualStyleBackColor = true;
            this.butDelDrink.Click += new System.EventHandler(this.butDelDrink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Dish Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(515, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 33;
            // 
            // butAddDrink
            // 
            this.butAddDrink.Location = new System.Drawing.Point(369, 40);
            this.butAddDrink.Name = "butAddDrink";
            this.butAddDrink.Size = new System.Drawing.Size(75, 23);
            this.butAddDrink.TabIndex = 32;
            this.butAddDrink.Text = "Add Drink";
            this.butAddDrink.UseVisualStyleBackColor = true;
            this.butAddDrink.Click += new System.EventHandler(this.butAddDrink_Click);
            // 
            // butDelDetail
            // 
            this.butDelDetail.Location = new System.Drawing.Point(11, 354);
            this.butDelDetail.Name = "butDelDetail";
            this.butDelDetail.Size = new System.Drawing.Size(87, 23);
            this.butDelDetail.TabIndex = 31;
            this.butDelDetail.Text = "Delete Details";
            this.butDelDetail.UseVisualStyleBackColor = true;
            this.butDelDetail.Click += new System.EventHandler(this.butDelDetail_Click);
            // 
            // dataGridDetail
            // 
            this.dataGridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridDetail.Location = new System.Drawing.Point(12, 198);
            this.dataGridDetail.Name = "dataGridDetail";
            this.dataGridDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridDetail.Size = new System.Drawing.Size(654, 150);
            this.dataGridDetail.TabIndex = 30;
            // 
            // butShowDetail
            // 
            this.butShowDetail.Location = new System.Drawing.Point(11, 168);
            this.butShowDetail.Name = "butShowDetail";
            this.butShowDetail.Size = new System.Drawing.Size(77, 23);
            this.butShowDetail.TabIndex = 29;
            this.butShowDetail.Text = "Show Details";
            this.butShowDetail.UseVisualStyleBackColor = true;
            this.butShowDetail.Click += new System.EventHandler(this.butShowDetail_Click);
            // 
            // dataGridDrink
            // 
            this.dataGridDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDrink.Location = new System.Drawing.Point(12, 12);
            this.dataGridDrink.Name = "dataGridDrink";
            this.dataGridDrink.Size = new System.Drawing.Size(350, 150);
            this.dataGridDrink.TabIndex = 28;
            // 
            // checkBoxIsAdult
            // 
            this.checkBoxIsAdult.AutoSize = true;
            this.checkBoxIsAdult.Location = new System.Drawing.Point(515, 103);
            this.checkBoxIsAdult.Name = "checkBoxIsAdult";
            this.checkBoxIsAdult.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsAdult.TabIndex = 54;
            this.checkBoxIsAdult.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Adults:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxIsAdult);
            this.Controls.Add(this.butSaveDetail);
            this.Controls.Add(this.butEditDetail);
            this.Controls.Add(this.checkBoxAva);
            this.Controls.Add(this.errorLab2);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxKind);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butAddDetail);
            this.Controls.Add(this.butSaveDrink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.butEditDrink);
            this.Controls.Add(this.butDelDrink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.butAddDrink);
            this.Controls.Add(this.butDelDetail);
            this.Controls.Add(this.dataGridDetail);
            this.Controls.Add(this.butShowDetail);
            this.Controls.Add(this.dataGridDrink);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSaveDetail;
        private System.Windows.Forms.Button butEditDetail;
        private System.Windows.Forms.CheckBox checkBoxAva;
        private System.Windows.Forms.Label errorLab2;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butAddDetail;
        private System.Windows.Forms.Button butSaveDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Button butEditDrink;
        private System.Windows.Forms.Button butDelDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button butAddDrink;
        private System.Windows.Forms.Button butDelDetail;
        private System.Windows.Forms.DataGridView dataGridDetail;
        private System.Windows.Forms.Button butShowDetail;
        private System.Windows.Forms.DataGridView dataGridDrink;
        private System.Windows.Forms.CheckBox checkBoxIsAdult;
        private System.Windows.Forms.Label label2;
    }
}