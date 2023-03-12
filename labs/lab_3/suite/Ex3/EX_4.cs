using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ex3
{
    public partial class EX_4 : Form
    {
        private List<Customer> customers = new List<Customer>();
        public EX_4()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void label_Name_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void address_label_Click(object sender, EventArgs e)
        {
            
        }

        private void address_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tel_label_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("Name field cannot be empty.");
                return false;
            }
            if (string.IsNullOrEmpty(address_text.Text))
            {
                MessageBox.Show("Address field cannot be empty.");
                return false;
            }
            if (telText.Text.Length != 10)
            {
                MessageBox.Show("Invalid phone number. It must be 10 digits.");
                return false;
            }
            if (dateTime.Value > DateTime.Now)
            {
                MessageBox.Show("Registration date must be less than or equal to the current date.");
                return false;
            }

            return true;
        }
        private void add_button_Click(object sender, EventArgs e)
        {  if (!IsFormValid())
            {
                return;
            }

            Customer newCustomer = new Customer();
            newCustomer.Name = textBox_name.Text;
            newCustomer.Address = address_text.Text;
            newCustomer.PhoneNumber = telText.Text;
            newCustomer.RegistrationDate = dateTime.Value;

            if (MessageBox.Show("Do you want to add this customer to the list?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                customers.Add(newCustomer);
                ClearForm();
                MessageBox.Show("Customer added successfully!");
                DisplayCustomers();
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the list of customers?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                customers.Clear();
                MessageBox.Show("List of customers cleared successfully!");
            }
        }
        private void ClearForm()
        {
            textBox_name.Text = "";
            address_text.Text = "";
            telText.Text = "";
            dateTime.Value = DateTime.Now;
        }
        
        private void DisplayCustomers()
        {
            maskedTextBox1.Clear();
            int count = 0;
            foreach (Customer customer in customers)
            {
                count++;
                maskedTextBox1.Text += $"{count}. Name: {customer.Name} Address: {customer.Address} Phone: {customer.PhoneNumber} Date: {customer.RegistrationDate.ToString("MM/dd/yyyy")}" + Environment.NewLine;
            }
            maskedTextBox2.Text = count.ToString();
        }

        private void EX_4_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}