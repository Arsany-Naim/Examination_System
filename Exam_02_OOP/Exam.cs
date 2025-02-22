using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public abstract class Exam : ICloneable
    {
        public TimeSpan Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public QuestionList QuestionList { get; set; }

        public Exam(TimeSpan time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            QuestionList = new QuestionList();
        }

        public abstract void ShowExam();
        public abstract object Clone();
    }
}
