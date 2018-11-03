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
        }
    }
}
