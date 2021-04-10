using Data;
using Data.Entities;
using System;
using System.Windows.Forms;

namespace PL
{
    /// <summary>
    /// Form includes elements which allow you to add new lecture to database
    /// </summary>
    public partial class AddLecForm : Form
    {
        /// <summary>
        /// Initializes form
        /// </summary>
        public AddLecForm()
        {
            InitializeComponent();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == String.Empty || surnameTB.Text == String.Empty || sexLB.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Incorrect data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lecturerToAdd = new Lecturer { Name = nameTB.Text, Surname = surnameTB.Text, Sex = sexLB.SelectedItem.ToString(), Birthday = birthdayPicker.Value, Degree = Convert.ToInt32(degreeNumeric.Value) };

            try
            {
                using (CoursesContext context = new CoursesContext())
                {
                    context.Lecturers.Add(lecturerToAdd);
                    context.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
