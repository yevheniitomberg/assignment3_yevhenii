using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3_yevhenii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = Double.Parse(this.input_weight.Text);
                double height = Double.Parse(this.input_height.Text) / 100;
                double result = weight / (height * height);
                if (result > 18.5 && result < 25)
                {
                    this.label_result.Text = "BMI: " + result + "\nStatus: normal";
                } else if (result >= 25)
                {
                    this.label_result.Text = "BMI: " + result + "\nStatus: overweight";
                } else
                {
                    this.label_result.Text = "BMI: " + result + "\nStatus: underweight";
                }
            } catch
            {
                MessageBox.Show("Wrong input type!", "Input Error", MessageBoxButtons.OK);
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.input_height.Text = "";
            this.input_weight.Text = "";
            this.label_result.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
