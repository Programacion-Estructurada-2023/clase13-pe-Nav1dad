using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FOR // FOREACH

            // CASO SIMPLE

             for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"El numero es: {i}");
             } //Fin for

             // ELABORAR TABLA DE MULTPLICAR


             Console.WriteLine("Ingrese un numero para elaborar la tabala de multiplicar");
             int num = Convert.ToInt32(Console.ReadLine());

             for (int i = 1; i <= 10; i++)
             {
                int multiplicacion = num * i;

                Console.WriteLine($"{num} x {i} = {multiplicacion}");
             }


             // FOREACH

             // DECLARAR UNA LISTA

            List<int> numeros = new List<int>{24,10,8,35,14,7};

            int minimo = numeros[0]; // INICIALIZAR CON VALOR DEL INDICE 0



             foreach (int numero in numeros) 
             {
                if (numero < minimo)
                {
                    minimo = numero; // Actualizar el valor minimo
                }

             }

             Console.WriteLine("El numero minimo de la lista es > " + minimo);

             // VALORES POR ITERACIONES
             // 1 NUMERO VALDRIA 24 Y MINIMO 24 >>> COMPARAMOS MINIMO = 24
             // 2 NUMERO = 10 MINIMO 24 >>> COMPARAMOS MINIMO = 10
             // 3 NUMERO = 8 MINIMO 10 >>> COMPARAMOS MINIMO = 8
             // 4 NUMERO  = 35 MINIMO 8 >>> COMPARAMOS MINIMO =8 
             // 5 NUMERO = 14 MINIMO 8 >>> COMPARAMOS MINIMO = 8
             // 6 NUMERO = 7 MINIMO 8 >>> COMPARAMOS MINIMO = 7

            Console.ReadKey();

            // NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
            // CODIGO: U20230697

        }
    }
}