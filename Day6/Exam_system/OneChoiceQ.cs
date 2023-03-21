using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class OneChoiceQ : Question
    {
        public OneChoiceQ(string _body, int _marks, string _header, AnswerList _choices, Answer _correctAns) : base(_body, _marks, _header, _choices, _correctAns)
        {
        }
    }
}
