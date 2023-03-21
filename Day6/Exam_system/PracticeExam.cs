using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class PracticeExam : Exam
    {
        Question[] questions;
        public PracticeExam(int time, int noOfQues,string subName, QuestionList questions): base(time, noOfQues, subName, questions)
        { }
        //public override void showExam()
        //{
        //    questions = modelAnswer.Keys.ToArray();
        //    for(int i=0; i<modelAnswer.Count;i++)
        //    {
        //        Console.WriteLine(questions[i]);
        //        Console.WriteLine(questions[i].Choices);
        //        Console.WriteLine();
        //    }
        //    //showModelAnswer(questions);
        //}

        //public void examCorrection()
        //{
        //    int totalGrade = 0;
        //    int stdGrade = 0;
        //    for (int i = 0; i < NumberOfQuestion; i++)
        //    {
        //        totalGrade += questions[i].Marks;
        //        Console.WriteLine($"\nplease enter your choice of question {i+1}");
        //        if (Console.ReadLine() == questions[i].CorrectAnswer.Body)
        //            stdGrade += questions[i].Marks;
        //    }
        //    Console.WriteLine($"\n\nYour grade is {stdGrade} out of {totalGrade}\n\n");
        //}

        //public void showModelAnswer()
        //{
        //    for (int i = 0; i < modelAnswer.Count; i++)
        //    {
        //        Console.WriteLine(questions[i]);
        //        Console.WriteLine(modelAnswer[questions[i]]);
        //        Console.WriteLine();
        //    }
        //}
    }
}
