using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string body, int mark, Answer[] answers, Answer rightAnswer)
         : base("MCQ", body, mark, answers, rightAnswer)
        { }
        #region Constructors


        #endregion

        #region Methods
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header} Question Mark{Mark}\n");
            Console.WriteLine($"{Body}\n");
            foreach (var ans in AnswerList)
                Console.WriteLine(ans);
            Console.WriteLine("Please Enter The answer Id:");
        }
        #endregion
    }
}
