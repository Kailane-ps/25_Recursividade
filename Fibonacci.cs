namespace _25_Recursividade
{
    public class Fibonacci
    {
        public void GerarSequenciaFibonaci(int numero1, int numero2, int vezes)
        {
            if (vezes> 0)
            {
                System.Console.WriteLine(numero1);
                GerarSequenciaFibonaci(numero2, numero1 + numero2, vezes -1);
            }
        }

        public int GerarFatorial(int numero){
            if (numero == 1)
            {
                return 1;
            }
            else{
                return numero = GerarFatorial(numero - 1);
           
            }
        }


    }
}