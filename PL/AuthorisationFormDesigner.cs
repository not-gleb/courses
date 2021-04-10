
namespace PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegPWConfirm = new System.Windows.Forms.TextBox();
            this.textBoxRegPW = new System.Windows.Forms.TextBox();
            this.textBoxRegUsername = new System.Windows.Forms.TextBox();
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.buttonWelcomeMenuLogIn = new System.Windows.Forms.Button();
            this.buttonWelcomeMenuRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogIn.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Location = new System.Drawing.Point(238, 99);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(219, 26);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(238, 139);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(219, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogIn.Location = new System.Drawing.Point(160, 184);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(313, 44);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.buttonBack);
            this.panelLogIn.Controls.Add(this.label1);
            this.panelLogIn.Controls.Add(this.label2);
            this.panelLogIn.Controls.Add(this.textBoxUsername);
            this.panelLogIn.Controls.Add(this.textBoxPassword);
            this.panelLogIn.Controls.Add(this.buttonLogIn);
            this.panelLogIn.Location = new System.Drawing.Point(0, 0);
            this.panelLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(635, 334);
            this.panelLogIn.TabIndex = 20;
            this.panelLogIn.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(8, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(38, 38);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "<--";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.buttonBack2);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.textBoxRegPWConfirm);
            this.panelRegister.Controls.Add(this.textBoxRegPW);
            this.panelRegister.Controls.Add(this.textBoxRegUsername);
            this.panelRegister.Controls.Add(this.buttonRegisterUser);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(635, 334);
            this.panelRegister.TabIndex = 20;
            this.panelRegister.Visible = false;
            // 
            // buttonBack2
            // 
            this.buttonBack2.Location = new System.Drawing.Point(14, 15);
            this.buttonBack2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(48, 38);
            this.buttonBack2.TabIndex = 7;
            this.buttonBack2.Text = "<--";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirm password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username:";
            // 
            // textBoxRegPWConfirm
            // 
            this.textBoxRegPWConfirm.Location = new System.Drawing.Point(261, 142);
            this.textBoxRegPWConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegPWConfirm.Name = "textBoxRegPWConfirm";
            this.textBoxRegPWConfirm.PasswordChar = '●';
            this.textBoxRegPWConfirm.Size = new System.Drawing.Size(225, 26);
            this.textBoxRegPWConfirm.TabIndex = 3;
            // 
            // textBoxRegPW
            // 
            this.textBoxRegPW.Location = new System.Drawing.Point(261, 98);
            this.textBoxRegPW.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegPW.Name = "textBoxRegPW";
            this.textBoxRegPW.PasswordChar = '●';
            this.textBoxRegPW.Size = new System.Drawing.Size(225, 26);
            this.textBoxRegPW.TabIndex = 2;
            // 
            // textBoxRegUsername
            // 
            this.textBoxRegUsername.Location = new System.Drawing.Point(261, 58);
            this.textBoxRegUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegUsername.Name = "textBoxRegUsername";
            this.textBoxRegUsername.Size = new System.Drawing.Size(225, 26);
            this.textBoxRegUsername.TabIndex = 1;
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Location = new System.Drawing.Point(125, 184);
            this.buttonRegisterUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(361, 44);
            this.buttonRegisterUser.TabIndex = 0;
            this.buttonRegisterUser.Text = "Register";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            this.buttonRegisterUser.Click += new System.EventHandler(this.buttonRegisterUser_Click);
            // 
            // buttonWelcomeMenuLogIn
            // 
            this.buttonWelcomeMenuLogIn.Location = new System.Drawing.Point(189, 86);
            this.buttonWelcomeMenuLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWelcomeMenuLogIn.Name = "buttonWelcomeMenuLogIn";
            this.buttonWelcomeMenuLogIn.Size = new System.Drawing.Size(243, 50);
            this.buttonWelcomeMenuLogIn.TabIndex = 0;
            this.buttonWelcomeMenuLogIn.Text = "Log in";
            this.buttonWelcomeMenuLogIn.UseVisualStyleBackColor = true;
            this.buttonWelcomeMenuLogIn.Click += new System.EventHandler(this.buttonWelcomeMenuLogIn_Click);
            // 
            // buttonWelcomeMenuRegister
            // 
            this.buttonWelcomeMenuRegister.Location = new System.Drawing.Point(189, 184);
            this.buttonWelcomeMenuRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWelcomeMenuRegister.Name = "buttonWelcomeMenuRegister";
            this.buttonWelcomeMenuRegister.Size = new System.Drawing.Size(243, 53);
            this.buttonWelcomeMenuRegister.TabIndex = 0;
            this.buttonWelcomeMenuRegister.Text = "Register";
            this.buttonWelcomeMenuRegister.UseVisualStyleBackColor = true;
            this.buttonWelcomeMenuRegister.Click += new System.EventHandler(this.buttonWelcomeMenuRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(222, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 334);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonWelcomeMenuRegister);
            this.Controls.Add(this.buttonWelcomeMenuLogIn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Authorisation";
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Button buttonWelcomeMenuLogIn;
        private System.Windows.Forms.Button buttonWelcomeMenuRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegPWConfirm;
        private System.Windows.Forms.TextBox textBoxRegPW;
        private System.Windows.Forms.TextBox textBoxRegUsername;
        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.Button buttonBack2;
    }
}

