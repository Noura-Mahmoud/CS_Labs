using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class Subject
    {
        public string description { get; set; }
        public string instructor { get; set; }
        public string name { get; set; }
        public Subject( string _name) 
        {
            name= _name;
        }
    }
}
