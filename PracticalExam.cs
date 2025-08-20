using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        #region Constructors
        public PracticalExam(int Time, int NumberOfQuestions, Question[] Questions)
           : base(Time, NumberOfQuestions, Questions)
        {

        }
        #endregion

        #region Methods
        public override void ShowExam()
        {
            Console.WriteLine("=== Practical Exam ===");
            int totalMark = 0;
            var sw = Stopwatch.StartNew();

            if (Questions is not null)
            {
                foreach (var q in Questions)
                {
                    Console.Clear();
                    q.ShowQuestion();
                    int.TryParse(Console.ReadLine(), out int userAns);
                    q.UserAnswer = q.AnswerList.First(a => a.AnswerId == userAns);
                    if (q.UserAnswer.AnswerId == q.RightAnswer?.AnswerId)
                        totalMark += q.Mark;
                } 
            }

            sw.Stop();
            Console.Clear();
            int i = 1;
            if (Questions is not null)
            {
                foreach (var q in Questions)
                {
                    Console.WriteLine($"Question {i} : {q.Body}");
                    Console.WriteLine($"Your Answer => {q.UserAnswer.AnswerText}");
                    Console.WriteLine($"Right Answer => {q.RightAnswer?.AnswerText}\n");
                    i++;
                }
            }
            Console.WriteLine($"Your Grade is {totalMark} from {Questions?.Sum(q => q.Mark)}");
            Console.WriteLine($"Time = {sw.Elapsed}");
            Console.WriteLine("Thank you");
        } 
        #endregion
    }
}

