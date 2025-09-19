using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // Definición de variables
        int n;              // cantidad de notas
        double suma;        // suma total de notas
        double nota;        // cada nota individual
        double promedio;    // promedio final
        int i;              // contador para el bucle

        // Inicializar variables
        suma = 0;

        Console.WriteLine("Calculadora de promedio");

        Console.Write("Cuantas notas vas a ingresar: ");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            Console.Write("Nota " + i + ": ");
            nota = double.Parse(Console.ReadLine());
            suma = suma + nota;
        }
        promedio = suma / n;
        Console.WriteLine("El promedio es: " + promedio);
        if (promedio >= 14)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Desaprobado");
        }
            Console.ReadKey();
        }
        }
    }
