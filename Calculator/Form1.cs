using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool isoperation = false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            isoperation = false;

            if ((textBox1.Text == "7") || (textBox1.Text == "0") ||(isoperation) )
            {   
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            //if (button.Text == ".")
            //{
            //    if (!textBox1.Text.Contains("."))
            //        textBox1.Text += button.Text;
            //}
            //else
            //    MessageBox.Show("Nu puteti adauga mai multe virgule!");

        }

        private void operator_click_event(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox1.Text);
          
           
            label1.Text = result + " " + operation;
            isoperation = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            label1.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ati esti din calculatorul dumneavoastra!");
            Environment.Exit(0);
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                     break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "sqrt":
                    double inputValue;
                    if (Double.TryParse(textBox1.Text, out inputValue) && inputValue >= 0)
                    {
                        textBox1.Text = Math.Sqrt(inputValue).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Valoarea introdusa nu poate fi calculata radicalul.");
                    }
                    break;


            }
        }
    }
}
