1) Sequência de Fibonacci

using System;

class Program
{
    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;
        while (a < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == number;
    }

    static void Main()
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int num = int.Parse(Console.ReadLine());

        if (IsFibonacci(num))
        {
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
        }
    }
}
