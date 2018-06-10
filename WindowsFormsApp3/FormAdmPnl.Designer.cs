namespace WindowsFormsApp3
{
    partial class FormAdmPnl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSAve = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(517, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(15, 208);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(131, 21);
            this.comboBoxRole.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBack.Location = new System.Drawing.Point(15, 245);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 33);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "...Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSAve
            // 
            this.buttonSAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSAve.Location = new System.Drawing.Point(150, 196);
            this.buttonSAve.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSAve.Name = "buttonSAve";
            this.buttonSAve.Size = new System.Drawing.Size(114, 33);
            this.buttonSAve.TabIndex = 4;
            this.buttonSAve.Text = "Change role";
            this.buttonSAve.UseVisualStyleBackColor = true;
            this.buttonSAve.Click += new System.EventHandler(this.buttonSAve_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMsg.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelMsg.Location = new System.Drawing.Point(470, 224);
            this.labelMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(56, 20);
            this.labelMsg.TabIndex = 5;
            this.labelMsg.Text = "Done !";
            this.labelMsg.Visible = false;
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.butDelete.Location = new System.Drawing.Point(150, 245);
            this.butDelete.Margin = new System.Windows.Forms.Padding(2);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(114, 33);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change role...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Drop and Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Fill sample";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAdmPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.buttonSAve);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmPnl";
            this.Text = "FormAdmPnl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSAve;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}