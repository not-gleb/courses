using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using System.Windows.Forms;

namespace PL
{

    /// <summary>
    /// Form includes elements which allow you to add new course to database
    /// </summary>
    public partial class AddCourseForm : Form
    {
        private CoursesContext context;

        /// <summary>
        /// Initializes form and its elements
        /// </summary>
        public AddCourseForm()
        {
            InitializeComponent();
            context = new CoursesContext();

            foreach (var lecturer in context.Lecturers.ToList())
            {
                lecturersLB.Items.Add(lecturer.Name);
            }

            foreach (var organisation in context.Organisations.ToList())
            {
                organisationsLB.Items.Add(organisation.CourseName);
            }
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if (lecturersLB.SelectedIndex == -1 || organisationsLB.SelectedIndex == -1 || nameTB.Text == String.Empty || typeTB.Text == String.Empty)
            {
                MessageBox.Show(this, "Incorrect data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lecturer = context.Lecturers.First(x => x.Name == lecturersLB.SelectedItem.ToString());
            var organisation = context.Organisations.First(x => x.CourseName == organisationsLB.SelectedItem.ToString());
            var courseToAdd = new Course { CourseName = nameTB.Text, CourseType = typeTB.Text, Places = Convert.ToInt32(placesNumeric.Value), LengthDays = Convert.ToInt32(durationNumeric.Value), Price = Convert.ToInt32(priceNumeric.Value), Lecturer = lecturer, Organisation = organisation, TaxPrice = Convert.ToInt32(priceNumeric.Value * 1.2m) };
            context.Courses.Add(courseToAdd);
            context.SaveChanges();
            this.Close();
        }

    }
}
