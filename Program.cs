using System;

namespace CalculatorForEveruthing
{
    class Program
    {

        public static void ConsoleColor()
        {

            Console.WriteLine("Choose color for the text (type the number): \n1) green \n2) red \n3) blue \n4) yellow \n5) white \n6) gray \n7) default");
            short color = Int16.Parse(Console.ReadLine());

            if (color == 1)
            {
                Console.ForegroundColor = System.ConsoleColor.Green;
            }
            else if (color == 2)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            else if (color == 3)
            {
                Console.ForegroundColor = System.ConsoleColor.Blue;
            }
            else if (color == 4)
            {
                Console.ForegroundColor = System.ConsoleColor.Yellow;
            }
            else if (color == 5)
            {
                Console.ForegroundColor = System.ConsoleColor.White;
            }
            else if (color == 6)
            {
                Console.ForegroundColor = System.ConsoleColor.Gray;
            }
            else if (color == 7)
            {
                Console.Write("");
            }

        }

        public static void DateAndTime()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine($"The time now is: {date.ToString()}");
        }

        public static void FromDecimalToBinary()
        {
            Console.WriteLine("How much numbers you want to convert form decimal to binary?");
            int n = Int32.Parse(Console.ReadLine());

            uint num = 0;

            for (int i = 0; i < n; i++)
            {
                num = UInt32.Parse(Console.ReadLine());

                ToBinary numbers = new ToBinary(num);

                Console.WriteLine($"The binary code of {num} is: {numbers}");
            }
        }

        public static void SqareRootCalculation()
        {
            Console.WriteLine("Number you want to calculate the square root: ");

            double number = Double.Parse(Console.ReadLine());

            SquareRoot r = new SquareRoot(number);
            Console.WriteLine(r);
        }

        public static void SquareEquation()
        {
            //double a = Double.Parse(Console.ReadLine());
            //double b = Double.Parse(Console.ReadLine());
            //double c = Double.Parse(Console.ReadLine());

            //SqareEquation se = new SqareEquation(a, b, c);
        }

        static void Main(string[] args)
        {

            DateAndTime();

            Console.WriteLine();

            ConsoleColor();

            FromDecimalToBinary();

            Console.WriteLine();

            SqareRootCalculation();

            Console.WriteLine();

            SquareEquation();

            Console.ReadKey();

        }
    }
}
