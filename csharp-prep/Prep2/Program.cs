using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        string percentGrade = Console.ReadLine();
        int numberGrade = int.Parse(percentGrade);

        if (numberGrade >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (numberGrade >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (numberGrade >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (numberGrade >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

        if (numberGrade >= 70)
        {
            Console.WriteLine("Good job, you passed.");
        }
        else
        {
            Console.WriteLine("I'm sorry, you failed. Better luck next time.");
        }
    }
}