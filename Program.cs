namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1- Type of Exam
            Console.WriteLine("=====================================================");
            Console.WriteLine("==================Examination System=================");
            Console.WriteLine("=====================================================\n");
            Console.WriteLine("Please Enter the type of Exam (1 for Practical | 2 for Final) ");
            int.TryParse(Console.ReadLine(), out int examType);
            #endregion

            #region 2- Exam Time
            Console.WriteLine("Please Enter the Time For Exam From (30 min to 180 min))");
            int.TryParse(Console.ReadLine(), out int time);
            if (time < 30 || time > 180) time = 60;
            #endregion

            #region 3- Number of Questions
            Console.WriteLine("Please Enter the Number of questions");
            int.TryParse(Console.ReadLine(), out int numberOfQuestions);
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("==================Examination System=================");
            Console.WriteLine("=====================================================\n");
            #endregion

            #region 4- Enter Questions
            Question[] questions = new Question[numberOfQuestions];
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine("Please Enter the Type of Question (1 for MCQ | 2 For True | False)");
                int.TryParse(Console.ReadLine(), out int questionType);
                Console.Clear();
                Console.WriteLine("=====================================================");
                Console.WriteLine("==================Examination System=================");
                Console.WriteLine("=====================================================\n");
                // ====MCQ====
                if (questionType == 1)
                {
                    Console.WriteLine("MCQ Question");
                    Console.WriteLine("Please Enter Question Body");
                    string body = Console.ReadLine() ?? " ";

                    Console.WriteLine("Please Enter Question Mark");
                    int.TryParse(Console.ReadLine(), out int mark);

                    Console.WriteLine("Choices Of Question");
                    Console.WriteLine("How many choices?");
                    int.TryParse(Console.ReadLine(), out int choiceCount);

                    Answer[] answers = new Answer[choiceCount];
                    for (int c = 0; c < choiceCount; c++)
                    {
                        Console.WriteLine($"Please Enter Choice number {c + 1}");
                        string choice = Console.ReadLine() ?? " ";
                        answers[c] = new Answer(c + 1, choice);
                    }

                    Console.WriteLine("Please Enter the right answer id");
                    int.TryParse(Console.ReadLine(), out int rightId);
                    Answer rightAnswer = answers.First(a => a.AnswerId == rightId);

                    questions[i] = new MCQQuestion(body, mark, answers, rightAnswer);
                }
                // ====True/False====
                else
                {
                    Console.WriteLine("True | False Question");
                    Console.WriteLine("Please Enter Question Body");
                    string body = Console.ReadLine() ?? " ";

                    Console.WriteLine("Please Enter Question Mark");
                    int.TryParse(Console.ReadLine(), out int mark);

                    Console.WriteLine("Please Enter the right answer id (1 for true | 2 for false)");
                    int.TryParse(Console.ReadLine(), out int rightId);
                    Answer rightAnswer = (rightId == 1) ? new Answer(1, "True") : new Answer(2, "False");

                    questions[i] = new TrueFalseQuestion(body, mark, rightAnswer);
                }

                Console.Clear();
                Console.WriteLine("=====================================================");
                Console.WriteLine("==================Examination System=================");
                Console.WriteLine("=====================================================\n");
            }
            #endregion

            #region 5- Confirm Start
            Console.WriteLine("Do you want to Start Exam (Y|N)");
            string start = Console.ReadLine() ?? " ";
            if (start.ToUpper() != "Y") return;
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("==================Examination System=================");
            Console.WriteLine("=====================================================\n");
            #endregion

            #region 6- Running the Exam
            Exam exam = (examType == 1)
                   ? new PracticalExam(time, numberOfQuestions, questions)
                   : new FinalExam(time, numberOfQuestions, questions);
            #endregion

            #region 7- Display the Results
            exam.ShowExam();  
            #endregion

        }
    }
}
