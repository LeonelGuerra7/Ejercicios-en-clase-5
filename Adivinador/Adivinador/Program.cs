using System;

class Program
{
    static void Main()
    {
        AdivinarNumero();
    }

    static void AdivinarNumero()
    {
        Console.WriteLine("Piensa en un número y sigue las instrucciones para que lo adivine.");

        Console.WriteLine("1- El adivinador le dirá a la persona que anote un número cualquiera.");
        Console.WriteLine("Ingresa el número:");
        int numero = int.Parse(Console.ReadLine());

        numero *= 2;
        Console.WriteLine("2- El adivinador le dirá que dicho número lo multiplique por 2.");
        Console.WriteLine("Resultado: " + numero);

        numero += 8;
        Console.WriteLine("3- Súmale 8 al resultado.");
        Console.WriteLine("Resultado: " + numero);

        numero *= 5;
        Console.WriteLine("4- Al resultado multiplícalo por 5.");
        Console.WriteLine("Resultado: " + numero);

        Console.WriteLine("5- El adivinador pide a la persona que le brinde el resultado final.");
        Console.WriteLine("¿Cuál es el resultado final?");
        int resultadoFinal = int.Parse(Console.ReadLine());

        int resultadoSinUltimaCifra = resultadoFinal / 10;
        Console.WriteLine("6- Anula la última cifra.");
        Console.WriteLine("Resultado sin última cifra: " + resultadoSinUltimaCifra);

        resultadoSinUltimaCifra -= 4;
        Console.WriteLine("7- Luego al resultado le restas 4.");
        Console.WriteLine("Resultado final: " + resultadoSinUltimaCifra);

        Console.WriteLine("8- El número de la otra persona es:" + resultadoSinUltimaCifra);
    }
}
