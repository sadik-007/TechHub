﻿namespace ProjectPP
{
    partial class Form1
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.linkBackToHome = new System.Windows.Forms.LinkLabel();
            this.btnShowHidePassword = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LbPass = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.LbUname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.LightGreen;
            this.pnlMain.Controls.Add(this.linkBackToHome);
            this.pnlMain.Controls.Add(this.btnShowHidePassword);
            this.pnlMain.Controls.Add(this.linkLabel2);
            this.pnlMain.Controls.Add(this.linkLabel1);
            this.pnlMain.Controls.Add(this.btnLogIn);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.LbPass);
            this.pnlMain.Controls.Add(this.txtUserName);
            this.pnlMain.Controls.Add(this.LbUname);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(256, 62);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(375, 447);
            this.pnlMain.TabIndex = 0;
            // 
            // linkBackToHome
            // 
            this.linkBackToHome.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.linkBackToHome.AutoSize = true;
            this.linkBackToHome.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.linkBackToHome.LinkColor = System.Drawing.Color.Gray;
            this.linkBackToHome.Location = new System.Drawing.Point(131, 418);
            this.linkBackToHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkBackToHome.Name = "linkBackToHome";
            this.linkBackToHome.Size = new System.Drawing.Size(125, 19);
            this.linkBackToHome.TabIndex = 7;
            this.linkBackToHome.TabStop = true;
            this.linkBackToHome.Text = "Back to Homepage";
            this.linkBackToHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackToHome_LinkClicked);
            // 
            // btnShowHidePassword
            // 
            this.btnShowHidePassword.BackColor = System.Drawing.Color.White;
            this.btnShowHidePassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHidePassword.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.btnShowHidePassword.Location = new System.Drawing.Point(306, 236);
            this.btnShowHidePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowHidePassword.Name = "btnShowHidePassword";
            this.btnShowHidePassword.Size = new System.Drawing.Size(32, 28);
            this.btnShowHidePassword.TabIndex = 3;
            this.btnShowHidePassword.Text = "👀";
            this.btnShowHidePassword.UseVisualStyleBackColor = false;
            this.btnShowHidePassword.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(217, 358);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(134, 19);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Don\'t have account?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(38, 358);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(40, 288);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(297, 45);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(40, 236);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(267, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // LbPass
            // 
            this.LbPass.AutoSize = true;
            this.LbPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.LbPass.Location = new System.Drawing.Point(37, 210);
            this.LbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPass.Name = "LbPass";
            this.LbPass.Size = new System.Drawing.Size(76, 21);
            this.LbPass.TabIndex = 4;
            this.LbPass.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.Location = new System.Drawing.Point(40, 158);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(298, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // LbUname
            // 
            this.LbUname.AutoSize = true;
            this.LbUname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LbUname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.LbUname.Location = new System.Drawing.Point(37, 133);
            this.LbUname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbUname.Name = "LbUname";
            this.LbUname.Size = new System.Drawing.Size(88, 21);
            this.LbUname.TabIndex = 2;
            this.LbUname.Text = "User Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(2, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Log In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(886, 571);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbUname;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label LbPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnShowHidePassword;
        private System.Windows.Forms.LinkLabel linkBackToHome;
    }
}