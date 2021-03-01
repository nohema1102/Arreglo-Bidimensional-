using System;

namespace Arreglo_Bidimensional_
{
    class Program
    {
        static void Main(string[] args)
        {
       int[,] matriz1 = { {1,3,5}, {2,4,6}, {3,5,9}};
       // [3,3]
       //[5,4]

       for (int i = 0; i < 3;i++){
           for (int j = 0; j < 3;j++){
               Console.Write(matriz1[i,j] + " ");
           }
           Console.WriteLine();
       }

        }
    }
}
