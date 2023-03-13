using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MDI_Assignement
{
    public partial class Show_Patients_Appointment_Form : Form
    {
        private HospitalDataContext data = new HospitalDataContext();

        public Show_Patients_Appointment_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // clear everything
            patientCode.Text = "";
            patientName.Text = "";
            patientBirthDate.Text = "";
            patientAddress.Text = "";
            appCode.Text = "";
            appDate.Text = "";
            appTime.Text = "";
            doctorCode.DataSource = null;
            dataGridView1.DataSource = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //check if not empty or if there is not just a whitespace
            if(!string.IsNullOrWhiteSpace(patientCode.Text))
            {
                int patientID = int.Parse(patientCode.Text);
                //select the appointments and the info we need
                var appointments = from d in data.Appointments
                                   where d.PatientId == patientID
                                   orderby d.AppointmentDate descending
                                   select new { d.AppointmentCode, d.AppointmentDate, d.AppointmentTime, d.DoctorId, d.PatientId };

                //list them as source of the dgv
                dataGridView1.DataSource = appointments.ToList();

                //get the info of the corresponding patient and display the values
                var patientInfo = from d in data.Patient
                                  where d.PatientId == patientID
                                  select d;
                var result = patientInfo.FirstOrDefault();

                patientName.Text = result.PatientName;
                patientBirthDate.Text = result.BirthDate.ToString();
                patientAddress.Text = result.PatientAddress;
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }
            
            
        }

        private void patientCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void patientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientBirthDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void patientAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void appCode_TextChanged(object sender, EventArgs e)
        {

        }

        // Linked to the doctor management form 
        Doctor_Management_Form ManagementFormDoctor;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //check if the cell that have been selected is the doctor code
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["DoctorId"].Index)
            {
                // Get the doctor code value from the clicked cell
                int doctorCode = (int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                var doc = from d in data.Doctors
                          where d.DoctorId == doctorCode
                          select d;
                var result = doc.FirstOrDefault();

                DateTime hiringD = result.HiringDate.GetValueOrDefault();


                if (ManagementFormDoctor == null)
                {
                    ManagementFormDoctor = new Doctor_Management_Form(result.DoctorId, result.DoctorName, result.DoctorTel, hiringD, result.DoctorSpecialism); //new instance 
                    ManagementFormDoctor.Show();

                    ManagementFormDoctor.FormClosed += ManagementFormDoctor_FormClosed;
                }
                else
                    ManagementFormDoctor.Activate();

            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ManagementFormDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagementFormDoctor = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check first if it's not empty
            if (e.RowIndex >= 0)
            {
                // get the properties of the appointment user selected
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int appointmentCode = (int)selectedRow.Cells[0].Value;
                DateTime appointmentDate = (DateTime)(selectedRow.Cells[1].Value);
                TimeSpan appointmentTime = (TimeSpan)(selectedRow.Cells[2].Value);

                //this is for the combo box
                int doctorId = (int)selectedRow.Cells[3].Value;
                doctorCode.ValueMember = "DoctorId";
                doctorCode.DisplayMember = "DoctorId";


                var docs = from d in data.Doctors
                           select d;

                //again for the combo box, which need to contain all the doctor's number and have the right one selected
                doctorCode.DataSource = docs.ToList();
                doctorCode.SelectedValue = doctorId;

                appCode.Text = appointmentCode.ToString();
                appDate.Text = appointmentDate.ToString();
                appTime.Text = appointmentTime.ToString();
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Show_Patients_Appointment_Form_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //test if appointment has been selected
            if (string.IsNullOrWhiteSpace(appCode.Text))
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            //get the updated value
            int appointmentCode = int.Parse(appCode.Text);
            DateTime appointmentDate = DateTime.Parse(appDate.Text);
            TimeSpan appointmentTime = TimeSpan.Parse(appTime.Text);
            int doctorId = (int)doctorCode.SelectedValue;

            //we create an appointment that will update the one in the db
            var appointment = data.Appointments.FirstOrDefault(a => a.AppointmentCode == appointmentCode);

            //submit changes
            if (appointment != null)
            {
                appointment.AppointmentDate = appointmentDate;
                appointment.AppointmentTime = appointmentTime;
                appointment.DoctorId = doctorId;

                data.SubmitChanges();

                MessageBox.Show("Changes saved successfully.");

                //update the data grid view, we can just take the initial code
                int patientID = int.Parse(patientCode.Text);

                var appointments = from d in data.Appointments
                                   where d.PatientId == patientID
                                   orderby d.AppointmentDate descending
                                   select new { d.AppointmentCode, d.AppointmentDate, d.AppointmentTime, d.DoctorId, d.PatientId };

                dataGridView1.DataSource = appointments.ToList();

                var patientInfo = from d in data.Patient
                                  where d.PatientId == patientID
                                  select d;
                var result = patientInfo.FirstOrDefault();

                patientName.Text = result.PatientName;
                patientBirthDate.Text = result.BirthDate.ToString();
                patientAddress.Text = result.PatientAddress;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // get the appointment to delete 
            int appointmentCode = int.Parse(appCode.Text);

            // confirm the deletion
            DialogResult result = MessageBox.Show("Do you really want to delete this appointment ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //delete the appointment
                var appointment = data.Appointments.Where(a => a.AppointmentCode == appointmentCode).FirstOrDefault();
                if (appointment != null)
                {
                    data.Appointments.DeleteOnSubmit(appointment);
                    data.SubmitChanges();

                    //update the data grid view, we can just take the initial code
                    int patientID = int.Parse(patientCode.Text);
                    var appointments = from d in data.Appointments
                                       where d.PatientId == patientID
                                       orderby d.AppointmentDate descending
                                       select new { d.AppointmentCode, d.AppointmentDate, d.AppointmentTime, d.DoctorId, d.PatientId };
                    dataGridView1.DataSource = appointments.ToList();

                    MessageBox.Show("Appointment deleted successfully.");
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
