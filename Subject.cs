using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {
        #region Properties
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        #endregion

        #region Constructors
        public Subject(int id, string name, Exam exam)
        {
            SubjectId = id;
            SubjectName = name;
            Exam = exam;
        }
        #endregion

        #region Methods
        public void ShowSubjectExam()
        {
            Console.WriteLine($"Subject: {SubjectName}");
            Exam.ShowExam();
        }
        #endregion


    }
}
