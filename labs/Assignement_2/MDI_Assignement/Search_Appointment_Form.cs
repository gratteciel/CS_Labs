using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Assignement
{
    public partial class Search_Appointment_Form : Form
    {
        private HospitalDataContext data = new HospitalDataContext();

        public Search_Appointment_Form()
        {
            InitializeComponent();
        }

        private void Search_Appointment_Form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimeUser_ValueChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //get the date the user inputed
            DateTime userDate = dateTimeUser.Value.Date;

            var appointments = from d in data.Appointments
                               where d.AppointmentDate == userDate
                               select new { d.AppointmentCode, d.AppointmentDate, d.AppointmentTime, d.DoctorId, d.PatientId };
            
            dataGridView1.DataSource = appointments.ToList();


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            // clear all the data
            doctorName.Text = "";
            doctorSpeciality.Text = "";
            patientBirthDate.Text = "";
            patientName.Text = "";
        }

        private void doctorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorSpeciality_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientBirthDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // get the selected appointment's properties
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int doctorID = (int)selectedRow.Cells[3].Value;
                int patientID = (int)(selectedRow.Cells[4].Value);

                var query = from d in data.Doctors
                            where d.DoctorId == doctorID
                            select d;
                var result = query.FirstOrDefault();

                //display the doctor's info data
                if (result != null)
                {
                    doctorName.Text = result.DoctorName;
                    doctorSpeciality.Text = result.DoctorSpecialism.ToString();
                }
                else
                    MessageBox.Show("Error");

                var query2 = from d in data.Patient
                             where d.PatientId == patientID
                             select d;
                var result2 = query2.FirstOrDefault();

                //display the patient's info 
                if (result2 != null)
                {
                    patientName.Text = result2.PatientName;
                    patientBirthDate.Text = result2.BirthDate.ToString();
                }
                else
                    MessageBox.Show("Error");
            }
        }
    }
}
