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

        private void Patient_Code_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from p in data.Patient select p.PatientId;
                foreach (var w in query)
                {
                    Console.WriteLine(w);
                    Patient_Code_ListBox.Items.Add(w.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


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

        }

        private void New_Button_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Management_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
