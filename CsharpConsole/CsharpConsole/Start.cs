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
        bool _delegate = false;
        bool _asynAwait = false;
        bool _others = false;
        bool _timers = true;

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
            if(_timers)
            {
                var timers = new Timers();
                timers.Execute();
            }
        }
    }
}
