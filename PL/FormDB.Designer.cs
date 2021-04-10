
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
            this.buttonDeleteOrg = new System.Windows.Forms.Button();
            this.dataGridViewOrganisation = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDeleteLec = new System.Windows.Forms.Button();
            this.dataGridViewLecturers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.Organisations.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganisation)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            this.Organisations.Margin = new System.Windows.Forms.Padding(2);
            this.Organisations.Name = "Organisations";
            this.Organisations.SelectedIndex = 0;
            this.Organisations.Size = new System.Drawing.Size(855, 499);
            this.Organisations.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDeleteOrg);
            this.tabPage1.Controls.Add(this.dataGridViewOrganisation);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(847, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Organisations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrg
            // 
            this.buttonDeleteOrg.Location = new System.Drawing.Point(27, 54);
            this.buttonDeleteOrg.Name = "buttonDeleteOrg";
            this.buttonDeleteOrg.Size = new System.Drawing.Size(90, 28);
            this.buttonDeleteOrg.TabIndex = 1;
            this.buttonDeleteOrg.Text = "Delete";
            this.buttonDeleteOrg.UseVisualStyleBackColor = true;
            this.buttonDeleteOrg.Click += new System.EventHandler(this.buttonDeleteOrg_Click);
            // 
            // dataGridViewOrganisation
            // 
            this.dataGridViewOrganisation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrganisation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewOrganisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganisation.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOrganisation.Location = new System.Drawing.Point(138, 2);
            this.dataGridViewOrganisation.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrganisation.Name = "dataGridViewOrganisation";
            this.dataGridViewOrganisation.RowHeadersWidth = 72;
            this.dataGridViewOrganisation.RowTemplate.Height = 37;
            this.dataGridViewOrganisation.Size = new System.Drawing.Size(707, 463);
            this.dataGridViewOrganisation.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeleteLec);
            this.tabPage2.Controls.Add(this.dataGridViewLecturers);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(847, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lecturers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteLec
            // 
            this.buttonDeleteLec.Location = new System.Drawing.Point(59, 76);
            this.buttonDeleteLec.Name = "buttonDeleteLec";
            this.buttonDeleteLec.Size = new System.Drawing.Size(90, 28);
            this.buttonDeleteLec.TabIndex = 1;
            this.buttonDeleteLec.Text = "Delete";
            this.buttonDeleteLec.UseVisualStyleBackColor = true;
            this.buttonDeleteLec.Click += new System.EventHandler(this.buttonDeleteLec_Click);
            // 
            // dataGridViewLecturers
            // 
            this.dataGridViewLecturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLecturers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewLecturers.Location = new System.Drawing.Point(245, 2);
            this.dataGridViewLecturers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.RowHeadersWidth = 72;
            this.dataGridViewLecturers.RowTemplate.Height = 37;
            this.dataGridViewLecturers.Size = new System.Drawing.Size(600, 463);
            this.dataGridViewLecturers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAddCourse);
            this.tabPage3.Controls.Add(this.buttonDeleteCourse);
            this.tabPage3.Controls.Add(this.dataGridViewCourses);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(847, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Courses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Location = new System.Drawing.Point(57, 98);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(90, 28);
            this.buttonDeleteCourse.TabIndex = 1;
            this.buttonDeleteCourse.Text = "Delete";
            this.buttonDeleteCourse.UseVisualStyleBackColor = true;
            this.buttonDeleteCourse.Click += new System.EventHandler(this.buttonDeleteCourse_Click);
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewCourses.Location = new System.Drawing.Point(245, 2);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 72;
            this.dataGridViewCourses.RowTemplate.Height = 37;
            this.dataGridViewCourses.Size = new System.Drawing.Size(600, 463);
            this.dataGridViewCourses.TabIndex = 0;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(57, 64);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(90, 28);
            this.buttonAddCourse.TabIndex = 2;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 499);
            this.Controls.Add(this.Organisations);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDB";
            this.Text = "FormDB";
            this.Organisations.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganisation)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonDeleteOrg;
        private System.Windows.Forms.Button buttonDeleteLec;
        private System.Windows.Forms.Button buttonDeleteCourse;
        private System.Windows.Forms.Button buttonAddCourse;
    }
}