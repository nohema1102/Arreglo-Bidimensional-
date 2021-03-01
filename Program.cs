using System;

namespace Arreglo_Bidimensional_
{
    class Program
    {
        static void Main(string[] args)
        {
       int[,] matriz1 = { {1,3,5}, {2,4,6}, {3,5,9}};
       

       for (int filas = 0; filas < 3;filas++){
           for (int columnas = 0; columnas < 3;columnas++){
               Console.Write(matriz1[filas,columnas] + " ");
           }
           Console.WriteLine();
       }
            //Para calcular la determinante de una matriz se hacen multipliaciones 
            //en diagonal de arriba hacia abajo y luego de abajo hacia arriba. 

            //Multiplicacion de arriba hacia abajo en diagonal

            int valor1 = matriz1[0,0] * matriz1[1,1] * matriz1[2,2];
            int valor2 = matriz1[1,0] * matriz1[2,1] * matriz1[2,1];
            int valor3 = matriz1[2,0] * matriz1[0,1] * matriz1[1,2];

            //Multiplicacion de arriba hacia abajo en diagonal

            int valor4 = matriz1[1,0] * matriz1[0,1] * matriz1[2,2];
            int valor5 = matriz1[0,0] * matriz1[2,1] * matriz1[1,2];
            int valor6 = matriz1[2,0] * matriz1[1,1] * matriz1[0,2];

            int resultado1 = valor1 + valor2 + valor3;
            int resultado2 = valor4 + valor5 + valor6;

            int determinanteFinal = resultado1 - resultado2;

            

            Console.WriteLine(determinanteFinal);
        }
    }
}
