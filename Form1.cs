using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CPU_Monitor
{
    public partial class Form1 : Form
    {
        public bool flag = true;
        PerformanceCounter CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter Memory = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter SystemUpTime = new PerformanceCounter("System", "System Up Time");
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Loading...";
            label2.Text = "Loading...";
            label3.Text = "Loading...";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == true)
            {
                label1.Text = "CPU: " + (int)CPU.NextValue() + "%";
                label2.Text = "Memory: " + (int)Memory.NextValue() + "MB" + "( " + (int)Memory.NextValue() / 1000 + " GB)";
                if ((int)SystemUpTime.NextValue() >= 2)
                {
                    label3.Text = "System Up Time: " + (int)SystemUpTime.NextValue() + "s " + "( " + (int)SystemUpTime.NextValue() / 60 / 60 + " Hours )";
                } else
                {
                    label3.Text = "System Up Time: " + (int)SystemUpTime.NextValue() + "s " + "( " + (int)SystemUpTime.NextValue() / 60 / 60 + " Hour )";
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
        }



        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Iron-9");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=niKP91D50Ko");
        }
    }
}
