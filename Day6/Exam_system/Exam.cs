using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }

        Subject subject;
        Question[] questions;

        public string getSubject()
        {
            return subject.name;
        } 
        public void setSubject(string subName)
        {
            subject.name = subName;
        }

        public Dictionary<Question, Answer> modelAnswer;
        public Exam(int _time, int _num,string _subName, QuestionList _questions) 
        {
            //if (_num == _questions.Qlist.Count)
            //{
                subject = new(_subName);
                modelAnswer = new();
                Time = _time;
                NumberOfQuestion = _num;

                #region read from file
                //string name = $"{_questions.listName}";
                //string file = $@"G:\txt_ex_test\{name}.txt";

                //if (File.Exists(file))
                //{
                //    // store each line in array of strings
                //    string[] lines = File.ReadAllLines(file);
                //    //foreach (string ln in lines)
                //    for(int k =1; k<lines.Length; k++)
                //        {
                //        string[] words = lines[k].Split('-');
                //        string[] choices = words[4].Split(',');
                //        AnswerList answers = new AnswerList();
                //        for (int i = 0; i<choices?.Length;i++)
                //        {
                //            answers.Add(new Answer(choices[i]));
                //        }
                //        Answer correctAns = new (words[3]);

                //        modelAnswer.Add(new Question(words[2], int.Parse(words[0]), words[1], answers, correctAns), correctAns);
                //    }
                //}
                #endregion

                #region read from saved list
                for (int i = 0; i < _questions.Qlist?.Count; i++)
                {
                    Question question = _questions.Qlist[i];
                    modelAnswer.Add(question, question.CorrectAnswer);
                    //Console.WriteLine("one question added");
                }
                #endregion
            //}
            //else
            //    Console.WriteLine("please check the number of questions");
        }

        //public virtual void showExam(){}
        #region common functions
        public void showExam()
        {
            questions = modelAnswer.Keys.ToArray();
            for (int i = 0; i < modelAnswer.Count; i++)
            {
                Console.WriteLine(questions[i]);
                //Console.WriteLine("Choices\n\n");
                Console.WriteLine(questions[i].Choices);
                Console.WriteLine();
            }
            //showModelAnswer(questions);
        }

        public void examCorrection()
        {
            int totalGrade = 0;
            int stdGrade = 0;
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                totalGrade += questions[i].Marks;
                Console.WriteLine($"\nplease enter your choice of question {i + 1}");
                if (Console.ReadLine() == questions[i].CorrectAnswer.Body)
                    stdGrade += questions[i].Marks;
            }
            Console.WriteLine("======================================================");
            Console.WriteLine($"\n\nYour grade is {stdGrade} out of {totalGrade}\n\n");
            Console.WriteLine("======================================================");
        }

        public void showModelAnswer()
        {
            for (int i = 0; i < modelAnswer.Count; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine(modelAnswer[questions[i]]);
                Console.WriteLine();
            }
        }
        #endregion
    }
}
