using System;


// Building a Mad Lib | C# | Tutorial 10

namespace CSharpExercises_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user for input

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color  :");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun  :");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter and celebrity  :");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love "  + celebrity);

            Console.ReadLine();

            int num = 10;
            num += 100;
            Console.WriteLine(num);

            int num2 = 10;
            num2 -= 100;
            Console.WriteLine(num2);

            int num3 = 10;
            num3 /= 100;
            Console.WriteLine(num3);

            int num4 = 10;
            num4 *= 100;
            Console.WriteLine(num4);

            num++;
            Console.WriteLine(num);

            Console.ReadLine();

        }
    }
}
