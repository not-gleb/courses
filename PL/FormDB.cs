using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class FormDB : Form
    {
        private CoursesContext context;
        private DataGridView organisations;
        private DataGridView lecturers;
        private DataGridView courses;

        public FormDB()
        {
            context = new CoursesContext();
            InitializeComponent();
            organisations = dataGridViewOrganisation;
            lecturers = dataGridViewLecturers;
            courses = dataGridViewCourses;

            AttachCourses();
            AttachLecturers();
            AttachOrganisations();
        }

        public void AttachOrganisations() => organisations.DataSource = context.Organisations.ToList();
        public void AttachLecturers() => lecturers.DataSource = context.Lecturers.ToList();
        public void AttachCourses() => courses.DataSource = context.Courses.Select(x => new
        {
            ID = x.ID,
            Organisation = x.Organisation.CourseName,
            Lecturer = x.Lecturer.Name + " " + x.Lecturer.Surname,
            CourseName = x.CourseName,
            CourseType = x.CourseType,
            LenghtDays = x.LengthDays,
            Places = x.Places,
            Price = x.Price,
            TaxPrice = x.TaxPrice
        }).ToList();

        private void buttonDeleteOrg_Click(object sender, EventArgs e)
        {
            if (organisations.SelectedRows.Count > 0)
            {
                var selectedRowIndex = organisations.SelectedCells[0].RowIndex;
                var selectedRow = organisations.Rows[selectedRowIndex];
                int orgID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                DeleteOrgByID(orgID);
            }
        }

        public void DeleteOrgByID(int id)
        {
            var organisationToDelete = new Organisation { ID = id };

            try
            {
                using (var context = new CoursesContext())
                {
                    context.Organisations.Remove(organisationToDelete);
                    context.SaveChanges();
                    AttachOrganisations();
                    organisations.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteLec_Click(object sender, EventArgs e)
        {
            if (lecturers.SelectedRows.Count > 0)
            {
                var selectedRowIndex = lecturers.SelectedCells[0].RowIndex;
                var selectedRow = lecturers.Rows[selectedRowIndex];
                int lecID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                DeleteLecByID(lecID);
            }
        }

        public void DeleteLecByID(int id)
        {
            var LecturerToDelete = new Lecturer { ID = id };

            try
            {
                using (var context = new CoursesContext())
                {
                    context.Lecturers.Remove(LecturerToDelete);
                    context.SaveChanges();
                    AttachLecturers();
                    courses.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            if (courses.SelectedRows.Count > 0)
            {
                var selectedRowIndex = courses.SelectedCells[0].RowIndex;
                var selectedRow = courses.Rows[selectedRowIndex];
                int courseID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                DeleteCourseByID(courseID);
            }
        }

        public void DeleteCourseByID(int id)
        {
            var courseToDelete = new Course { ID = id };

            try
            {
                using (var context = new CoursesContext())
                {
                    context.Courses.Remove(courseToDelete);
                    context.SaveChanges();
                    AttachCourses();
                    courses.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddLec_Click(object sender, EventArgs e)
        {
            var addLecturerForm = new AddLecForm();
            addLecturerForm.ShowDialog();
        }
    }
}
