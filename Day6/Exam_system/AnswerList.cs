using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class AnswerList:List<Answer>
    {
        List<Answer> list;
        public AnswerList()
        {
            list = new();
        }
        public new void Add(Answer choice)
        {
            list.Add(choice);
        }
        public override string ToString()
        {
            return string.Join("\n", list);
        }
    }
}
