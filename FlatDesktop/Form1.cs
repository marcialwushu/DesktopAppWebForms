using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            fisrtCustomControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
               

        private void button2_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustomControl1.BringToFront();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            fisrtCustomControl1.BringToFront();

        }
    }
}
