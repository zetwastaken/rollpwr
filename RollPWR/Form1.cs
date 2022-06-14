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
        static int panelCounter = 0;
        public Form1()
        {
            InitializeComponent();
            nickTextbox.Text = "ja";
            customDiceNumericUpDown.Value = 2;
        }

         //* setSize();
         //* /
         

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1(object sender, EventArgs e)
        {
            // Center the Form on the user's screen everytime it requires a Layout.
            
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
            
            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k4Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 4;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k6Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 6;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k10Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 10;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k20Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 20;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k8Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 8;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k12Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 12;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void k100Button(object sender, EventArgs e)
        {
            int min = 1;
            int max = 100;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }


        private void kXButton(object sender, EventArgs e)
        {
            int min = 1;
            int max = (int)customDiceNumericUpDown.Value;
            int randomNum1 = dice.Next(min, max + 1);
            rollResultTextBox.Text = randomNum1.ToString();

            updateHistory(nickTextbox.Text, "k" + max.ToString(), randomNum1);
            //historyOfRollsTextBox.AppendText(randomNum1.ToString() + Environment.NewLine);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            customDiceNumericUpDown.Minimum = 2;
            customDiceNumericUpDown.Maximum = 10000;
            button9.Text = "k" + customDiceNumericUpDown.Value.ToString();

            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.diceHistoryPanel.AutoScroll = true;
            
        }
        private void updateHistory (string user, string dice, int roll)
        {
            int x=0,y=0;
            foreach (Label yz in diceHistoryPanel.Controls)
            {
                if (yz.Location.Y > y) { y = yz.Location.Y; }
            }
            
            if (panelCounter != 0) { y += 15; }

            panelCounter += 1;

            Label rollHistory = new Label();
            rollHistory.Text = panelCounter.ToString()+": " + user;
            rollHistory.Size = new Size(90, 15);
            rollHistory.Location = new Point(x, y);
            rollHistory.TextAlign = ContentAlignment.TopLeft;
            rollHistory.Font = new Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            diceHistoryPanel.Controls.Add(rollHistory);

            Label diceRoll = new Label();
            diceRoll.Text = roll.ToString();
            diceRoll.Size = new Size(60, 15);
            diceRoll.Location = new Point(x + 130, y);
            diceRoll.TextAlign = ContentAlignment.TopRight;
            diceRoll.Font = new Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            diceHistoryPanel.Controls.Add(diceRoll);

            Label diceType = new Label();
            diceType.Text = dice;
            diceType.Size = new Size(70, 15);
            diceType.Location = new Point(x + 75, y);
            diceType.TextAlign = ContentAlignment.TopCenter;
            diceType.Font = new Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            diceHistoryPanel.Controls.Add(diceType);

            diceHistoryPanel.VerticalScroll.Value = diceHistoryPanel.VerticalScroll.Maximum;
            diceHistoryPanel.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nickTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //nope nope nope nope
        private void setSize()
        {
            Size sizeOfWindow = this.ClientSize;
            float procentToChangeX = sizeOfWindow.Width / 800;
            float procentToChangeY = sizeOfWindow.Height / 500;
            foreach (Control x in this.Controls)
            {
                int width = (int)(x.Size.Width * procentToChangeX);
                int height = (int)(x.Size.Height * procentToChangeY);
                x.Size = new Size(width, height);
            }
        }
    }  
}
