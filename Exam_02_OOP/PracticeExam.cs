using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public class PracticalExam : Exam
    {
        public PracticalExam(TimeSpan time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            foreach (var question in QuestionList.Questions)
            {
                Console.WriteLine(question);
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer);
                }

                Console.Write("Your Answer: ");

                int userAnswer = int.Parse(Console.ReadLine());
                Console.WriteLine($"Correct Answer: {question.RightAnswer}\n");
            }
        }

        public override object Clone()
        {
            PracticalExam newExam = new PracticalExam(Time, NumberOfQuestions);
            newExam.QuestionList = new QuestionList();

            foreach (var question in QuestionList.Questions)
            {
                newExam.QuestionList.Questions.Add((QuestionBase)question.Clone());
            }

            return newExam;
        }

    }
}
