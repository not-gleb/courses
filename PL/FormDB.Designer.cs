
namespace PL
{
    partial class FormDB
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
            this.Organisations = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrganisation = new System.Windows.Forms.DataGridView();
            this.dataGridViewLecturers = new System.Windows.Forms.DataGridView();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.Organisations.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // Organisations
            // 
            this.Organisations.Controls.Add(this.tabPage1);
            this.Organisations.Controls.Add(this.tabPage2);
            this.Organisations.Controls.Add(this.tabPage3);
            this.Organisations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Organisations.Location = new System.Drawing.Point(0, 0);
            this.Organisations.Name = "Organisations";
            this.Organisations.SelectedIndex = 0;
            this.Organisations.Size = new System.Drawing.Size(1283, 788);
            this.Organisations.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewOrganisation);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1275, 745);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Organisations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewLecturers);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1275, 745);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lecturers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewCourses);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1275, 745);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Courses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrganisation
            // 
            this.dataGridViewOrganisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganisation.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOrganisation.Location = new System.Drawing.Point(372, 3);
            this.dataGridViewOrganisation.Name = "dataGridViewOrganisation";
            this.dataGridViewOrganisation.RowHeadersWidth = 72;
            this.dataGridViewOrganisation.RowTemplate.Height = 37;
            this.dataGridViewOrganisation.Size = new System.Drawing.Size(900, 739);
            this.dataGridViewOrganisation.TabIndex = 0;
            // 
            // dataGridViewLecturers
            // 
            this.dataGridViewLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewLecturers.Location = new System.Drawing.Point(372, 3);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.RowHeadersWidth = 72;
            this.dataGridViewLecturers.RowTemplate.Height = 37;
            this.dataGridViewLecturers.Size = new System.Drawing.Size(900, 739);
            this.dataGridViewLecturers.TabIndex = 0;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewCourses.Location = new System.Drawing.Point(372, 3);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 72;
            this.dataGridViewCourses.RowTemplate.Height = 37;
            this.dataGridViewCourses.Size = new System.Drawing.Size(900, 739);
            this.dataGridViewCourses.TabIndex = 0;
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 788);
            this.Controls.Add(this.Organisations);
            this.Name = "FormDB";
            this.Text = "FormDB";
            this.Organisations.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Organisations;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewOrganisation;
        private System.Windows.Forms.DataGridView dataGridViewLecturers;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
    }
}