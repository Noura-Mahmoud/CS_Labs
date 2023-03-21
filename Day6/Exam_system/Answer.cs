using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class Answer
    {
        public string Body { get; set; }
        public Answer(string _body) 
        { 
            Body = _body; 
        }

        public override string ToString()
        {
            return Body;
        }
    }
}
