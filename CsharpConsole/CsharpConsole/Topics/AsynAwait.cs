using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpConsole.Topics
{
    public class AsynAwait
    {
        public void Execute()
        {
            CallMethod();
        }
        static async void CallMethod()
        {
            string filePath = "fakepath";
            Task<int> task = ReadFile(filePath);

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            int length = await task;
            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");  

        }
        public static async Task<int> ReadFile(string str)
        {
            Console.WriteLine(" Other Work Readfile 1");
            await Task.Run(() => 
                {
                    Thread.Sleep(5000);
                });
            Console.WriteLine(" Other Work Readfile 2");
            Console.WriteLine(" Other Work Readfile 3");
            return 5;
        }
    }
}
