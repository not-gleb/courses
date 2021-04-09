using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //var ctx = new CoursesContext();
            //dataGridView1.DataSource = ctx.Courses.ToList();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            using (var ctx = new CoursesContext())
            {
                if (ctx.Users.Any(x => x.Username.ToUpper() == textBoxUsername.Text.ToUpper() && x.Password == textBoxPassword.Text))
                    MessageBox.Show("Logged in");
                else
                    MessageBox.Show($"Wrong password {textBoxUsername}");
            }
        }
    }
}
