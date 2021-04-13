
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
            this.otherPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSendFeedback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msgTB = new System.Windows.Forms.TextBox();
            this.subjectTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOpenHelp = new System.Windows.Forms.Button();
            this.Organisations.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganisation)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.otherPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Organisations
            // 
            this.Organisations.Controls.Add(this.tabPage1);
            this.Organisations.Controls.Add(this.tabPage2);
            this.Organisations.Controls.Add(this.tabPage3);
            this.Organisations.Controls.Add(this.otherPage);
            this.Organisations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Organisations.Location = new System.Drawing.Point(0, 0);
            this.Organisations.Margin = new System.Windows.Forms.Padding(2);
            this.Organisations.Name = "Organisations";
            this.Organisations.SelectedIndex = 0;
            this.Organisations.Size = new System.Drawing.Size(946, 535);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(938, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Organisations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExportExcelOrg
            // 
            this.buttonExportExcelOrg.Location = new System.Drawing.Point(16, 418);
            this.buttonExportExcelOrg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportExcelOrg.Name = "buttonExportExcelOrg";
            this.buttonExportExcelOrg.Size = new System.Drawing.Size(163, 70);
            this.buttonExportExcelOrg.TabIndex = 7;
            this.buttonExportExcelOrg.Text = "Export to excel document";
            this.buttonExportExcelOrg.UseVisualStyleBackColor = true;
            this.buttonExportExcelOrg.Click += new System.EventHandler(this.buttonExportExcelOrg_Click);
            // 
            // buttonExportWordOrg
            // 
            this.buttonExportWordOrg.Location = new System.Drawing.Point(16, 314);
            this.buttonExportWordOrg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportWordOrg.Name = "buttonExportWordOrg";
            this.buttonExportWordOrg.Size = new System.Drawing.Size(163, 70);
            this.buttonExportWordOrg.TabIndex = 6;
            this.buttonExportWordOrg.Text = "Export to word document";
            this.buttonExportWordOrg.UseVisualStyleBackColor = true;
            this.buttonExportWordOrg.Click += new System.EventHandler(this.buttonExportWordOrg_Click);
            // 
            // checkBoxOrderOrg
            // 
            this.checkBoxOrderOrg.AutoSize = true;
            this.checkBoxOrderOrg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxOrderOrg.Location = new System.Drawing.Point(16, 270);
            this.checkBoxOrderOrg.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOrderOrg.Name = "checkBoxOrderOrg";
            this.checkBoxOrderOrg.Size = new System.Drawing.Size(66, 24);
            this.checkBoxOrderOrg.TabIndex = 5;
            this.checkBoxOrderOrg.Text = "Order";
            this.checkBoxOrderOrg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter";
            // 
            // textBoxFilterOrgName
            // 
            this.textBoxFilterOrgName.Location = new System.Drawing.Point(55, 235);
            this.textBoxFilterOrgName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFilterOrgName.Name = "textBoxFilterOrgName";
            this.textBoxFilterOrgName.Size = new System.Drawing.Size(125, 26);
            this.textBoxFilterOrgName.TabIndex = 3;
            this.textBoxFilterOrgName.TextChanged += new System.EventHandler(this.textBoxFilterOrgName_TextChanged);
            // 
            // buttonAddOrg
            // 
            this.buttonAddOrg.Location = new System.Drawing.Point(16, 27);
            this.buttonAddOrg.Name = "buttonAddOrg";
            this.buttonAddOrg.Size = new System.Drawing.Size(163, 70);
            this.buttonAddOrg.TabIndex = 2;
            this.buttonAddOrg.Text = "Add";
            this.buttonAddOrg.UseVisualStyleBackColor = true;
            this.buttonAddOrg.Click += new System.EventHandler(this.buttonAddOrg_Click);
            // 
            // buttonDeleteOrg
            // 
            this.buttonDeleteOrg.Location = new System.Drawing.Point(16, 130);
            this.buttonDeleteOrg.Name = "buttonDeleteOrg";
            this.buttonDeleteOrg.Size = new System.Drawing.Size(163, 70);
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
            this.dataGridViewOrganisation.Location = new System.Drawing.Point(203, 2);
            this.dataGridViewOrganisation.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrganisation.Name = "dataGridViewOrganisation";
            this.dataGridViewOrganisation.RowHeadersWidth = 72;
            this.dataGridViewOrganisation.RowTemplate.Height = 37;
            this.dataGridViewOrganisation.Size = new System.Drawing.Size(733, 499);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(938, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lecturers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExportExcelLec
            // 
            this.buttonExportExcelLec.Location = new System.Drawing.Point(16, 418);
            this.buttonExportExcelLec.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportExcelLec.Name = "buttonExportExcelLec";
            this.buttonExportExcelLec.Size = new System.Drawing.Size(163, 70);
            this.buttonExportExcelLec.TabIndex = 7;
            this.buttonExportExcelLec.Text = "Export to excel document";
            this.buttonExportExcelLec.UseVisualStyleBackColor = true;
            this.buttonExportExcelLec.Click += new System.EventHandler(this.buttonExportExcelLec_Click);
            // 
            // buttonExportWordLec
            // 
            this.buttonExportWordLec.Location = new System.Drawing.Point(16, 314);
            this.buttonExportWordLec.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportWordLec.Name = "buttonExportWordLec";
            this.buttonExportWordLec.Size = new System.Drawing.Size(163, 70);
            this.buttonExportWordLec.TabIndex = 6;
            this.buttonExportWordLec.Text = "Export to word document";
            this.buttonExportWordLec.UseVisualStyleBackColor = true;
            this.buttonExportWordLec.Click += new System.EventHandler(this.buttonExportWordLec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter";
            // 
            // textBoxFilterLecturers
            // 
            this.textBoxFilterLecturers.Location = new System.Drawing.Point(55, 235);
            this.textBoxFilterLecturers.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFilterLecturers.Name = "textBoxFilterLecturers";
            this.textBoxFilterLecturers.Size = new System.Drawing.Size(125, 26);
            this.textBoxFilterLecturers.TabIndex = 4;
            this.textBoxFilterLecturers.TextChanged += new System.EventHandler(this.textBoxFilterLecturers_TextChanged);
            // 
            // checkBoxOrderLec
            // 
            this.checkBoxOrderLec.AutoSize = true;
            this.checkBoxOrderLec.Location = new System.Drawing.Point(16, 270);
            this.checkBoxOrderLec.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOrderLec.Name = "checkBoxOrderLec";
            this.checkBoxOrderLec.Size = new System.Drawing.Size(137, 24);
            this.checkBoxOrderLec.TabIndex = 3;
            this.checkBoxOrderLec.Text = "Order by degree";
            this.checkBoxOrderLec.UseVisualStyleBackColor = true;
            // 
            // buttonAddLec
            // 
            this.buttonAddLec.Location = new System.Drawing.Point(16, 27);
            this.buttonAddLec.Name = "buttonAddLec";
            this.buttonAddLec.Size = new System.Drawing.Size(163, 70);
            this.buttonAddLec.TabIndex = 2;
            this.buttonAddLec.Text = "Add";
            this.buttonAddLec.UseVisualStyleBackColor = true;
            this.buttonAddLec.Click += new System.EventHandler(this.buttonAddLec_Click);
            // 
            // buttonDeleteLec
            // 
            this.buttonDeleteLec.Location = new System.Drawing.Point(16, 130);
            this.buttonDeleteLec.Name = "buttonDeleteLec";
            this.buttonDeleteLec.Size = new System.Drawing.Size(163, 70);
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
            this.dataGridViewLecturers.Location = new System.Drawing.Point(203, 2);
            this.dataGridViewLecturers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.RowHeadersWidth = 72;
            this.dataGridViewLecturers.RowTemplate.Height = 37;
            this.dataGridViewLecturers.Size = new System.Drawing.Size(733, 499);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(938, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Courses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonExportExcelCourses
            // 
            this.buttonExportExcelCourses.Location = new System.Drawing.Point(16, 418);
            this.buttonExportExcelCourses.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportExcelCourses.Name = "buttonExportExcelCourses";
            this.buttonExportExcelCourses.Size = new System.Drawing.Size(163, 70);
            this.buttonExportExcelCourses.TabIndex = 7;
            this.buttonExportExcelCourses.Text = "Export to excel document";
            this.buttonExportExcelCourses.UseVisualStyleBackColor = true;
            this.buttonExportExcelCourses.Click += new System.EventHandler(this.buttonExportExcelCourses_Click);
            // 
            // buttonExportWordCourses
            // 
            this.buttonExportWordCourses.Location = new System.Drawing.Point(16, 314);
            this.buttonExportWordCourses.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportWordCourses.Name = "buttonExportWordCourses";
            this.buttonExportWordCourses.Size = new System.Drawing.Size(163, 70);
            this.buttonExportWordCourses.TabIndex = 6;
            this.buttonExportWordCourses.Text = "Export to word document";
            this.buttonExportWordCourses.UseVisualStyleBackColor = true;
            this.buttonExportWordCourses.Click += new System.EventHandler(this.buttonExportWordCourses_Click);
            // 
            // checkBoxOrderCourses
            // 
            this.checkBoxOrderCourses.AutoSize = true;
            this.checkBoxOrderCourses.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxOrderCourses.Location = new System.Drawing.Point(16, 270);
            this.checkBoxOrderCourses.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOrderCourses.Name = "checkBoxOrderCourses";
            this.checkBoxOrderCourses.Size = new System.Drawing.Size(178, 21);
            this.checkBoxOrderCourses.TabIndex = 5;
            this.checkBoxOrderCourses.Text = "Order by price after taxes";
            this.checkBoxOrderCourses.UseVisualStyleBackColor = true;
            // 
            // textBoxFilterCourses
            // 
            this.textBoxFilterCourses.Location = new System.Drawing.Point(55, 235);
            this.textBoxFilterCourses.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFilterCourses.Name = "textBoxFilterCourses";
            this.textBoxFilterCourses.Size = new System.Drawing.Size(125, 26);
            this.textBoxFilterCourses.TabIndex = 4;
            this.textBoxFilterCourses.TextChanged += new System.EventHandler(this.textBoxFilterCourses_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(16, 27);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(163, 70);
            this.buttonAddCourse.TabIndex = 2;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Location = new System.Drawing.Point(16, 130);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(163, 70);
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
            this.dataGridViewCourses.Location = new System.Drawing.Point(203, 2);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 72;
            this.dataGridViewCourses.RowTemplate.Height = 37;
            this.dataGridViewCourses.Size = new System.Drawing.Size(733, 499);
            this.dataGridViewCourses.TabIndex = 0;
            // 
            // otherPage
            // 
            this.otherPage.Controls.Add(this.panel2);
            this.otherPage.Controls.Add(this.panel1);
            this.otherPage.Location = new System.Drawing.Point(4, 28);
            this.otherPage.Name = "otherPage";
            this.otherPage.Padding = new System.Windows.Forms.Padding(3);
            this.otherPage.Size = new System.Drawing.Size(938, 503);
            this.otherPage.TabIndex = 3;
            this.otherPage.Text = "Other";
            this.otherPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonOpenHelp);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(478, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 497);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(39, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 30);
            this.label10.TabIndex = 11;
            this.label10.Text = "Adress: Metrobudivska 5a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(39, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 30);
            this.label9.TabIndex = 10;
            this.label9.Text = "Phone: 380506212211";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email: our_email@gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(145, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 51);
            this.label8.TabIndex = 8;
            this.label8.Text = "Contacts";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSendFeedback);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.msgTB);
            this.panel1.Controls.Add(this.subjectTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 497);
            this.panel1.TabIndex = 0;
            // 
            // buttonSendFeedback
            // 
            this.buttonSendFeedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSendFeedback.Location = new System.Drawing.Point(0, 436);
            this.buttonSendFeedback.Name = "buttonSendFeedback";
            this.buttonSendFeedback.Size = new System.Drawing.Size(469, 61);
            this.buttonSendFeedback.TabIndex = 5;
            this.buttonSendFeedback.Text = "Send";
            this.buttonSendFeedback.UseVisualStyleBackColor = true;
            this.buttonSendFeedback.Click += new System.EventHandler(this.buttonSendFeedback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Message:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Subject:";
            // 
            // msgTB
            // 
            this.msgTB.Location = new System.Drawing.Point(5, 187);
            this.msgTB.Multiline = true;
            this.msgTB.Name = "msgTB";
            this.msgTB.Size = new System.Drawing.Size(320, 206);
            this.msgTB.TabIndex = 2;
            // 
            // subjectTB
            // 
            this.subjectTB.Location = new System.Drawing.Point(15, 108);
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(320, 26);
            this.subjectTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 51);
            this.label4.TabIndex = 0;
            this.label4.Text = "Send feedback";
            // 
            // buttonOpenHelp
            // 
            this.buttonOpenHelp.Location = new System.Drawing.Point(135, 452);
            this.buttonOpenHelp.Name = "buttonOpenHelp";
            this.buttonOpenHelp.Size = new System.Drawing.Size(187, 28);
            this.buttonOpenHelp.TabIndex = 12;
            this.buttonOpenHelp.Text = "Допомога";
            this.buttonOpenHelp.UseVisualStyleBackColor = true;
            this.buttonOpenHelp.Click += new System.EventHandler(this.buttonOpenHelp_Click);
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 535);
            this.Controls.Add(this.Organisations);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.otherPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TabPage otherPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSendFeedback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox msgTB;
        private System.Windows.Forms.TextBox subjectTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonOpenHelp;
    }
}