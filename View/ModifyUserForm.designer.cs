namespace User
{
    partial class ModifyUserForm
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
            this.btnModifySaveUser = new System.Windows.Forms.Button();
            this.dtpModifyUserExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.txtModifyUserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnModifySaveUser
            // 
            this.btnModifySaveUser.Location = new System.Drawing.Point(285, 107);
            this.btnModifySaveUser.Name = "btnModifySaveUser";
            this.btnModifySaveUser.Size = new System.Drawing.Size(60, 23);
            this.btnModifySaveUser.TabIndex = 19;
            this.btnModifySaveUser.Text = "Guardar";
            this.btnModifySaveUser.UseVisualStyleBackColor = true;
            this.btnModifySaveUser.Click += new System.EventHandler(this.btnModifySaveUser_Click);
            // 
            // dtpModifyUserExpirationDate
            // 
            this.dtpModifyUserExpirationDate.Location = new System.Drawing.Point(133, 59);
            this.dtpModifyUserExpirationDate.Name = "dtpModifyUserExpirationDate";
            this.dtpModifyUserExpirationDate.Size = new System.Drawing.Size(212, 20);
            this.dtpModifyUserExpirationDate.TabIndex = 16;
            // 
            // txtModifyUserPassword
            // 
            this.txtModifyUserPassword.Location = new System.Drawing.Point(133, 31);
            this.txtModifyUserPassword.Name = "txtModifyUserPassword";
            this.txtModifyUserPassword.Size = new System.Drawing.Size(139, 20);
            this.txtModifyUserPassword.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de expiración:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 89);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 138);
            this.Controls.Add(this.btnModifySaveUser);
            this.Controls.Add(this.dtpModifyUserExpirationDate);
            this.Controls.Add(this.txtModifyUserPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyUserForm";
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.ModifyUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifySaveUser;
        private System.Windows.Forms.DateTimePicker dtpModifyUserExpirationDate;
        private System.Windows.Forms.TextBox txtModifyUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}