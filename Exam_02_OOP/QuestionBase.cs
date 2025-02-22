using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public abstract class QuestionBase : ICloneable, IComparable<QuestionBase>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }

        public QuestionBase(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract object Clone();

        public int CompareTo(QuestionBase other) => Mark.CompareTo(other.Mark);

        public override string ToString() => $"{Header}\n{Body}\nMark: {Mark}";
    }

}
