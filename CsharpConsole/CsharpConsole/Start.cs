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
        bool _asynAwait = false;
        bool _others = false;
        public void Initialize()
        {
            if (_delegate)
            {
                var delg = new DelegatesSample();
                delg.Execute();
            }
            if (_asynAwait)
            {
                var asaw = new AsynAwait();
                asaw.Execute();
            }
            if (_others)
            {
                var others = new Others();
                others.Execute();
            }
        }
    }
}
