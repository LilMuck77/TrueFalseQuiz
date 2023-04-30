using System;
using System.Collections.Generic;
using System.Text;

namespace TrueFalseQuiz
{
    public class Questions
    {
        public string question { get; set; }
        public bool answer { get; set; }
        public Questions(string question, bool answer)
        {
            this.question = question;
            this.answer = answer;
        }

    }
}