using System;

namespace _25_Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci f = new Fibonacci();
            f.GerarSequenciaFibonaci(0,1,15);
            Console.WriteLine(f.GerarFatorial(5));
        }
    }
}
