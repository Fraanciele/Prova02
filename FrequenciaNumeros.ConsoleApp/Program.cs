//A entrada contém apenas 1 caso de teste. A primeira linha de entrada contem
//um único inteiro N, que indica a quantidade de valores que serão lidos para X
//(1 ≤ X ≤ 2000) logo em seguida. Com certeza cada número não aparecerá mais
//do que 20 vezes na entrada de dados.

using System;

namespace FrequenciaNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int N, X;
            

            Console.WriteLine("Digite um numero na entrada:");
            int N = System.Convert.ToInt32(Console.ReadLine());
            if (N == 0) 
            //comandos 
            for (int i = 0; i < N; i++)
            {
               for (int j = 0; j < N; j++)
                {
                    Console.WriteLine(" ");
                }
               for (int k = 0; k < N; k++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
                X = N;










            }
               
            

        }
    }
}
