using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    abstract class Exam
    {
        #region Properties
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[]? Questions { get; set; }
        #endregion

        #region Constructors
        public Exam(int time, int numberOfQuestions, Question[] questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }
        #endregion

        #region Methods
        public abstract void ShowExam(); 
        #endregion
    }
}
