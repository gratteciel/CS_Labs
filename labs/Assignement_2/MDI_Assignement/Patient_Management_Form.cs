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
    public partial class Patient_Management_Form : Form
    {
        private HospitalDataContext data = new HospitalDataContext();
        public Patient_Management_Form()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) //gender box 
        {

        }

        private void GroupBox_All_Enter(object sender, EventArgs e)
        {

        }

        private void Code_Label_Click(object sender, EventArgs e)
        {

        }

        private void Code_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Label_Click(object sender, EventArgs e)
        {

        }

        private void Name_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Birth_Date_label_Click(object sender, EventArgs e)
        {

        }
        private void BirthDate_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Address_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_Label_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Label_Click(object sender, EventArgs e)
        {

        }

        private void F_radio_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void M_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            Code_Text.Clear();
            Name_Text.Clear();
            Address_box.Clear();
            BirthDate_Date.Format = DateTimePickerFormat.Custom;
            M_Radio_Button.Checked = false;
            F_radio_button.Checked = false;

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (Code_Text.Text != "")
            {
                SearchByID();
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }
        }
        private void SearchByID()
        {
            if (int.TryParse(Code_Text.Text, out int id))
            {
                id = int.Parse(Code_Text.Text); // we store the value
                var query = from p in data.Patient where p.PatientId == id select p;
                var result = query.FirstOrDefault();
                if (result != null)
                {
                    Name_Text.Text = result.PatientName;
                    Address_box.Text = result.PatientAddress;
                    BirthDate_Date.Text = result.BirthDate.ToString();
                    if(result.PatientGender.ToString() == "M")
                    {
                        M_Radio_Button.Checked ^= true;

                    }
                    else
                        F_radio_button.Checked ^= true;

                }
                else
                    MessageBox.Show("No Result");

            }
            else
            {
                //The input is not a valid integer
                MessageBox.Show("Please enter a valid integer value.");

            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Code_Text.Text != "")
            {
                if (Code_Text.Text != "" )
                {
                    if (int.TryParse(Code_Text.Text, out int id))
                    {
                        AddNewPatient(id);

                    }
                    else
                    {
                        //The input is not a valid integer or phone number
                        MessageBox.Show("The Code provided is not an integer or/and  the phone number isn't valid (must be 10 digits) ");

                    }

                }
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }
        }
        private void AddNewPatient(int id)
        {
            Patient patient = new Patient
            {
                PatientId = id,
                PatientName = Name_Text.Text,
                PatientAddress = Address_box.Text,
                BirthDate = BirthDate_Date.Value
            };
            if(M_Radio_Button.Checked)
            {
                patient.PatientGender = 'M';
            }
            else if (F_radio_button.Checked)
            {
                patient.PatientGender = 'F';
            }
            else
            {
                MessageBox.Show("Not valid Gender !");
            }

            data.Patient.InsertOnSubmit(patient);
            try
            {
                data.SubmitChanges();
                MessageBox.Show("Patient added ! ");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("We can't add the new patient the id should already exists,we change the code value for being able to be in the table ");
                var lastId = (from p1 in data.Patient
                              orderby p1.PatientId descending
                              select p1.PatientId).FirstOrDefault();
                patient.PatientId = lastId + 1;
                data.Patient.InsertOnSubmit(patient);
                data.SubmitChanges();
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (Code_Text.Text != "")
            {
                if (Code_Text.Text != "" && Name_Text.Text != "") //Check if all the fields aren't empty 
                {
                    if (int.TryParse(Code_Text.Text, out int id))
                    {
                        EditPatient(id);

                    }
                    else
                    {
                        //The input is not a valid integer 
                        MessageBox.Show("The Code provided is not an integer");

                    }

                }
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }

        }
        private void EditPatient(int id) //method to edit the patient 
        {

            //We check if the id patient is in the table 
            bool exists = data.Patient.Where(p => p.PatientId == id).Any();
            if (exists)
            {
                var query = from p in data.Patient where p.PatientId == id select p;
                foreach (var d in query) //for editing the Patient 
                {
                    Patient patient = new Patient
                    {
                        PatientId = id,
                        PatientName = Name_Text.Text,
                        PatientAddress = Address_box.Text,
                        BirthDate = BirthDate_Date.Value
                    };
                    if (M_Radio_Button.Checked)
                    {
                        patient.PatientGender = 'M';
                    }
                    else if (F_radio_button.Checked)
                    {
                        patient.PatientGender = 'F';
                    }
                    else
                    {
                        MessageBox.Show("Not valid Gender !");
                    }
                }
                if (MessageBox.Show("Do you want to Edit the patient with the id :" + id, "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        data.SubmitChanges(); //Submit the change to the db 
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
            }
            else
            {
                MessageBox.Show("The patient is not in the table you can add a new one or find the good the id ");
            }

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (Code_Text.Text != "")
            {
                SearchByID();
                if (int.TryParse(Code_Text.Text, out int id))
                {
                    DeleteByID(id);

                }
                else
                {
                    //The input is not a valid integer 
                    MessageBox.Show("The Code provided is not an integer ");

                }
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }

        }
        private void DeleteByID(int id)
        {
            bool exists = data.Patient.Where(p => p.PatientId == id).Any();
            if (exists)
            {
                var query = from p in data.Patient where p.PatientId == id select p;
                foreach (var d in query) //for editing the doctor 
                {
                    data.Patient.DeleteOnSubmit(d);
                }
                if (MessageBox.Show("Do you want to delete the patient with the id :" + id, "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        data.SubmitChanges(); //Submit the change to the db 
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
            }
            else
            {
                MessageBox.Show("The patient is not in the table you can add a new one or find the good the id ");
            }


        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
