using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCalculatorDLL;

namespace CalculatorUI
{
    public partial class FrmBasicCalculator : Form
    {

        BasicComputation calcu = new BasicComputation(0, 0);

        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float int1 = float.Parse(textBox1.Text);
            float int2 = float.Parse(textBox2.Text);

            switch (comboBox1.Text) 
            {
                case "+":
                    calcu = new BasicComputation(int1, int2);
                    label4.Text = BasicComputation.add().ToString();
                    break;

                case "-":
                    calcu = new BasicComputation(int1, int2);
                    label4.Text = BasicComputation.minus().ToString();
                    break;

                case "*":
                    calcu = new BasicComputation(int1, int2);
                    label4.Text = BasicComputation.multiply().ToString();
                    break;

                case "/":
                    calcu = new BasicComputation(int1, int2);
                    label4.Text = BasicComputation.divide().ToString();
                    break;

                default:
                    break;

            }


            
        }



    }
}
