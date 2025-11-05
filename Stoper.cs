using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPLab1
{
    internal class Stoper
    {
        private readonly Action stopAction;

        public Stoper(Action stopAction)
        {
            this.stopAction = stopAction;
        }

        public void Run()
        {
            Thread.Sleep(5 * 1000);
            stopAction();
            Console.WriteLine("\nСтоп.");
        }
    }
}
