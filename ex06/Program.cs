using System;

class Program
{
    static void Main()
    {
        ft_print_reverse_alphabet();
    }

    static void ft_print_reverse_alphabet()
    {
        char letter = 'z';

        while (letter >= 'a')
        {
            Console.Write(letter);
            lettre--;
        }

        Console.WriteLine();
    }
}
