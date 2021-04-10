
namespace PL
{
    partial class AddLecForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.sexLB = new System.Windows.Forms.ListBox();
            this.degreeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.degreeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(22, 62);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(120, 26);
            this.nameTB.TabIndex = 0;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(173, 62);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(120, 26);
            this.surnameTB.TabIndex = 1;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayPicker.Location = new System.Drawing.Point(173, 132);
            this.birthdayPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(129, 26);
            this.birthdayPicker.TabIndex = 2;
            this.birthdayPicker.Value = new System.DateTime(2021, 4, 10, 16, 38, 57, 0);
            // 
            // sexLB
            // 
            this.sexLB.FormattingEnabled = true;
            this.sexLB.ItemHeight = 19;
            this.sexLB.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.sexLB.Location = new System.Drawing.Point(22, 135);
            this.sexLB.Name = "sexLB";
            this.sexLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sexLB.Size = new System.Drawing.Size(120, 23);
            this.sexLB.TabIndex = 3;
            // 
            // degreeNumeric
            // 
            this.degreeNumeric.Location = new System.Drawing.Point(22, 201);
            this.degreeNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.degreeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.degreeNumeric.Name = "degreeNumeric";
            this.degreeNumeric.Size = new System.Drawing.Size(50, 26);
            this.degreeNumeric.TabIndex = 4;
            this.degreeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Degree:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birthday:";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(173, 198);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(129, 84);
            this.buttonAddCourse.TabIndex = 10;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // AddLecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 294);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degreeNumeric);
            this.Controls.Add(this.sexLB);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.nameTB);
            this.MaximizeBox = false;
            this.Name = "AddLecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add lecturer";
            ((System.ComponentModel.ISupportInitialize)(this.degreeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.ListBox sexLB;
        private System.Windows.Forms.NumericUpDown degreeNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddCourse;
    }
}