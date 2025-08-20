using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    abstract class Question
    {
        #region Properties
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer? RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }
        #endregion

        #region Constructor
        protected Question(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }
        #endregion

        #region Method
        public abstract void ShowQuestion();
        #endregion
    }
}
