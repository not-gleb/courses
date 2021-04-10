﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Entities;

namespace PL
{
    public partial class Form1 : Form
    {
        private Panel currentPanel;
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
                {
                    MessageBox.Show("Logged in");
                    FormDB formDB = new FormDB();
                    this.Hide();
                    formDB.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show($"Wrong password {textBoxUsername.Text}");
            }
        }

        private void buttonWelcomeMenuLogIn_Click(object sender, EventArgs e)
        {
            currentPanel = panelLogIn;
            currentPanel.Visible = true;
        }

        private void buttonWelcomeMenuRegister_Click(object sender, EventArgs e)
        {
            currentPanel = panelRegister;
            currentPanel.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e) => CurrentVisibleFalse();

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            string username = textBoxRegUsername.Text;
            string password = textBoxRegPW.Text;
            
            string confirmation = textBoxRegPWConfirm.Text;

            if (username == String.Empty || password == String.Empty || confirmation == String.Empty)
            {
                MessageBox.Show(this, "Fields should not be emplty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmation)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            User user = new User
            {
                Password = password,
                Username = username,
                UserType = 1
            };
            using (var ctx = new CoursesContext())
            {
                if (ctx.Users.Any(x => x.Username.ToUpper() == username.ToUpper()))
                {
                    MessageBox.Show("Username already exists");
                    return;
                }
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
            MessageBox.Show("Registered successfully");
        }

        public void CurrentVisibleFalse() => currentPanel.Visible = false;

        private void buttonBack2_Click(object sender, EventArgs e) => CurrentVisibleFalse();
    }
}
