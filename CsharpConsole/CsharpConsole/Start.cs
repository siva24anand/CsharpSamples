using CsharpConsole.Topics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    public class Start
    {
        bool _delegate = true;

        public void Initialize()
        {
            if (_delegate)
            {
                var delg = new DelegatesSample();
                delg.Execute();
            }
        }
    }
}
