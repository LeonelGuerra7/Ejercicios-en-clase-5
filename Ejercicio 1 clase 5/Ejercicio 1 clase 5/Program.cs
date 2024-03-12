using System;

class Program
{
    static void Main()
    {
        int numero;
        int maximo = int.MinValue;
        int minimo = int.MaxValue;

        do
        {
            Console.Write("Ingrese un número positivo (ingrese 0 para finalizar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }
            }
            else if (numero < 0)
            {
                Console.WriteLine("Por favor, ingrese un número positivo.");
            }
        } while (numero != 0);

        if (maximo != int.MinValue && minimo != int.MaxValue)
        {
            Console.WriteLine("El número mayor ingresado fue: " + maximo);
            Console.WriteLine("El número menor ingresado fue: " + minimo);
        }
        else
        {
            Console.WriteLine("No se ingresaron números válidos.");
        }
    }
}



