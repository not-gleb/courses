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



    }
}
