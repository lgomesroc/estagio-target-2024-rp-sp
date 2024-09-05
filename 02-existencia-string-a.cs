2)Contar a ocorrência da letra 'a'

using System;

class Program
{
    static int CountA(string input)
    {
        int count = 0;
        foreach (char c in input.ToLower())
        {
            if (c == 'a')
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Informe uma string para verificar a quantidade de letras 'a': ");
        string input = Console.ReadLine();
        int count = CountA(input);

        Console.WriteLine($"A letra 'a' ocorre {count} vez(es) na string.");
    }
}
