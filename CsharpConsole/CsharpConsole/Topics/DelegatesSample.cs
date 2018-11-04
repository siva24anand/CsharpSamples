using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole.Topics
{
    public class DelegatesSample
    {
        public delegate int GetNum(int g);
        int num = 5;
        public int AddNum(int a)
        {
            return a + num;
        }
        public int MulNum(int m)
        {
            return m * num;
        }
        public int GetFunc(GetNum gf)
        {
            return gf(3);
        }
        public void Execute()
        {
            GetNum gn1 = new GetNum(AddNum);
            GetNum gn2 = new GetNum(MulNum);
            Console.WriteLine(gn1(2));
            Console.WriteLine(gn2(2));
            Console.WriteLine(GetFunc(gn1));
            Console.WriteLine(GetFunc(gn2));
            //calback by interface
             MeetingExecution meetingExecution = new MeetingExecution();  
            meetingExecution.PerformMeeting();
            //Func delegate
            Func<int, int, int> funcadd = sumforFunc;
            Console.WriteLine("Func result "+ funcadd(10, 8));
            Action<int, int> actionadd = sumforAction;
            actionadd(3, 8);
            Predicate<string> isUpper = isuppercase;
            Console.WriteLine("Predicate result " + isUpper("asfdFFFss"));
            //Events
            var program = new EventProgram();
            var result = program.executeevent();
            Console.WriteLine("Event Result " + result);
        }
        public int sumforFunc(int x, int y)
        {
            return x + y;
        }
        public void sumforAction(int x, int y)
        {
            Console.WriteLine("Action result " + x + y);
        }
        public bool isuppercase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }

    public delegate string mydel(string str);

    public class EventProgram
    {
        public event mydel myevent;

        public EventProgram()
        {
            this.myevent += new mydel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        public string executeevent()
        {
            return myevent("siva");
        }
    }

    public interface IMeeting
    {
         void ShowAgenda(string agenda);  
        void EmployeeAttendedMeeting(string employee);  
        void EmployeeLeftMeeting(string employee);  
    }

    public class Meeting : IMeeting  
    {  
        public void ShowAgenda(string agenda)  
        {  
            Console.WriteLine("Agenda Details: " + agenda);  
        }  
 
        public void EmployeeAttendedMeeting(string employee)  
        {  
            Console.WriteLine("Employee Attended Meeting: " + employee);  
        }  
  
        public void EmployeeLeftMeeting(string employee)  
        {  
            Console.WriteLine("Employee Left Meeting: " + employee);  
        }  
    }  

    public class MeetingRoom  
    {  
        private string message;  
        public MeetingRoom(string message)  
        {  
            this.message = message;  
        }  
 
        public void StartMeeting(IMeeting meeting)  
        {  
            // Its a callback  
            if (meeting != null) meeting.ShowAgenda(message);  
  
        }  
    }

    public class MeetingExecution  
    {  
        public void PerformMeeting()  
        {  
            IMeeting meeging = new Meeting();  
            MeetingRoom meetingStarted = new MeetingRoom("Code Quality Improvement.");  
            meetingStarted.StartMeeting(meeging);  
        }  
    }  

}
