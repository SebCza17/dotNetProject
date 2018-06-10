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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(22, 320);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(194, 28);
            this.comboBoxRole.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBack.Location = new System.Drawing.Point(22, 377);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(123, 51);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "...Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSAve
            // 
            this.buttonSAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSAve.Location = new System.Drawing.Point(617, 377);
            this.buttonSAve.Name = "buttonSAve";
            this.buttonSAve.Size = new System.Drawing.Size(171, 51);
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
            this.labelMsg.Location = new System.Drawing.Point(705, 345);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(83, 29);
            this.labelMsg.TabIndex = 5;
            this.labelMsg.Text = "Done !";
            this.labelMsg.Visible = false;
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.butDelete.Location = new System.Drawing.Point(425, 377);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(171, 51);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change role...";
            // 
            // FormAdmPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.buttonSAve);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.dataGridView1);
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
    }
}