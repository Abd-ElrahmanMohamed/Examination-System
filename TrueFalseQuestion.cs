using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueFalseQuestion : Question
    {
        #region Constructors
        public TrueFalseQuestion(string body, int mark, Answer rightAnswer): base("True/False", body, mark,new Answer[] { new Answer(1, "True"), new Answer(2, "False") },rightAnswer)
        { 
        
        }
        #endregion

        #region Methods
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header} Question Mark{Mark}\n");
            Console.WriteLine($"{Body}\n");
            foreach (var ans in AnswerList)
                Console.WriteLine(ans);
            Console.WriteLine("Please Enter The answer Id (1 For True | 2 For False):");
        }
        #endregion
    }
}
