using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Data;
using Data.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class AddOrgForm : Form
    {
        CoursesContext context;

        public AddOrgForm()
        {
            InitializeComponent();

            context = new CoursesContext();
            coursesLB.Items.Clear();

            foreach (var course in context.Courses.ToList())
            {
                coursesLB.Items.Add(course.CourseName);
            }
        }

        private void buttonOrgAdd_Click(object sender, EventArgs e)
        {
            if (coursesLB.SelectedIndex == -1 || adressTB.Text == String.Empty || numberTB.Text == String.Empty || emailTB.Text == String.Empty)
            {
                MessageBox.Show(this, "Incorrect data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var orgToAdd = new Organisation { CourseName = coursesLB.SelectedItem.ToString(), Adress = adressTB.Text, Email = emailTB.Text, Number = numberTB.Text };
            context.Organisations.Add(orgToAdd);
            context.SaveChanges();
            this.Close();
        }
    }
}
