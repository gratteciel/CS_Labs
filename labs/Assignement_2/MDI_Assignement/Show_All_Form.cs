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
    public partial class Show_All_Form : Form
    {
        private HospitalDataContext dataHospital = new HospitalDataContext();

        public Show_All_Form()
        {
            InitializeComponent();
        }

        private void DataGridView_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView_Data.Rows[e.RowIndex];

            }
        }

        private void Choice_label_Click(object sender, EventArgs e)
        {

        }

        private void Radio_Doctors_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Doctors.Checked)
            {
                var query = from d in dataHospital.Doctors select d;

                DataGridView_Data.DataSource = query.ToList();

            }
        }

        private void Radio_Patient_CheckedChanged(object sender, EventArgs e)
        {


            if (Radio_Patient.Checked)
            {
                var query = from p in dataHospital.Patient select p;

                DataGridView_Data.DataSource = query.ToList();

            }
        }

        private void Radio_Appointments_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Appointments.Checked)
            {
                var query = from a in dataHospital.Appointments select a;

                DataGridView_Data.DataSource = query.ToList();

            }
        }
    }
}
