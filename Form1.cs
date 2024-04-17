using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // Percentage calculations
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {



            switch (qnum)
            {

                case 1:

                    lblQuestion.Text = "What is the tallest mountain in the world?";

                    button1.Text = "K2";
                    button2.Text = "Mount Everest";
                    button3.Text = "Kangchenjunga";
                    button4.Text = "Lhotse";

                    correctAnswer = 2;

                    break;
                case 2:
                    
                    lblQuestion.Text = "Which of these animals is NOT a mammal?";

                    button1.Text = "Penguin";
                    button2.Text = "Crocodile";
                    button3.Text = "Bat";
                    button4.Text = "Dolphin";

                    correctAnswer = 2;

                    break;

                case 3:

                    

                    lblQuestion.Text = " What is the capital of Australia?";

                    button1.Text = "Sydney";
                    button2.Text = "Melbourne";
                    button3.Text = "Canberra";
                    button4.Text = "Perth";

                    correctAnswer = 3;

                    break;

                case 4:

                    

                    lblQuestion.Text = "In the human body, what is the function of the heart?";

                    button1.Text = "To carry oxygen throughout the body";
                    button2.Text = "To store food";
                    button3.Text = "To provide structural support";
                    button4.Text = "To generate brainwaves";

                    correctAnswer = 1;

                    break;

                case 5:

                    

                    lblQuestion.Text = "What is the Mona Lisa famous painting by Leonardo da Vinci known for?";

                    button1.Text = "Its vibrant use of color";
                    button2.Text = "Its depiction of a historical figure";
                    button3.Text = "Its enigmatic smile";
                    button4.Text = "Its large size";

                    correctAnswer = 3;

                    break;

                case 6:

                   

                    lblQuestion.Text = "Which of these is NOT a primary color?";

                    button1.Text = "Red";
                    button2.Text = "Blue";
                    button3.Text = "Black";
                    button4.Text = "Yellow";

                    correctAnswer = 4;

                    break;

                case 7:

                    

                    lblQuestion.Text = "What is the currency of Japan?";

                    button1.Text = "Euro";
                    button2.Text = "Dollar";
                    button3.Text = "Yuan";
                    button4.Text = "Yen";

                    correctAnswer = 4;

                    break;

                case 8:
                    
                    
                  

                    lblQuestion.Text = "What is the scientific name for planet Earth?";

                    button1.Text = "Terra";
                    button2.Text = "Mars";
                    button3.Text = "Sol";
                    button4.Text = "Luna";

                    correctAnswer = 1;

                    break;




            }




        }

    }
}