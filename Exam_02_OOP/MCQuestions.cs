using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public class MCQuestions : QuestionBase
    {
        public MCQuestions(string header, string body, double mark) : base(header, body, mark)
        {
            Answers = new Answer[4];
        }

        public override object Clone()
        {
            MCQuestions newQuestion = new MCQuestions(Header, Body, Mark);
            newQuestion.Answers = new Answer[Answers.Length];
            for (int i = 0; i < Answers.Length; i++)
            {
                newQuestion.Answers[i] = (Answer)Answers[i].Clone();
            }
            newQuestion.RightAnswer = (Answer)RightAnswer.Clone();
            return newQuestion;
        }
    }

}
