using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollPWR
{
    public partial class Form1 : Form
    {
        Random dice = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void k2Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 2;
            int randomNum1 = dice.Next(min,max+1);
            rollResultTextBox.Text =  randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k4Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 4;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k6Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 6;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k10Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 10;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k20Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 20;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k8Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 8;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k12Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 12;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k100Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 100;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }


        private void kXButton(object sender, EventArgs e)
        {
            int min = 1;
            int max = (int)customDiceNumericUpDown.Value;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            customDiceNumericUpDown.Minimum = 2;
            customDiceNumericUpDown.Maximum = 2147483645;
            button9.Text = "k" + customDiceNumericUpDown.Value.ToString();


        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
 
}
