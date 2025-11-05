using POPLab1;
using System;
using System.Threading;

namespace POPLab1
{
    class Program
    {
        static volatile bool canStop = false;

        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть потокiв: ");
            int numThreads = int.Parse(Console.ReadLine() ?? "1");

            Console.Write("Введiть крок послiдовностi: ");
            double step = double.Parse(Console.ReadLine() ?? "1");

            for (int i = 0; i < numThreads; i++)
            {
                int id = i + 1;
                Calculator calc = new Calculator(id, step, () => canStop);
                new Thread(calc.Run).Start();
            }

            Stoper stoper = new Stoper(() => canStop = true);
            new Thread(stoper.Run).Start();
        }
    }
}