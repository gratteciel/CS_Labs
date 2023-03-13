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
    public partial class Doctor_Management_Form : Form
    {
        private HospitalDataContext data = new HospitalDataContext();
        public Doctor_Management_Form()
        {
            InitializeComponent();
        }

        private void Speciality_Label_Click(object sender, EventArgs e)
        {

        }

        private void Code_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Code_Label_Click(object sender, EventArgs e)
        {

        }

        private void Name_Label_Click(object sender, EventArgs e)
        {

        }

        private void Name_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tel_Label_Click(object sender, EventArgs e)
        {

        }

        private void Tel_TextMasked_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Hiring_date_label_Click(object sender, EventArgs e)
        {

        }

        private void HiringDate_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Speciality_ListBox_SelectedIndexChanged(object sender, EventArgs e)
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
            Tel_TextMasked.Clear();
            HiringDate_Date.Format = DateTimePickerFormat.Custom;
            Speciality_ListBox.SelectedIndex = 0;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if(Code_Text.Text != "")
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
                var query = from d in data.Doctors where d.DoctorId == id select d;
                var result = query.FirstOrDefault();
                if (result != null)
                {
                    Name_Text.Text = result.DoctorName;
                    Tel_TextMasked.Text = result.DoctorTel;
                    HiringDate_Date.Text = result.HiringDate.ToString();
                    Speciality_ListBox.Text = result.DoctorSpecialism.ToString();

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
                if (Code_Text.Text != "" && Name_Text.Text != "" && Tel_TextMasked.Text != "")
                {
                    if (int.TryParse(Code_Text.Text, out int id) && Tel_TextMasked.Text.Length == 10)
                    {
                        AddNewDoctor(id);

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
        private void AddNewDoctor(int id)
        {
            Doctors doctor = new Doctors
            {
                    DoctorId = id,
                    DoctorName = Name_Text.Text,
                    DoctorSpecialism= Speciality_ListBox.Text,
                    DoctorTel = Tel_TextMasked.Text,
                    HiringDate= HiringDate_Date.Value
            };
            data.Doctors.InsertOnSubmit(doctor);
            try
            {
                data.SubmitChanges();
                MessageBox.Show("Doctor added ! ");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("We can't add the new doctor the id should already exists,we change the code value for being able to be in the table ");
                var lastId = (from d1 in data.Doctors
                              orderby d1.DoctorId descending
                              select d1.DoctorId).FirstOrDefault();
                doctor.DoctorId = lastId+1;
                data.Doctors.InsertOnSubmit(doctor);
                data.SubmitChanges();

            }

        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (Code_Text.Text != "")
            {
                if (Code_Text.Text != "" && Name_Text.Text != "" && Tel_TextMasked.Text != "") //Check if all the fields aren't empty 
                {
                    if (int.TryParse(Code_Text.Text, out int id) && Tel_TextMasked.Text.Length == 10)
                    {
                        EditDoctor(id);

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
        private void EditDoctor(int id) //method to edit the doctor 
        {

            //We check if the id doctor is in the table 
            bool exists = data.Doctors.Where(d => d.DoctorId == id).Any();
            if (exists)
            {
                var query = from d in data.Doctors where d.DoctorId == id select d;
                foreach(var d in query) //for editing the doctor 
                {
                    d.DoctorId = id;
                    d.DoctorName = Name_Text.Text;
                    d.DoctorTel= Tel_TextMasked.Text;
                    d.DoctorSpecialism = Speciality_ListBox.Text;
                    d.HiringDate = HiringDate_Date.Value;
                }
                if (MessageBox.Show("Do you want to Edit the doctor with the id :" + id, "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                MessageBox.Show("The doctor is not in the table you can add a new one or find the good the id ");
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
            bool exists = data.Doctors.Where(d => d.DoctorId == id).Any();
            if (exists)
            {
                var query = from d in data.Doctors where d.DoctorId == id select d;
                foreach (var d in query) //for editing the doctor 
                {
                    data.Doctors.DeleteOnSubmit(d);
                }
                if (MessageBox.Show("Do you want to delete the doctor with the id :" + id, "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                MessageBox.Show("The doctor is not in the table you can add a new one or find the good the id ");
            }


        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GroupBox_All_Enter(object sender, EventArgs e)
        {

        }

        private void Doctor_Management_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
