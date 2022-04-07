//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            test1();
            test2();
            test3();
        }

        private static void test1()
        {
            for(int i = 0; i < 100; i++)
            {
                new Train("train "+i);
            }
            Console.WriteLine(Train.Count);
        }   
         private static void test2()
        {
            //No imprime 10 millones, imprime menos.
            //Esto puede ser porque el programa sin espacio en el stack (stack overflow) y
            //va borrando instancias a medida que crea nuevas.

            //Compruebo mi teoria al comentar la linea 72 de la clase Train y volver a ejecutar, imprime 10,000,100
            for(int i = 0; i < 10_000_000; i++)
            {
                new Train("train "+i);
            }
            Console.WriteLine(Train.Count);
        }
         private static void test3()
        {
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");

            //Aun teniendo el mismo "identifier" son dos objetos distintos, deberia dar "false".
            Console.WriteLine("t1 == t2: "+(t1==t2)); 

            
            //Nuevamente dos instancias distintas de una misma clase.
            Console.WriteLine("t2 == t3: "+(t2==t3));
        }
    }
}