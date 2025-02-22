using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public class FinalExam : Exam
    {
        public FinalExam(TimeSpan time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            double totalGrade = 0;
            foreach (var question in QuestionList.Questions)
            {
                Console.WriteLine(question);
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer);
                }
                Console.Write("Your Answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == question.RightAnswer.AnswerId)
                    totalGrade += question.Mark;
            }
            Console.WriteLine($"\nYour Grade: {totalGrade}");
        }

        public override object Clone()
        {
            FinalExam newExam = new FinalExam(Time, NumberOfQuestions);
            newExam.QuestionList = new QuestionList();
            foreach (var question in QuestionList.Questions)
            {
                newExam.QuestionList.Questions.Add((QuestionBase)question.Clone());
            }
            return newExam;
        }
    }
}
