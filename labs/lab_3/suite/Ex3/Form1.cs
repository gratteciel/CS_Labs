using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button_UP_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox_language.SelectedIndex;
            if (selectedIndex > 0)
            {
                object selectedItem = listBox_language.SelectedItem;
                listBox_language.Items.RemoveAt(selectedIndex);
                listBox_language.Items.Insert(selectedIndex - 1, selectedItem);
                listBox_language.SetSelected(selectedIndex - 1, true);
            }
        }

        private void button_DOWN_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox_language.SelectedIndex;
            if (selectedIndex < listBox_language.Items.Count - 1)
            {
                object selectedItem = listBox_language.SelectedItem;
                listBox_language.Items.RemoveAt(selectedIndex);
                listBox_language.Items.Insert(selectedIndex + 1, selectedItem);
                listBox_language.SetSelected(selectedIndex + 1, true);
            }
        }

        private void button_AZ_Click(object sender, EventArgs e)
        {
            listBox_language.Sorted = true;
        }


        private void button_ZA_Click(object sender, EventArgs e)
        {
            List<object> items = listBox_language.Items.Cast<object>().OrderByDescending(i => i.ToString()).ToList();
            listBox_language.Items.Clear();
            listBox_language.Items.AddRange(items.ToArray());
        }

        private void button_UPR_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox.SelectedIndex;
            if (selectedIndex > 0)
            {
                object selectedItem = listBox.SelectedItem;
                listBox.Items.RemoveAt(selectedIndex);
                listBox.Items.Insert(selectedIndex - 1, selectedItem);
                listBox.SetSelected(selectedIndex - 1, true);
            }
        }

        private void button_DOWNR_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox.SelectedIndex;
            if (selectedIndex < listBox.Items.Count - 1)
            {
                object selectedItem = listBox.SelectedItem;
                listBox.Items.RemoveAt(selectedIndex);
                listBox.Items.Insert(selectedIndex + 1, selectedItem);
                listBox.SetSelected(selectedIndex + 1, true);
            }
        }

        private void button_AZR_Click(object sender, EventArgs e)
        {
            List<object> items = listBox_language.Items.Cast<object>().OrderBy(i => i.ToString()).ToList();
            listBox_language.Items.Clear();
            listBox_language.Items.AddRange(items.ToArray());

        }

        private void button_ZAR_Click(object sender, EventArgs e)
        {
            List<object> items = listBox_language.Items.Cast<object>().OrderByDescending(i => i.ToString()).ToList();
            listBox_language.Items.Clear();
            listBox_language.Items.AddRange(items.ToArray());

        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_R_Click(object sender, EventArgs e)
        {
            if (listBox_language.SelectedIndex != -1)
            {
                listBox.Items.Add(listBox_language.SelectedItem);
                listBox_language.Items.Remove(listBox_language.SelectedItem);
            }
        }


        private void button_L_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                listBox_language.Items.Add(listBox.SelectedItem);
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }


        private void button_SS_Click(object sender, EventArgs e)
        {
            listBox.Items.AddRange(listBox_language.Items);
            listBox_language.Items.Clear();
        }


        private void button_LL_Click(object sender, EventArgs e)
        {
            listBox_language.Items.AddRange(listBox.Items);
            listBox.Items.Clear();
        }

    }
}