using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Data;
using Data.Entities;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class AddLecForm : Form
    {
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
