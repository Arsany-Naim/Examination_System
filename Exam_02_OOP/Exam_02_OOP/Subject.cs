using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Console.Write("Enter exam type (1 for Final, 2 for Practical): ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter exam time (minutes): ");
            int minutes = int.Parse(Console.ReadLine());
            TimeSpan examTime = TimeSpan.FromMinutes(minutes);

            Console.Write("Enter number of questions: ");
            int numQuestions = int.Parse(Console.ReadLine());

            Exam = examType == 1
                ? new FinalExam(examTime, numQuestions)
                : new PracticalExam(examTime, numQuestions);

            Console.Clear();

            for (int i = 0; i < numQuestions; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Console.Write("Question type (1 for T/F, 2 for MCQ): ");
                int questionType = int.Parse(Console.ReadLine());

                Console.Write("Enter question body: ");
                string body = Console.ReadLine();

                Console.Write("Enter question mark: ");
                double mark = double.Parse(Console.ReadLine());

                QuestionBase question;
                if (questionType == 1)
                {
                    question = new TFQuestion($"Question {i + 1}", body, mark);
                }
                else
                {
                    question = new MCQuestions($"Question {i + 1}", body, mark);
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Enter choice {j + 1}: ");
                        string choice = Console.ReadLine();
                        question.Answers[j] = new Answer(j + 1, choice);
                    }
                }

                Console.Write("Enter right answer number: ");
                int rightAnswerId = int.Parse(Console.ReadLine());
                question.RightAnswer = question.Answers[rightAnswerId - 1];

                Exam.QuestionList.Questions.Add(question);
                Console.Clear();
            }
        }
    }
}
