using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWinformApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            NameLabel6.Text = textBox1.Text;
            Surnamelb.Text = textBox2.Text;
            phonelb8.Text = textBox3.Text;
            citylabel9.Text = comboBox1.Text;
            addresslb10.Text = textBox4.Text;

        }
    }
}
