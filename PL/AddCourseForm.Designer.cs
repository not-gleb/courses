
namespace PL
{
    partial class AddCourseForm
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
            this.lecturersLB = new System.Windows.Forms.ListBox();
            this.organisationsLB = new System.Windows.Forms.ListBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.placesNumeric = new System.Windows.Forms.NumericUpDown();
            this.durationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.placesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // lecturersLB
            // 
            this.lecturersLB.FormattingEnabled = true;
            this.lecturersLB.ItemHeight = 19;
            this.lecturersLB.Location = new System.Drawing.Point(36, 42);
            this.lecturersLB.Name = "lecturersLB";
            this.lecturersLB.Size = new System.Drawing.Size(174, 118);
            this.lecturersLB.TabIndex = 0;
            // 
            // organisationsLB
            // 
            this.organisationsLB.FormattingEnabled = true;
            this.organisationsLB.ItemHeight = 19;
            this.organisationsLB.Location = new System.Drawing.Point(36, 187);
            this.organisationsLB.Name = "organisationsLB";
            this.organisationsLB.Size = new System.Drawing.Size(174, 156);
            this.organisationsLB.TabIndex = 1;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(36, 361);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(465, 77);
            this.buttonAddCourse.TabIndex = 2;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(216, 42);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(120, 26);
            this.nameTB.TabIndex = 3;
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(381, 42);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(120, 26);
            this.typeTB.TabIndex = 4;
            // 
            // placesNumeric
            // 
            this.placesNumeric.Location = new System.Drawing.Point(216, 187);
            this.placesNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.placesNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.placesNumeric.Name = "placesNumeric";
            this.placesNumeric.Size = new System.Drawing.Size(120, 26);
            this.placesNumeric.TabIndex = 5;
            this.placesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // durationNumeric
            // 
            this.durationNumeric.Location = new System.Drawing.Point(381, 187);
            this.durationNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.durationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationNumeric.Name = "durationNumeric";
            this.durationNumeric.Size = new System.Drawing.Size(120, 26);
            this.durationNumeric.TabIndex = 6;
            this.durationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lector:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Organisation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Places:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Durations:";
            // 
            // priceNumeric
            // 
            this.priceNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceNumeric.Location = new System.Drawing.Point(216, 254);
            this.priceNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(120, 26);
            this.priceNumeric.TabIndex = 13;
            this.priceNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price:";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationNumeric);
            this.Controls.Add(this.placesNumeric);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.organisationsLB);
            this.Controls.Add(this.lecturersLB);
            this.MaximizeBox = false;
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add course";
            ((System.ComponentModel.ISupportInitialize)(this.placesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lecturersLB;
        private System.Windows.Forms.ListBox organisationsLB;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.NumericUpDown placesNumeric;
        private System.Windows.Forms.NumericUpDown durationNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.Label label7;
    }
}