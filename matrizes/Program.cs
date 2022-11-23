using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite a quantidade de linhas e colunas, em seguida digite os valores da matrizes:  ");

            int M, N;
            int[,] A;

            string[] s1 = Console.ReadLine().Split(' ');
            M = int.Parse(s1[0]);
            N = int.Parse(s1[1]);
            A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
                
            }
            for (int i= 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}