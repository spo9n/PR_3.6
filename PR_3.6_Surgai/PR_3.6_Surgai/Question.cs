using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_3._6_Surgai
{
    class Question
    {
        private string QuestionText;
        private bool Answer;

        public string GetQuestionText()
        {
            return QuestionText;
        }

        public bool GetAnswer()
        {
            return Answer;
        }

        public Question(string questionText, bool answer)
        {
            this.QuestionText = questionText;
            this.Answer = answer;
        }
        
    }
}
