using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public class Answer : ICloneable, IComparable<Answer>
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public object Clone() => new Answer(AnswerId, AnswerText);

        public int CompareTo(Answer other) => AnswerId.CompareTo(other.AnswerId);

        public override string ToString() => $"{AnswerId}. {AnswerText}";
    }

}
