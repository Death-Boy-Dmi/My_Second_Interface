using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Second_Interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataInputPanel0.Visible = true;
                DataInputPanel1.Visible = false;

                DataInputPanel0.Enabled = true;
                DataInputPanel1.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                DataInputPanel1.Visible = true;
                DataInputPanel0.Visible = false;

                DataInputPanel1.Enabled = true;
                DataInputPanel0.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
