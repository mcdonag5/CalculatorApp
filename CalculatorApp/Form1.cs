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

        //Updates all the results with the inputted text
        private void UpdateResult() {
            try
            {
                result1 = Calculate(Convert.ToInt32(mtb1Left.Text), Convert.ToInt32(mtb1Right.Text), comboBox1.Text);
                label1.Text = Convert.ToString(result1);
            }
            catch { result1 = 0; label1.Text = ""; }
            try
            {
                result2 = Calculate(Convert.ToInt32(mtb2Left.Text), Convert.ToInt32(mtb2Right.Text), comboBox2.Text);
                label2.Text = Convert.ToString(result2);
            } catch { result2 = 0; label2.Text = ""; }
            try
            {
                result3 = Calculate(Convert.ToInt32(mtb3Left.Text), Convert.ToInt32(mtb3Right.Text), comboBox3.Text);
                label3.Text = Convert.ToString(result3);
            } catch { result3 = 0; label3.Text = ""; }
            try
            {
                result4 = Calculate(Convert.ToInt32(mtb4Left.Text), Convert.ToInt32(mtb4Right.Text), comboBox4.Text);
                label4.Text = Convert.ToString(result4);
            } catch { result4 = 0; label4.Text = ""; }
            
            
            

        }
        //calculates with inputs
        private long Calculate(int x,int y, string operatorType) {
            long result = 0;
            switch (operatorType) {
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
            mtb1Left.Clear();
        }
        private void mtb1Right_Click(object sender, EventArgs e) {
            mtb1Right.Select(0, 0);
            mtb1Right.Clear();
        }
        private void mtb2Left_Click(object sender, EventArgs e) {
            mtb2Left.Select(0, 0);
            mtb2Left.Clear();
        }
        private void mtb2Right_Click(object sender, EventArgs e) {
            mtb2Right.Select(0, 0);
            mtb2Right.Clear();
        }
        private void mtb3Left_Click(object sender, EventArgs e) {
            mtb3Left.Select(0, 0);
            mtb3Left.Clear();
        }
        private void mtb3Right_Click(object sender, EventArgs e) {
            mtb3Right.Select(0, 0);
            mtb3Right.Clear();
        }
        private void mtb4Left_Click(object sender, EventArgs e) {
            mtb4Left.Select(0, 0);
            mtb4Left.Clear();
        }
        private void mtb4Right_Click(object sender, EventArgs e) {
            mtb4Right.Select(0, 0);
            mtb4Right.Clear();
        }

        private void mtb1Left_TextChanged(object sender, EventArgs e) {
            UpdateResult();
        }
    }
}
