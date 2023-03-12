using System;
using System.Windows.Forms;

namespace MDI_Assignement
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }
        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        //management method ; not useful 
        private void managementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Linked to the doctor management form 
        Doctor_Management_Form ManagementFormDoctor;
        private void doctorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManagementFormDoctor == null)
            {
                ManagementFormDoctor = new Doctor_Management_Form(); //new instance 
                ManagementFormDoctor.MdiParent = this;
                ManagementFormDoctor.Show();

                ManagementFormDoctor.FormClosed += ManagementFormDoctor_FormClosed;
            }
            else
                ManagementFormDoctor.Activate();

        }
        private void ManagementFormDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagementFormDoctor = null;
        }


        // Linked to the patient management form 
        Patient_Management_Form ManagementFormPatient;
        private void patientManagemementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManagementFormPatient == null)
            {
                ManagementFormPatient = new Patient_Management_Form();
                ManagementFormPatient.MdiParent = this;
                ManagementFormPatient.Show();

                ManagementFormPatient.FormClosed += ManagementFormPatient_FormClosed;
            }
            else
                ManagementFormPatient.Activate();

        }
        private void ManagementFormPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagementFormPatient = null;
        }


        // Linked to the Appointment management form 
        Appointment_Management_Form ManagementFormAppointment;

        private void appointmentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManagementFormAppointment == null)
            {
                ManagementFormAppointment = new Appointment_Management_Form();
                ManagementFormAppointment.MdiParent = this;
                ManagementFormAppointment.Show();

                ManagementFormAppointment.FormClosed += ManagementFormAppointment_FormClosed;
            }
            else
                ManagementFormAppointment.Activate();

        }
        private void ManagementFormAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagementFormAppointment = null;
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e) //useless method 
        {

        }


        // Linked to the Show all form
        Show_All_Form ShowAllForm;
        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ShowAllForm == null)
            {
                ShowAllForm = new Show_All_Form();
                ShowAllForm.MdiParent= this;
                ShowAllForm.Show();
                ShowAllForm.FormClosed += ShowAllForm_FormClosed;
            }
            else
                ShowAllForm.Activate();

        }
        private void ShowAllForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowAllForm= null;
        }

        // Linked to the Search Appointnment form
        Search_Appointment_Form SearchAppointmentForm; 
        private void searchAppointmentByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SearchAppointmentForm == null)
            {
                SearchAppointmentForm= new Search_Appointment_Form();
                SearchAppointmentForm.MdiParent= this;
                SearchAppointmentForm.Show();
                SearchAppointmentForm.FormClosed += SearchAppointmentForm_FormClosed; 

            }
            else 
                SearchAppointmentForm.Activate();

        }
        private void SearchAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearchAppointmentForm = null; 
        }

        Show_Patients_Appointment_Form ShowPatientsAppointmentForm;
        private void showAPatientsAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ShowPatientsAppointmentForm == null)
            {
                ShowPatientsAppointmentForm = new Show_Patients_Appointment_Form();
                ShowPatientsAppointmentForm.MdiParent= this;
                ShowPatientsAppointmentForm.Show();

                ShowPatientsAppointmentForm.FormClosed += ShowPatientsAppointmentForm_FormClosed;

            }
            else 
                ShowPatientsAppointmentForm.Activate();

        }
        private void ShowPatientsAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPatientsAppointmentForm= null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit the application","Exit Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
