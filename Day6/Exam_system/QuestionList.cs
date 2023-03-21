using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//using static System.Collections.Immutable.ImmutableDictionary<TKey, TValue>;

namespace Exam_system
{
    internal class QuestionList: List<Question>
    {
        public List<Question> Qlist;
        StreamWriter sw;
        //string file;
        public string listName { get; }

        public QuestionList (string _listName)
        {
            Qlist = new();
            listName = _listName;
            File.WriteAllText($@"G:\txt_ex_test\{listName}.txt", $"{_listName}\n");
            //using (sw = File.AppendText($@"G:\txt_ex_test\{listName}.txt"))
            //{
            //    sw.WriteLine($"{_listName}");
            //    sw.Close();
            //}
        }
        public new void Add(Question ques)
        {
            Qlist?.Add(ques);
            try
            {
                //Qlist?.Add(ques);
                using (sw = File.AppendText($@"G:\txt_ex_test\{listName}.txt"))
                {
                    sw.WriteLine($"{ques?.Marks}-{ques?.Header}-{ques?.Body}-{ques?.CorrectAnswer}-{ques?.Choices}");
                    sw.Close();
                }
                //File.WriteAllText(file,$"{ques?.Marks}-Question {ques?.Header}?{ques?.Body}");
                //Console.WriteLine(File.ReadAllText(file));
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


    }
}
