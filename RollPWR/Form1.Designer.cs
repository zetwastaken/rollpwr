﻿namespace RollPWR
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.rollResultTextBox = new System.Windows.Forms.TextBox();
            this.customDiceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nickTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customDiceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PWR Roll 2022";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 93);
            this.button1.TabIndex = 4;
            this.button1.Text = "k2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.k2Button);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(55, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 93);
            this.button2.TabIndex = 5;
            this.button2.Text = "k4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.k4Button);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(55, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 93);
            this.button3.TabIndex = 6;
            this.button3.Text = "k6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.k6Button);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(291, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 93);
            this.button4.TabIndex = 8;
            this.button4.Text = "k10";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.k10Button);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(652, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 93);
            this.button5.TabIndex = 9;
            this.button5.Text = "k8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.k8Button);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(652, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 93);
            this.button6.TabIndex = 10;
            this.button6.Text = "k12";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.k12Button);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(652, 345);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 93);
            this.button7.TabIndex = 11;
            this.button7.Text = "k100";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.k100Button);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(441, 345);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 93);
            this.button8.TabIndex = 12;
            this.button8.Text = "k20";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.k20Button);
            // 
            // rollResultTextBox
            // 
            this.rollResultTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.rollResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rollResultTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollResultTextBox.Location = new System.Drawing.Point(304, 106);
            this.rollResultTextBox.Name = "rollResultTextBox";
            this.rollResultTextBox.ReadOnly = true;
            this.rollResultTextBox.Size = new System.Drawing.Size(235, 39);
            this.rollResultTextBox.TabIndex = 13;
            this.rollResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rollResultTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // customDiceNumericUpDown
            // 
            this.customDiceNumericUpDown.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customDiceNumericUpDown.Location = new System.Drawing.Point(361, 196);
            this.customDiceNumericUpDown.Name = "customDiceNumericUpDown";
            this.customDiceNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.customDiceNumericUpDown.TabIndex = 14;
            this.customDiceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.customDiceNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Inna Kostka";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(372, 234);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 93);
            this.button9.TabIndex = 16;
            this.button9.Text = "kX";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.kXButton);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(577, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nickTextbox
            // 
            this.nickTextbox.BackColor = System.Drawing.Color.Aquamarine;
            this.nickTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nickTextbox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickTextbox.Location = new System.Drawing.Point(135, 106);
            this.nickTextbox.Name = "nickTextbox";
            this.nickTextbox.Size = new System.Drawing.Size(155, 39);
            this.nickTextbox.TabIndex = 18;
            this.nickTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nickTextbox.TextChanged += new System.EventHandler(this.nickTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 42);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nick:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nickTextbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customDiceNumericUpDown);
            this.Controls.Add(this.rollResultTextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PWR Roll 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customDiceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox rollResultTextBox;
        private System.Windows.Forms.NumericUpDown customDiceNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nickTextbox;
        private System.Windows.Forms.Label label3;
    }
}

