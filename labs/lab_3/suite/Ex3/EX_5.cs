using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Ex3
{
    public partial class EX_5 : Form
    {
        private int _index = 0;
        private readonly Color[] _colors = { Color.Red, Color.Green, Color.Blue };
        private readonly int[] _intervals = { 1000, 2000, 3000 };

        public EX_5()
        {
            InitializeComponent();
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 3;
            timer1.Interval = 1000;
            timer1.Enabled = false;
            timer1.Elapsed += Timer1_Elapsed;
        }

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (_index >= 3)
            {
                _index = 0;
            }
            panel1.BackColor = _colors[_index];
            _index++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;
            if (radioButton1.Checked)
            {
                selectedIndex = 0;
            }
            else if (radioButton2.Checked)
            {
                selectedIndex = 1;
            }
            else if (radioButton3.Checked)
            {
                selectedIndex = 2;
            }
            timer1.Interval = _intervals[selectedIndex];
            timer1.Enabled = true;
            trackBar1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            panel1.BackColor = Color.White;
            trackBar1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 1:
                    timer1.Interval = 1000;
                    break;
                case 2:
                    timer1.Interval = 2000;
                    break;
                case 3:
                    timer1.Interval = 3000;
                    break;
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EX_5_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
