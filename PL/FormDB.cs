using Data;
using Data.Entities;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Document oDoc = new Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }


        public void Export_To_Excel(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
        }

        private void buttonAddLec_Click(object sender, EventArgs e)
        {
            var addLecturerForm = new AddLecForm();
            addLecturerForm.ShowDialog();
        }

        private void buttonExportWordOrg_Click(object sender, EventArgs e) => Export_Data_To_Word(organisations, "organisations.docx");
        private void buttonExportExcelOrg_Click(object sender, EventArgs e) => Export_To_Excel(organisations, "organisations.xls");
        private void buttonExportWordLec_Click(object sender, EventArgs e) => Export_Data_To_Word(lecturers, "lecturers.docx");
        private void buttonExportExcelLec_Click(object sender, EventArgs e) => Export_To_Excel(lecturers, "lecturers.xls");
        private void buttonExportWordCourses_Click(object sender, EventArgs e) => Export_Data_To_Word(courses, "courses.docx");
        private void buttonExportExcelCourses_Click(object sender, EventArgs e) => Export_To_Excel(courses, "courses.xls");

        private void textBoxFilterOrgName_TextChanged(object sender, EventArgs e)
        {
            var filteredList = context.Organisations.Where(x => x.CourseName.Contains(textBoxFilterOrgName.Text));
            organisations.DataSource = checkBoxOrderOrg.Checked ? filteredList.OrderBy(x => x.CourseName).ToList() : filteredList.ToList();
        }

        private void textBoxFilterLecturers_TextChanged(object sender, EventArgs e)
        {
            var filteredList = context.Lecturers.Where(x => (x.Name + " " + x.Surname).Contains(textBoxFilterLecturers.Text));
            lecturers.DataSource = checkBoxOrderLec.Checked ? filteredList.OrderBy(x => x.Degree).ToList() : filteredList.ToList();
        }

        private void textBoxFilterCourses_TextChanged(object sender, EventArgs e)
        {
            var filteredList = context.Courses.Where(x => x.CourseName.Contains(textBoxFilterCourses.Text)).Select(x => new
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
            });
            courses.DataSource = checkBoxOrderCourses.Checked ? filteredList.OrderBy(x => x.TaxPrice).ToList() : filteredList.ToList();
        }

        private void buttonAddOrg_Click(object sender, EventArgs e)
        {
            var addOrganisationForm = new AddOrgForm();
            addOrganisationForm.ShowDialog();
        }
    }
}