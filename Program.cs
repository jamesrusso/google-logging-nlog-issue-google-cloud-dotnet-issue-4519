using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestLogging
{
    class Program
    {

        static void Main(string[] args)
        {
            Logger logger = LogManager.GetLogger("foo");
            logger.Info("Program started");
        }
             
    }
}
