﻿namespace ProjectPP
{
    partial class NewPass
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShowConfirmPassword = new System.Windows.Forms.Button();
            this.btnShowNewPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNewPassword.Location = new System.Drawing.Point(346, 179);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(115, 21);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password:";
            this.lblNewPassword.Click += new System.EventHandler(this.lblNewPassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewPassword.Location = new System.Drawing.Point(351, 210);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(350, 29);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(346, 269);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(140, 21);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirm Password:";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblConfirmPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(351, 300);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(350, 29);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnUpdatePassword.FlatAppearance.BorderSize = 0;
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePassword.Location = new System.Drawing.Point(351, 379);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(445, 50);
            this.btnUpdatePassword.TabIndex = 7;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(386, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Set New Password";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnShowConfirmPassword
            // 
            this.btnShowConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowConfirmPassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConfirmPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(942, 269);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(44, 34);
            this.btnShowConfirmPassword.TabIndex = 6;
            this.btnShowConfirmPassword.Text = "👀";
            this.btnShowConfirmPassword.UseVisualStyleBackColor = false;
            this.btnShowConfirmPassword.Click += new System.EventHandler(this.togglePasswordVisibility_Click);
            // 
            // btnShowNewPassword
            // 
            this.btnShowNewPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowNewPassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNewPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNewPassword.Location = new System.Drawing.Point(942, 210);
            this.btnShowNewPassword.Name = "btnShowNewPassword";
            this.btnShowNewPassword.Size = new System.Drawing.Size(44, 34);
            this.btnShowNewPassword.TabIndex = 3;
            this.btnShowNewPassword.Text = "👀";
            this.btnShowNewPassword.UseVisualStyleBackColor = false;
            this.btnShowNewPassword.Click += new System.EventHandler(this.togglePasswordVisibility_Click);
            // 
            // NewPass
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btnShowNewPassword);
            this.Controls.Add(this.btnShowConfirmPassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblTitle);
            this.Name = "NewPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set New Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnShowConfirmPassword;
        private System.Windows.Forms.Button btnShowNewPassword;
    }
}