using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {


        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        Consultation ConsultationForm;
        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ConsultationForm == null)
            {
                ConsultationForm = new Consultation();
                ConsultationForm.MdiParent = this;
                ConsultationForm.Show();
                ConsultationForm.FormClosed += ConsultationForm_FormClosed;
            }

            else {
                ConsultationForm.Activate();
            }

        }

        private void ConsultationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConsultationForm = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Student form 
        Students_Management_Form StudentManagementForm;
        private void studentsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StudentManagementForm == null)
            {
                StudentManagementForm = new Students_Management_Form();
                StudentManagementForm.MdiParent = this; // Set the parent form to this form
                StudentManagementForm.Show();
                StudentManagementForm.FormClosed += StudentManagementForm_FormClosed;
            }
            else
            {
                StudentManagementForm.Activate();
            }
        }

        private void StudentManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentManagementForm = null;

        }


        //Grade Management
        Grades_Management_Form GradesManagementForm;
        private void gradesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(GradesManagementForm == null)
            {
                GradesManagementForm = new Grades_Management_Form();
                GradesManagementForm.MdiParent = this;
                GradesManagementForm.Show();
                GradesManagementForm.FormClosed += GradesManagementForm_FormClosed;

            }
            else
            {
                GradesManagementForm.Activate();
            }

        }

        private void GradesManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GradesManagementForm = null;
        }
    }
}
