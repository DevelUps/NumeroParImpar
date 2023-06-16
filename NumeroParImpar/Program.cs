using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        { // Programa que calcula si un numero es par o es impar segun un valor solicitado al usuario
            double num;
            Console.Write("Por favor, ingresa un numero para validar si es par o impar:  ");
            num = Convert.ToDouble(Console.ReadLine());
            // Aqui condicionamos para calcular el valor impar o par con mod = 2 del numero que ingresamos
            if ((num % 2) == 0) 
            {
                Console.WriteLine("El numero ingresado {0} es Par", num);
            }
            else
            {
                Console.WriteLine("El numero ingresado {0} es Impar", num);
            }

        }
    }
}
