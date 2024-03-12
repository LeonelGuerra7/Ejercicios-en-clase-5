using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una frase:");
        string frase = Console.ReadLine();

        
        int ContadorP = ContarPalabras(frase);
        Console.WriteLine("Número de palabras en la frase: {ContadorP}");

        int ContadorV = ContarVocales(frase);
        Console.WriteLine("Número de vocales en la frase: {ContadorP}");
    }

    static int ContarPalabras(string frase)
    {
        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return palabras.Length;
    }

    static int ContarVocales(string frase)
    {

        return frase.Count(c => "aeiouAEIOU".Contains(c));
    }
}
