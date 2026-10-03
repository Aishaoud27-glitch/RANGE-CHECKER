using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RANGE_CHECKER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
           private void checkButton_Click(object sender, EventArgs e)
        {
            int number;

            number = int.Parse(numberTextBox.Text);

            if (number >= 1 && number <= 10)
            {
                decisionTextBox.Text = "The number is in the range.";
            }
            else
            {
                decisionTextBox.Text = "The number is NOT in the range.";
            }
        }

       
            private void clearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Clear();
            decisionTextBox.Clear();

            numberTextBox.Focus();
        }

        
            private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    

