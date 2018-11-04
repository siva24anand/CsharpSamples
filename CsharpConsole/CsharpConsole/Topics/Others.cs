using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole.Topics
{
    public class Others
    {
        public void Execute()
        {
            int i = 10;
            var result = i.IsGreaterThan(100);
            Console.WriteLine("Extension method Result " +result);
            Console.WriteLine("Tuple Result 1 " + SampleExtension.GetPerson().Item1);
            Console.WriteLine("Tuple Result 2 " + SampleExtension.GetPerson().Item2);
            Console.WriteLine("Tuple Result 3 " + SampleExtension.GetPerson().Item3);
        }
    }

    public static class SampleExtension
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "siva", "anand");
        }
    }
    

}
