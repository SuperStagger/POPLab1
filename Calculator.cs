using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPLab1
{
    internal class Calculator
    {
        private readonly int id;
        private readonly double step;
        private readonly Func<bool> canStopGetter;

        public Calculator(int id, double step, Func<bool> canStopGetter)
        {
            this.id = id;
            this.step = step;
            this.canStopGetter = canStopGetter;
        }

        public void Run()
        {
            double sum = 0;
            double value = 0;
            long count = 0;

            while (!canStopGetter())
            {
                sum += value;
                value += step;
                count++;
            }

            Console.WriteLine($"Потiк #{id}: сума = {sum:0.##}, элементiв = {count}");
        }
    }
}
