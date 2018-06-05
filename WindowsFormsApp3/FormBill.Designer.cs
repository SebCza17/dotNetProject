namespace WindowsFormsApp3
{
    partial class FormBill
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
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxOrderDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.Location = new System.Drawing.Point(13, 45);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(249, 238);
            this.listBoxOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSum.Location = new System.Drawing.Point(211, 286);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(51, 20);
            this.labelSum.TabIndex = 2;
            this.labelSum.Text = "label2";
            // 
            // textBoxOrderDesc
            // 
            this.textBoxOrderDesc.Location = new System.Drawing.Point(15, 309);
            this.textBoxOrderDesc.Multiline = true;
            this.textBoxOrderDesc.Name = "textBoxOrderDesc";
            this.textBoxOrderDesc.Size = new System.Drawing.Size(248, 122);
            this.textBoxOrderDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(111, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bill";
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(186, 524);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(15, 524);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 6;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Location = new System.Drawing.Point(74, 462);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKind.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kind: ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKind);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOrderDesc);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOrder);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxOrderDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.Label label3;
    }
}