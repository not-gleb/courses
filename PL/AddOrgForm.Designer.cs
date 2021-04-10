
namespace PL
{
    partial class AddOrgForm
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
            this.adressTB = new System.Windows.Forms.TextBox();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.coursesLB = new System.Windows.Forms.ListBox();
            this.buttonAddOrg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(201, 44);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(120, 26);
            this.adressTB.TabIndex = 0;
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(24, 160);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(120, 26);
            this.numberTB.TabIndex = 1;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(201, 105);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(120, 26);
            this.emailTB.TabIndex = 2;
            // 
            // coursesLB
            // 
            this.coursesLB.FormattingEnabled = true;
            this.coursesLB.ItemHeight = 19;
            this.coursesLB.Items.AddRange(new object[] {
            ""});
            this.coursesLB.Location = new System.Drawing.Point(24, 47);
            this.coursesLB.Name = "coursesLB";
            this.coursesLB.Size = new System.Drawing.Size(144, 80);
            this.coursesLB.TabIndex = 3;
            // 
            // buttonAddOrg
            // 
            this.buttonAddOrg.Location = new System.Drawing.Point(24, 201);
            this.buttonAddOrg.Name = "buttonAddOrg";
            this.buttonAddOrg.Size = new System.Drawing.Size(297, 80);
            this.buttonAddOrg.TabIndex = 4;
            this.buttonAddOrg.Text = "Add";
            this.buttonAddOrg.UseVisualStyleBackColor = true;
            this.buttonAddOrg.Click += new System.EventHandler(this.buttonOrgAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // AddOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 293);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddOrg);
            this.Controls.Add(this.coursesLB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.adressTB);
            this.MaximizeBox = false;
            this.Name = "AddOrgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add organisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.ListBox coursesLB;
        private System.Windows.Forms.Button buttonAddOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}