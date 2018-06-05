namespace WindowsFormsApp3
{
    partial class FormProfit
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
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.dateTimeOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(12, 112);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(491, 250);
            this.dataGridOrder.TabIndex = 0;
            // 
            // dateTimeOd
            // 
            this.dateTimeOd.Location = new System.Drawing.Point(12, 25);
            this.dateTimeOd.Name = "dateTimeOd";
            this.dateTimeOd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeOd.TabIndex = 1;
            // 
            // dateTimeDo
            // 
            this.dateTimeDo.Location = new System.Drawing.Point(303, 25);
            this.dateTimeDo.Name = "dateTimeDo";
            this.dateTimeDo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do:";
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(218, 83);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(75, 23);
            this.butShow.TabIndex = 5;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 472);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeDo);
            this.Controls.Add(this.dateTimeOd);
            this.Controls.Add(this.dataGridOrder);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.DateTimePicker dateTimeOd;
        private System.Windows.Forms.DateTimePicker dateTimeDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butShow;
    }
}