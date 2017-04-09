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
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                rLabel.Visible = true;
                mLabel.Visible = false;
                lyambdaLabel.Visible = false;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                rLabel.Visible = true;
                mLabel.Visible = false;
                lyambdaLabel.Visible = false;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                rLabel.Visible = false;
                mLabel.Visible = false;
                lyambdaLabel.Visible = true;
            }
            if (comboBox2.SelectedIndex == 3)
            {
                rLabel.Visible = false;
                mLabel.Visible = true;
                lyambdaLabel.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                label16.Visible = true;
                label15.Visible = false;
                label4.Visible = false;
            }
            if (comboBox3.SelectedIndex == 1)
            {
                label16.Visible = true;
                label15.Visible = false;
                label4.Visible = false;
            }
            if (comboBox3.SelectedIndex == 2)
            {
                label16.Visible = false;
                label15.Visible = false;
                label4.Visible = true;
            }
            if (comboBox3.SelectedIndex == 3)
            {
                label16.Visible = false;
                label15.Visible = true;
                label4.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void mLabel_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " .dll | *.dll; | All Files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox13.Text = dialog.FileName;
            }
        }
    }
}
