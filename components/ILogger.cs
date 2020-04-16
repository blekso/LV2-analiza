using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza.components
{
    //interface ILogger
    //{
    //    void Log(string message);
    //}
    interface ILogger 
    {
        void Log(ILogable data);
    }
}
