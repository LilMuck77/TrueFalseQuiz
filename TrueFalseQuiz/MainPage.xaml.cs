using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrueFalseQuiz
{
    public partial class MainPage : ContentPage
    {
        private List<Questions> lisOfQuestions = new List<Questions>();
        private int questionCounter = 0;
        private int results = 0;




        public MainPage()
        {
            InitializeComponent();
            lisOfQuestions.Add(new Questions("I see the glass half empty.", false));
            lisOfQuestions.Add(new Questions("I look for the positives in a negative outcome.", true));
            lisOfQuestions.Add(new Questions("I like meeting new people.", true));
            lisOfQuestions.Add(new Questions("I focus on the curses of my life", false)); ;
            lisOfQuestions.Add(new Questions("I view children as a blessing.", true));
            messageArea.Text = lisOfQuestions[questionCounter].question;

        }

        async void Button_Clicked(object sender, EventArgs args)
        {
            if (questionCounter < lisOfQuestions.Count)
            {
                if (((Button)sender).Text == "True" && lisOfQuestions[questionCounter].answer == true)
                {
                    results += 1;
                }
                else if (((Button)sender).Text == "False" && lisOfQuestions[questionCounter].answer == false)
                {
                    results += 1;

                }
               questionCounter++;
            }

            if (questionCounter >= lisOfQuestions.Count)
            {
                trueButton.IsVisible = false;
                falseButton.IsVisible = false;
                if (results >= 3)
                {
                    messageArea.Text = $"You are an optimist.";
                }
                else
                {
                    messageArea.Text = $"You are a pessimist.";

                }


            }
            else{

                messageArea.Text = lisOfQuestions[questionCounter].question;
            }
               



        }
    }
}
