﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa2D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassValueButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank" ;
            textBox2Input.Text = "" ; 
            textBox3Input.Text = "2.3" ; 
            textBox4Input.Text = "false" ; 
            textBox5InputA.Text = "2" ; 
            textBox5InputB.Text = "2" ; 
            textBox6Input.Text = "xyz" ; 
            textBox7Input.Text = "1" ; 
            textBox8InputA.Text = "2" ; 
            textBox8InputB.Text = "3" ; 
            textBox9Input.Text = "501" ; 
            textBox10InputA.Text = "2" ; 
            textBox10InputB.Text = "3" ;
        }

        private void setFailValueButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "0";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "5";
            textBox10InputB.Text = "4";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1Results.Text = "Fail";
            textBox2Results.Text = "Fail";
            textBox3Results.Text = "Fail";
            textBox4Results.Text = "Fail";
            textBox5Results.Text = "Fail";
            textBox6Results.Text = "Fail";
            textBox7Results.Text = "Fail";
            textBox8Results.Text = "Fail";
            textBox9Results.Text = "Fail";
            textBox10Results.Text = "Fail";


            if (textBox1Input.Text == "Frank")
                textBox1Results.Text = "Success";

            if (textBox2Input.Text == "")
                textBox2Results.Text = "Success";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3Results.Text = "Success";

            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4Results.Text = "Success";

            int val5A = Convert.ToInt32(textBox5InputA.Text);
            int val5B = Convert.ToInt32(textBox5InputB.Text);
            if (val5B == val5A)
                textBox5Results.Text = "Success";

            if (textBox6Input.Text == "xyz")
                textBox6Results.Text = "Success";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 > 0)
                textBox7Results.Text = "Success";

            int val8A = Convert.ToInt32(textBox8InputA.Text);
            int val8B = Convert.ToInt32(textBox8InputB.Text);
            if (val8A < val8B)
                textBox8Results.Text = "Success";

            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 > 500)
            textBox9Results.Text = "Success";

            int val10A = Convert.ToInt32(textBox10InputA.Text);
            int val10B = Convert.ToInt32(textBox10InputB.Text);
            if (val10A <= val10B)
                textBox10Results.Text = "Success";
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "";
            textBox2Input.Text = "";
            textBox3Input.Text = "";
            textBox4Input.Text = "";
            textBox5InputA.Text = "";
            textBox5InputB.Text = "";
            textBox6Input.Text = "";
            textBox7Input.Text = "";
            textBox8InputA.Text = "";
            textBox8InputB.Text = "";
            textBox9Input.Text = "";
            textBox10InputA.Text = "";
            textBox10InputB.Text = "";
            textBox1Results.Text = "";
            textBox2Results.Text = "";
            textBox3Results.Text = "";
            textBox4Results.Text = "";
            textBox5Results.Text = "";
            textBox6Results.Text = "";
            textBox7Results.Text = "";
            textBox8Results.Text = "";
            textBox9Results.Text = "";
            textBox10Results.Text = "";
            textBox1Input.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
