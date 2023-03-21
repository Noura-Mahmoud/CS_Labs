namespace eventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Club club1 = new Club() { ClubID = 11, ClubName = "Manhwa"};
            Club club2 = new Club() { ClubID = 22, ClubName = "Manga" };
            Club club3 = new Club() { ClubID = 33, ClubName = "Anime" };
            Club club4 = new Club() { ClubID = 44, ClubName = "Movies" };
            Department dept1 = new Department() {DeptID = 111, DeptName = "Japan" };
            
            Employee emp1= new Employee() { EmployeeID = 1, BirthDate = new DateTime(1990), VacationStock = 2};
            SalesPerson sp = new SalesPerson() { EmployeeID = 2, BirthDate = new DateTime(1995), AchievedTarget=10};
            BoardMember bm = new BoardMember() { EmployeeID = 3, BirthDate = new DateTime(1996)};
            club1.AddMember(sp);
            club2.AddMember(emp1);
            club3.AddMember(bm);
            club4.AddMember(bm);
            dept1.AddStaff(emp1);
            dept1.AddStaff(sp);
            dept1.AddStaff(bm);

            // registeration
            // add pointer for subscriber call back methods into puplisher invokation list
            #region not needed
            //emp1.EmployeeLayOff += club2.RemoveMember;
            //emp1.EmployeeLayOff += dept1.RemoveStaff;
            //sp.EmployeeLayOff += club1.RemoveMember;
            //bm.EmployeeLayOff += club3.RemoveMember;
            //bm.EmployeeLayOff += club4.RemoveMember; 
            #endregion
            //emp1.EmployeeLayOff += new EmployeeLayOffEventArgs => Console.WriteLine("call back method");
            emp1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(5));
            //emp1.EndOfYearOperation();
            sp.CheckTarget(5);
            sp.CheckTarget(100);
            bm.Resign();
        }
    }
}