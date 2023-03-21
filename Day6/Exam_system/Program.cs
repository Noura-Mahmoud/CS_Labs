// See https://aka.ms/new-console-template for more information
using Exam_system;
using System;
using System.Xml.Linq;

#region add questions to exams
AnswerList a1 = new AnswerList() { new Answer("String"), new Answer("Class"), new Answer("Integer") };
MultiChoiceQ q1 = new MultiChoiceQ("Which of the following are value types in C#?", 3, "header1", a1, new Answer("String,Class,Integer"));
AnswerList a2 = new AnswerList() { new Answer("String"), new Answer("Class"), new Answer("Integer") };
OneChoiceQ q2 = new OneChoiceQ("Which of the following is not a reference type in C#?", 2, "header2", a2, new Answer("Integer"));
AnswerList a3 = new AnswerList() { new Answer("true"), new Answer("false")};
TrueFalseQ q3 = new TrueFalseQ("Value types in C# are stored on the stack", 1, "header3", a3, new Answer("true"));
QuestionList exam1 = new QuestionList("exam1")
{
    q1,
    q2,
    q3
};

int NumberOfQuestion = 3;
string subName = "test";

FinalExam Fex1 = new(90, NumberOfQuestion, subName, exam1);
PracticeExam Pex1 = new(60, NumberOfQuestion, subName, exam1);

if (NumberOfQuestion == exam1.Qlist.Count)
{
    Console.WriteLine("Enter 1 if you want the pactice Exam\nEnter 2 if you want the final Exam\nNote: if you want to choose more than one choice, \nwrite them as they appear with only',' between them");
    int type;
    if (int.TryParse(Console.ReadLine(), out type))
        switch (type)
        {
            case 1:
                Console.WriteLine("------------------------------------------ practice ----------------------------------");
                Pex1.showExam();
                #region exam correction
                //for(int i=0;i<noOfQues;i++)
                //{
                //    totalGrade += exam1.Qlist[i].Marks;
                //    Console.WriteLine("please enter your choice");
                //    if (Console.ReadLine() == exam1.Qlist[i].CorrectAnswer.Body)
                //        stdGrade += exam1.Qlist[i].Marks;
                //}
                //Console.WriteLine($"\n\nYour grade is {stdGrade} out of {totalGrade}\n\n"); 
                #endregion
                Pex1.examCorrection();
                Pex1.showModelAnswer();
                break;
            case 2:
                Console.WriteLine("----------------------------------------- final ------------------------------------------");
                Fex1.showExam();
                Fex1.examCorrection();
                break;
        }
}
else
    Console.WriteLine("please check the number of questions");
#endregion


#region write to file
//string file = "MCQ";
//File.WriteAllText($@"G:\txt_ex_test\{file}.txt", "nosa");
//using (StreamWriter sw = File.AppendText($@"G:\txt_ex_test\{file}.txt"))
//{
//	sw.WriteLine("Gfg");
//}
#endregion
#region file reader
//string name = "exam1";
//string file = $@"G:\txt_ex_test\{name}.txt";

//if (File.Exists(file))
//{
//    // store each line in array of strings
//    string[] lines = File.ReadAllLines(file);
//    //Console.WriteLine(lines[2]);
//    //foreach (string ln in lines)
//    //    Console.WriteLine(ln);
//}
//Console.WriteLine();
#endregion