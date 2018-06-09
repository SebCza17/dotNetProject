namespace WindowsFormsApp3
{
    partial class FormFirst
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
            this.butLog_In = new System.Windows.Forms.Button();
            this.butRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butLog_In
            // 
            this.butLog_In.Location = new System.Drawing.Point(152, 98);
            this.butLog_In.Name = "butLog_In";
            this.butLog_In.Size = new System.Drawing.Size(132, 38);
            this.butLog_In.TabIndex = 0;
            this.butLog_In.Text = "Log In";
            this.butLog_In.UseVisualStyleBackColor = true;
            this.butLog_In.Click += new System.EventHandler(this.button1_Click);
            // 
            // butRegister
            // 
            this.butRegister.Location = new System.Drawing.Point(152, 159);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(132, 36);
            this.butRegister.TabIndex = 1;
            this.butRegister.Text = "Register";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // FormFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 300);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.butLog_In);
            this.Name = "FormFirst";
            this.Text = "FormFirst";
            this.Load += new System.EventHandler(this.FormFirst_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLog_In;
        private System.Windows.Forms.Button butRegister;
    }
}