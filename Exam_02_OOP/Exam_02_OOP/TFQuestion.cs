using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public class TFQuestion : QuestionBase
    {
        public TFQuestion(string header, string body, double mark) : base(header, body, mark)
        {
            Answers = new Answer[]
            {
            new Answer(1, "True"),
            new Answer(2, "False")
            };
        }

        public override object Clone()
        {
            TFQuestion newQuestion = new TFQuestion(Header, Body, Mark);
            newQuestion.RightAnswer = (Answer)RightAnswer.Clone();
            return newQuestion;
        }
    }
}
