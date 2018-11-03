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
        }
    }

    public static class SampleExtension
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }

}
