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
    public partial class Appointment_Management_Form : Form
    {
        private HospitalDataContext data = new HospitalDataContext();
        public Appointment_Management_Form()
        {
            InitializeComponent();
        }

        private void Patient_Name_Label_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox_All_Enter(object sender, EventArgs e)
        {

        }

        private void Patient_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Patient_Code_Label_Click(object sender, EventArgs e)
        {

        }
        // We populate lists box :
        private void PopulatePatientListBox()
        {
            try
            {
                var query = from p in data.Patient select new { p.PatientId };
                foreach (var w in query)
                {
                    Console.WriteLine(w);
                    Patient_ComboBox.Items.Add(w.PatientId);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        
        private void PopulateDoctorListBox()
        {
            try
            {
                var query = from d in data.Doctors select new { d.DoctorId };
                foreach (var w in query)
                {
                    Console.WriteLine(w);
                    Doctor_ComboBox.Items.Add(w.DoctorId);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        //We call those methods for fill others fiels 

        private void PopulatePatientFields()
        {
            //We get the id selected for filling others fields 
            int selectedPatientID = int.Parse(Patient_ComboBox.SelectedItem.ToString());
            
            Console.WriteLine(selectedPatientID.ToString());
            try
            {
                var query = from p in data.Patient where p.PatientId == selectedPatientID select new { p.PatientName, p.PatientGender };
                foreach (var w in query)
                {
                    Patient_Name_Text.Text = w.PatientName;
                    if (w.PatientGender == 'M')
                    {
                        M_Radio_Button.Checked = true;

                    }
                    else if (w.PatientGender == 'F')
                    {
                        F_radio_button.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Got a problem for the gender of the patient with the name :" + w.PatientName);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void PopulateDoctorFields()
        {
            //We get the id selected for filling others fields 
            int selectedDoctorID = int.Parse(Doctor_ComboBox.SelectedItem.ToString());
            try
            {
                var query = from d in data.Doctors where d.DoctorId == selectedDoctorID select new { d.DoctorName, d.DoctorSpecialism };
                foreach (var w in query)
                {
                    Doctor_Name_Text.Text = w.DoctorName;
                    Doctor_Speciality_Text.Text = w.DoctorSpecialism;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void Patient_Code_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            PopulatePatientFields();
        }

        private void Patient_Name_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Gender_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void F_radio_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void M_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Appointment_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Appointment_Date_Label_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Appointment_Time_Label_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Doctor_Code_Label_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Code_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDoctorFields();
        }

        private void Doctor_Name_Label_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Name_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_Speciality_Label_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Speciality_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Appointments appointment = new Appointments
            {
                PatientId = int.Parse(Patient_ComboBox.SelectedItem.ToString()),
                DoctorId = int.Parse(Doctor_ComboBox.SelectedItem.ToString()),
                AppointmentDate = AppointmentDate.Value,
                AppointmentTime = AppointmentTime.Value - DateTime.Today,
            };
            var lastCode = (from a1 in data.Appointments
                            orderby a1.AppointmentCode descending
                            select a1.AppointmentCode).FirstOrDefault();
            appointment.AppointmentCode = lastCode + 1;
            if (AppointmentDate.Value < DateTime.Today ||
                    AppointmentTime.Value.TimeOfDay < TimeSpan.FromHours(9) ||
                            AppointmentTime.Value.TimeOfDay >= TimeSpan.FromHours(20))
            {
                // The appointment is invalid
                MessageBox.Show("The appointment is invalid, modify the date or the time please !");
            }
            else
            {

                data.Appointments.InsertOnSubmit(appointment);
                try
                {
                    data.SubmitChanges();
                    MessageBox.Show("Appointment added ! ");
                    ClearFields();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Error");

                }
            }


        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            Patient_ComboBox.SelectedIndex= 0;
            Doctor_ComboBox.SelectedIndex = 0;
            Patient_Name_Text.Text = string.Empty;
            M_Radio_Button.Checked = false;
            F_radio_button.Checked = false;
            Doctor_Name_Text.Text= string.Empty;
            Doctor_Speciality_Text.Text= string.Empty;

            //Need to clear appointments 
            AppointmentTime.Value= DateTime.Now;
            AppointmentDate.Value= DateTime.Now;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the form", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Appointment_Management_Form_Load(object sender, EventArgs e)
        {
            //We load ListBox with ID
            PopulatePatientListBox();
            PopulateDoctorListBox();
            AppointmentTime.Format = DateTimePickerFormat.Custom; // set the format to custom
            AppointmentTime.CustomFormat = "HH:mm"; // set the custom format to "HH:mm"
        }

        private void Patient_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePatientFields();

        }

        private void Doctor_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDoctorFields();
        }
    }
}
