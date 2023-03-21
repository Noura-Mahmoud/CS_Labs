using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal /*abstract*/ class Question
    {
        public string Body { get; set; }
        public int Marks { get; set; }
        public string Header { get; set; }

        public AnswerList Choices;

        public Answer CorrectAnswer;
        public Question(string _body, int _marks, string _header, AnswerList _choices = default, Answer _correctAnswer = default) 
        {  
            Body = _body;
            Marks = _marks;
            Header = _header;
            Choices = _choices;  
            CorrectAnswer = _correctAnswer;
        }

        public override string ToString()
        {
            return Body;
        }
    }
}
