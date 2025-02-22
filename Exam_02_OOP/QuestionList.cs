using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_OOP
{
    public class QuestionList
    {
        public List<QuestionBase> Questions { get; set; }

        public QuestionList()
        {
            Questions = new List<QuestionBase>();
        }
    }

}
