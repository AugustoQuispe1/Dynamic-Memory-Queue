using System;
using System.Collections;
using System.Collections.Generic;


class Excercise1
    {
    static void Main(string[] args)
        {
        Queue<string> colaCadenas = new Queue<string>();

        Console.WriteLine("Introducir cadenas de texto (presiona Enter para agregar cada una) o introduce una cadena vacía para salir:");

        while (true)
            {
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
                {
                break;
                }

            colaCadenas.Enqueue(entrada);
            }

        Console.WriteLine("\nCadenas introducidas hasta el momento:");

        while (colaCadenas.Count > 0)
            {
            string cadena = colaCadenas.Dequeue();
            Console.WriteLine(cadena);
            }
        }
    }















