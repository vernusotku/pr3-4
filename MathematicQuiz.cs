using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MathematicQuiz : Form
    {
        Random rand = new Random();

        int addend1, addend2, minuend ,subtrahend, dividend, divisor, timeLeft;
        int multiplicand;
        int multiplier;


        public void StartQuiz()
        {
            timeLabel.BackColor = Color.White;
            addend1 = rand.Next(51);
            addend2 = rand.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            minuend = rand.Next(1, 101);
            subtrahend = rand.Next(1, minuend);
            minLeftLabel.Text = minuend.ToString();
            minRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            multiplicand = rand.Next(2, 11);
            multiplier = rand.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            divisor = rand.Next(2, 11);
            int temporaryQuotient = rand.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;


            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
            && (minuend - subtrahend == difference.Value)
            && (multiplicand * multiplier == product.Value)
            && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft == 5)
            {
                timeLabel.BackColor = Color.Red;
                timeLeft--;
                timeLabel.Text = timeLeft.ToString() + " seconds";

            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft.ToString() + " seconds";
            }



            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;

            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }

        public MathematicQuiz()
        {
            InitializeComponent();
        }
    }
}
