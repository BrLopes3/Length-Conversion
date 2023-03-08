using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidTerm_Form_BrunoLopes
{
    public partial class frm_ConvertLegth : Form
    {
        public frm_ConvertLegth()
        {
            InitializeComponent();
        }

        private void btnMYd_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertLength l1 = new ConvertLength(Convert.ToDouble(textBox1.Text)); //new object
                double l2 = l1.btnMYd_Click();
                double l1_cent = Convert.ToDouble(textBox1.Text) * 100;
                textBox2.Text = l1_cent.ToString();
                textBox3.Text = l2.ToString();
                textBox1.ReadOnly = true;
            }
            catch (Exception ex0)
            {
                MessageBox.Show(ex0.Message);
                textBox1.Focus();
            }
        }

        private void btnKmMile_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertLength l1 = new ConvertLength(Convert.ToDouble(textBox4.Text)); //new object
                double l2 = l1.btnKmMile_Click();
                double l1_cent = Convert.ToDouble(textBox4.Text) * 1000;
                textBox5.Text = l1_cent.ToString();
                textBox6.Text = l2.ToString();
                textBox4.ReadOnly = true;
            }
            catch (Exception ex0)
            {
                MessageBox.Show(ex0.Message);
                textBox4.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox1.Text = "0";
            textBox1.ReadOnly = false;
            textBox2.ResetText();
            textBox2.Text = "0";
            textBox3.ResetText();
            textBox3.Text = "0";
            textBox4.ResetText();
            textBox4.Text = "0";
            textBox4.ReadOnly = false;
            textBox5.ResetText();
            textBox5.Text = "0";
            textBox6.ResetText();
            textBox6.Text = "0";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App.? ", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void frm_ConvertLegth_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);

        }
    }
}
