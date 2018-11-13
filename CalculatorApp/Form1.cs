using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        long result1;
        long result2;
        long result3;
        long result4;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result1 = Calculate(Convert.ToInt32(mtb1Left.Text), Convert.ToInt32(mtb1Right.Text), comboBox1.Text);
            result2 = Calculate(Convert.ToInt32(mtb2Left.Text), Convert.ToInt32(mtb2Right.Text), comboBox2.Text);
            result3 = Calculate(Convert.ToInt32(mtb3Left.Text), Convert.ToInt32(mtb3Right.Text), comboBox3.Text);
            result4 = Calculate(Convert.ToInt32(mtb4Left.Text), Convert.ToInt32(mtb4Right.Text), comboBox4.Text);
            UpdateLabels();
        }

        private void UpdateLabels() {
            try
            {
                result1 = Calculate(Convert.ToInt32(mtb1Left.Text), Convert.ToInt32(mtb1Right.Text), comboBox1.Text);
                label1.Text = Convert.ToString(result1);
            }
            catch { }
            try
            {
                result2 = Calculate(Convert.ToInt32(mtb2Left.Text), Convert.ToInt32(mtb2Right.Text), comboBox2.Text);
                label2.Text = Convert.ToString(result2);
            } catch { }
            try
            {
                result3 = Calculate(Convert.ToInt32(mtb3Left.Text), Convert.ToInt32(mtb3Right.Text), comboBox3.Text);
                label3.Text = Convert.ToString(result3);
            } catch { }
            try
            {
                result4 = Calculate(Convert.ToInt32(mtb4Left.Text), Convert.ToInt32(mtb4Right.Text), comboBox4.Text);
                label4.Text = Convert.ToString(result4);
            } catch { }
        }
        //calculates with inputs
        private long Calculate(int x,int y, string operatorType) {
            long result = 0;
            switch (operatorType)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
            }
            return result;
        }

        //mtb left aline
        private void mtb1Left_Click(object sender, EventArgs e) {
            mtb1Left.Select(0, 0);
        }
        private void mtb1Right_Click(object sender, EventArgs e) {
            mtb1Right.Select(0, 0);
        }
        private void mtb2Left_Click(object sender, EventArgs e) {
            mtb2Left.Select(0, 0);
        }
        private void mtb2Right_Click(object sender, EventArgs e) {
            mtb2Right.Select(0, 0);
        }
        private void mtb3Left_Click(object sender, EventArgs e) {
            mtb3Left.Select(0, 0);
        }
        private void mtb3Right_Click(object sender, EventArgs e) {
            mtb3Right.Select(0, 0);
        }
        private void mtb4Left_Click(object sender, EventArgs e) {
            mtb4Left.Select(0, 0);
        }
        private void mtb4Right_Click(object sender, EventArgs e) {
            mtb4Right.Select(0, 0);
        }

        private void mtb1Left_TextChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }
    }
}
