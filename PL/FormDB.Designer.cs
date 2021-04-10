
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
            this.buttonExportExcelOrg = new System.Windows.Forms.Button();
            this.buttonExportWordOrg = new System.Windows.Forms.Button();
            this.checkBoxOrderOrg = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilterOrgName = new System.Windows.Forms.TextBox();
            this.buttonAddOrg = new System.Windows.Forms.Button();
            this.buttonDeleteOrg = new System.Windows.Forms.Button();
            this.dataGridViewOrganisation = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExportExcelLec = new System.Windows.Forms.Button();
            this.buttonExportWordLec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilterLecturers = new System.Windows.Forms.TextBox();
            this.checkBoxOrderLec = new System.Windows.Forms.CheckBox();
            this.buttonAddLec = new System.Windows.Forms.Button();
            this.buttonDeleteLec = new System.Windows.Forms.Button();
            this.dataGridViewLecturers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonExportExcelCourses = new System.Windows.Forms.Button();
            this.buttonExportWordCourses = new System.Windows.Forms.Button();
            this.checkBoxOrderCourses = new System.Windows.Forms.CheckBox();
            this.textBoxFilterCourses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
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
            this.Organisations.Name = "Organisations";
            this.Organisations.SelectedIndex = 0;
            this.Organisations.Size = new System.Drawing.Size(1419, 845);
            this.Organisations.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonExportExcelOrg);
            this.tabPage1.Controls.Add(this.buttonExportWordOrg);
            this.tabPage1.Controls.Add(this.checkBoxOrderOrg);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxFilterOrgName);
            this.tabPage1.Controls.Add(this.buttonAddOrg);
            this.tabPage1.Controls.Add(this.buttonDeleteOrg);
            this.tabPage1.Controls.Add(this.dataGridViewOrganisation);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1411, 802);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Organisations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExportExcelOrg
            // 
            this.buttonExportExcelOrg.Location = new System.Drawing.Point(24, 660);
            this.buttonExportExcelOrg.Name = "buttonExportExcelOrg";
            this.buttonExportExcelOrg.Size = new System.Drawing.Size(245, 110);
            this.buttonExportExcelOrg.TabIndex = 7;
            this.buttonExportExcelOrg.Text = "Export to excel document";
            this.buttonExportExcelOrg.UseVisualStyleBackColor = true;
            this.buttonExportExcelOrg.Click += new System.EventHandler(this.buttonExportExcelOrg_Click);
            // 
            // buttonExportWordOrg
            // 
            this.buttonExportWordOrg.Location = new System.Drawing.Point(24, 496);
            this.buttonExportWordOrg.Name = "buttonExportWordOrg";
            this.buttonExportWordOrg.Size = new System.Drawing.Size(245, 110);
            this.buttonExportWordOrg.TabIndex = 6;
            this.buttonExportWordOrg.Text = "Export to word document";
            this.buttonExportWordOrg.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrderOrg
            // 
            this.checkBoxOrderOrg.AutoSize = true;
            this.checkBoxOrderOrg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxOrderOrg.Location = new System.Drawing.Point(24, 427);
            this.checkBoxOrderOrg.Name = "checkBoxOrderOrg";
            this.checkBoxOrderOrg.Size = new System.Drawing.Size(92, 34);
            this.checkBoxOrderOrg.TabIndex = 5;
            this.checkBoxOrderOrg.Text = "Order";
            this.checkBoxOrderOrg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter";
            // 
            // textBoxFilterOrgName
            // 
            this.textBoxFilterOrgName.Location = new System.Drawing.Point(83, 371);
            this.textBoxFilterOrgName.Name = "textBoxFilterOrgName";
            this.textBoxFilterOrgName.Size = new System.Drawing.Size(186, 35);
            this.textBoxFilterOrgName.TabIndex = 3;
            this.textBoxFilterOrgName.TextChanged += new System.EventHandler(this.textBoxFilterOrgName_TextChanged);
            // 
            // buttonAddOrg
            // 
            this.buttonAddOrg.Location = new System.Drawing.Point(24, 43);
            this.buttonAddOrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddOrg.Name = "buttonAddOrg";
            this.buttonAddOrg.Size = new System.Drawing.Size(245, 110);
            this.buttonAddOrg.TabIndex = 2;
            this.buttonAddOrg.Text = "Add";
            this.buttonAddOrg.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrg
            // 
            this.buttonDeleteOrg.Location = new System.Drawing.Point(24, 205);
            this.buttonDeleteOrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteOrg.Name = "buttonDeleteOrg";
            this.buttonDeleteOrg.Size = new System.Drawing.Size(245, 110);
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
            this.dataGridViewOrganisation.Location = new System.Drawing.Point(308, 3);
            this.dataGridViewOrganisation.Name = "dataGridViewOrganisation";
            this.dataGridViewOrganisation.RowHeadersWidth = 72;
            this.dataGridViewOrganisation.RowTemplate.Height = 37;
            this.dataGridViewOrganisation.Size = new System.Drawing.Size(1100, 796);
            this.dataGridViewOrganisation.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExportExcelLec);
            this.tabPage2.Controls.Add(this.buttonExportWordLec);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxFilterLecturers);
            this.tabPage2.Controls.Add(this.checkBoxOrderLec);
            this.tabPage2.Controls.Add(this.buttonAddLec);
            this.tabPage2.Controls.Add(this.buttonDeleteLec);
            this.tabPage2.Controls.Add(this.dataGridViewLecturers);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1411, 802);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lecturers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExportExcelLec
            // 
            this.buttonExportExcelLec.Location = new System.Drawing.Point(24, 660);
            this.buttonExportExcelLec.Name = "buttonExportExcelLec";
            this.buttonExportExcelLec.Size = new System.Drawing.Size(245, 110);
            this.buttonExportExcelLec.TabIndex = 7;
            this.buttonExportExcelLec.Text = "Export to excel document";
            this.buttonExportExcelLec.UseVisualStyleBackColor = true;
            this.buttonExportExcelLec.Click += new System.EventHandler(this.buttonExportExcelLec_Click);
            // 
            // buttonExportWordLec
            // 
            this.buttonExportWordLec.Location = new System.Drawing.Point(24, 496);
            this.buttonExportWordLec.Name = "buttonExportWordLec";
            this.buttonExportWordLec.Size = new System.Drawing.Size(245, 110);
            this.buttonExportWordLec.TabIndex = 6;
            this.buttonExportWordLec.Text = "Export to word document";
            this.buttonExportWordLec.UseVisualStyleBackColor = true;
            this.buttonExportWordLec.Click += new System.EventHandler(this.buttonExportWordLec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter";
            // 
            // textBoxFilterLecturers
            // 
            this.textBoxFilterLecturers.Location = new System.Drawing.Point(83, 371);
            this.textBoxFilterLecturers.Name = "textBoxFilterLecturers";
            this.textBoxFilterLecturers.Size = new System.Drawing.Size(186, 35);
            this.textBoxFilterLecturers.TabIndex = 4;
            this.textBoxFilterLecturers.TextChanged += new System.EventHandler(this.textBoxFilterLecturers_TextChanged);
            // 
            // checkBoxOrderLec
            // 
            this.checkBoxOrderLec.AutoSize = true;
            this.checkBoxOrderLec.Location = new System.Drawing.Point(24, 427);
            this.checkBoxOrderLec.Name = "checkBoxOrderLec";
            this.checkBoxOrderLec.Size = new System.Drawing.Size(190, 34);
            this.checkBoxOrderLec.TabIndex = 3;
            this.checkBoxOrderLec.Text = "Order by degree";
            this.checkBoxOrderLec.UseVisualStyleBackColor = true;
            // 
            // buttonAddLec
            // 
            this.buttonAddLec.Location = new System.Drawing.Point(24, 43);
            this.buttonAddLec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddLec.Name = "buttonAddLec";
            this.buttonAddLec.Size = new System.Drawing.Size(245, 110);
            this.buttonAddLec.TabIndex = 2;
            this.buttonAddLec.Text = "Add";
            this.buttonAddLec.UseVisualStyleBackColor = true;
            this.buttonAddLec.Click += new System.EventHandler(this.buttonAddLec_Click);
            // 
            // buttonDeleteLec
            // 
            this.buttonDeleteLec.Location = new System.Drawing.Point(24, 205);
            this.buttonDeleteLec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteLec.Name = "buttonDeleteLec";
            this.buttonDeleteLec.Size = new System.Drawing.Size(245, 110);
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
            this.dataGridViewLecturers.Location = new System.Drawing.Point(308, 3);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.RowHeadersWidth = 72;
            this.dataGridViewLecturers.RowTemplate.Height = 37;
            this.dataGridViewLecturers.Size = new System.Drawing.Size(1100, 796);
            this.dataGridViewLecturers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonExportExcelCourses);
            this.tabPage3.Controls.Add(this.buttonExportWordCourses);
            this.tabPage3.Controls.Add(this.checkBoxOrderCourses);
            this.tabPage3.Controls.Add(this.textBoxFilterCourses);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.buttonAddCourse);
            this.tabPage3.Controls.Add(this.buttonDeleteCourse);
            this.tabPage3.Controls.Add(this.dataGridViewCourses);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1411, 802);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Courses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonExportExcelCourses
            // 
            this.buttonExportExcelCourses.Location = new System.Drawing.Point(24, 660);
            this.buttonExportExcelCourses.Name = "buttonExportExcelCourses";
            this.buttonExportExcelCourses.Size = new System.Drawing.Size(245, 110);
            this.buttonExportExcelCourses.TabIndex = 7;
            this.buttonExportExcelCourses.Text = "Export to excel document";
            this.buttonExportExcelCourses.UseVisualStyleBackColor = true;
            this.buttonExportExcelCourses.Click += new System.EventHandler(this.buttonExportExcelCourses_Click);
            // 
            // buttonExportWordCourses
            // 
            this.buttonExportWordCourses.Location = new System.Drawing.Point(24, 496);
            this.buttonExportWordCourses.Name = "buttonExportWordCourses";
            this.buttonExportWordCourses.Size = new System.Drawing.Size(245, 110);
            this.buttonExportWordCourses.TabIndex = 6;
            this.buttonExportWordCourses.Text = "Export to word document";
            this.buttonExportWordCourses.UseVisualStyleBackColor = true;
            this.buttonExportWordCourses.Click += new System.EventHandler(this.buttonExportWordCourses_Click);
            // 
            // checkBoxOrderCourses
            // 
            this.checkBoxOrderCourses.AutoSize = true;
            this.checkBoxOrderCourses.Location = new System.Drawing.Point(24, 427);
            this.checkBoxOrderCourses.Name = "checkBoxOrderCourses";
            this.checkBoxOrderCourses.Size = new System.Drawing.Size(274, 34);
            this.checkBoxOrderCourses.TabIndex = 5;
            this.checkBoxOrderCourses.Text = "Order by price after taxes";
            this.checkBoxOrderCourses.UseVisualStyleBackColor = true;
            // 
            // textBoxFilterCourses
            // 
            this.textBoxFilterCourses.Location = new System.Drawing.Point(83, 371);
            this.textBoxFilterCourses.Name = "textBoxFilterCourses";
            this.textBoxFilterCourses.Size = new System.Drawing.Size(186, 35);
            this.textBoxFilterCourses.TabIndex = 4;
            this.textBoxFilterCourses.TextChanged += new System.EventHandler(this.textBoxFilterCourses_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(24, 43);
            this.buttonAddCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(245, 110);
            this.buttonAddCourse.TabIndex = 2;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Location = new System.Drawing.Point(24, 205);
            this.buttonDeleteCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(245, 110);
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
            this.dataGridViewCourses.Location = new System.Drawing.Point(308, 3);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 72;
            this.dataGridViewCourses.RowTemplate.Height = 37;
            this.dataGridViewCourses.Size = new System.Drawing.Size(1100, 796);
            this.dataGridViewCourses.TabIndex = 0;
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.Organisations);
            this.Name = "FormDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDB";
            this.Organisations.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganisation)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button buttonAddOrg;
        private System.Windows.Forms.Button buttonAddLec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterOrgName;
        private System.Windows.Forms.Button buttonExportExcelOrg;
        private System.Windows.Forms.Button buttonExportWordOrg;
        private System.Windows.Forms.CheckBox checkBoxOrderOrg;
        private System.Windows.Forms.CheckBox checkBoxOrderLec;
        private System.Windows.Forms.Button buttonExportExcelLec;
        private System.Windows.Forms.Button buttonExportWordLec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilterLecturers;
        private System.Windows.Forms.Button buttonExportExcelCourses;
        private System.Windows.Forms.Button buttonExportWordCourses;
        private System.Windows.Forms.CheckBox checkBoxOrderCourses;
        private System.Windows.Forms.TextBox textBoxFilterCourses;
        private System.Windows.Forms.Label label3;
    }
}