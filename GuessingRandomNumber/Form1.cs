using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingRandomNumber
{
    public partial class Form1 : Form
    {
        Random randVar;
        int number;
        int guessCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            randVar = new Random();
            number = randVar.Next(1, 101);
            txtBoxMsg.Text = "Can you please guess the random number?";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int guessNumber;
            guessCounter++;

            if (int.TryParse(txtBoxAnswer.Text, out guessNumber))
            {
                if (guessNumber == number)
                {
                    MessageBox.Show("Congratulations your guess is Right in " + guessCounter + " tries.");
                    txtBoxMsg.Text = "Can you please guess the random number?";
                    txtBoxAnswer.Text = "";
                    txtBoxAnswer.Focus();
                    number = randVar.Next(1, 101);
                   
                }
                else if (guessNumber < number)
                {
                    txtBoxMsg.Text = "Sorry, the guess number is low. Try Again.";
                }
                else
                {
                    txtBoxMsg.Text = "Sorry, the guess number is high. Try Again.";
                }
            }
        }
    }
}
