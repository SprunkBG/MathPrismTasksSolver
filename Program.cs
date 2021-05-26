using System;

namespace PrismTasksSolver
{
    class Program
    {

        public static void SCalculation()
        {
            Console.WriteLine("Обиколка (P): ");
            double P = Double.Parse(Console.ReadLine());
            Console.WriteLine("Височина (h): ");
            double h = Double.Parse(Console.ReadLine());

            OkolnaPovurhninaTriugulna.CalculateS(P, h);
        }
        
        public static void HCalculation()
        {
            Console.WriteLine("Обем (V): ");
            double V = Double.Parse(Console.ReadLine());
            Console.WriteLine("Лице на призмата (B): ");
            double B = Double.Parse(Console.ReadLine());

            OkolnaPovurhninaTriugulna.CalculateH(V, B);
        }

        public static void BCalculation()
        {
            Console.WriteLine("Страна а: ");
            double a = Double.Parse(Console.ReadLine());

            PulnaPovurhnina.CalculateB(a);
        }

        public static void SearchedParameterForTriugulnaOkolnaPovurhnina(byte parameterNumber)
        {
            if (parameterNumber == 1)
            {
                SCalculation();
            }
            else if (parameterNumber == 2)
            {
                Console.WriteLine("Страна а: ");
                double a = Double.Parse(Console.ReadLine());

                OkolnaPovurhninaTriugulna.CalculateP(a);
            }
            else if (parameterNumber == 3)
            {
                BCalculation();
            }
        }

        public static void SearchedParameterForTriugulnaPulnaPovurhnina(byte parameterNumber)
        {
            if (parameterNumber == 1)
            {
                Console.WriteLine("Околна повърхнина (S): ");
                double S = Byte.Parse(Console.ReadLine());
                Console.WriteLine("Лице на призмата (B): ");
                double B = Byte.Parse(Console.ReadLine());

                PulnaPovurhnina.CalculateS1(S, B);
            }
            else if (parameterNumber == 2)
            {
                SCalculation();
            }
            else if (parameterNumber == 3)
            {
                BCalculation();
            }
        }

        public static void SearchedParameterForTriugulnaPrismaObem(byte parameterNumeber)
        {
            if (parameterNumeber == 1)
            {
                Console.WriteLine("Лице на призмата (B): ");
                double B = Double.Parse(Console.ReadLine());
                Console.WriteLine("Височина (h): ");
                double h = Double.Parse(Console.ReadLine());

                Obem.CalculateV(B, h);
            }
            else if (parameterNumeber == 2)
            {
                BCalculation();
            }
            else if (parameterNumeber == 3)
            {
                HCalculation();
            }
        }

        //TODO Insert Methods For Calculations
        public static void TrianglePrismTaskChoose(byte taskNumber)
        {
            if (taskNumber == 1)
            {

            }
            else if (taskNumber == 2)
            {

            }
            else if (taskNumber == 3)
            {

            }
        }

        //TODO Create 3 Classes For Square Prism Tasks
        //TODO Create Methods For Calculations
        //TODO Insert Methods For Calculations
        public static void SquarePrismTaskChoose(byte taskNumber)
        {
            if (taskNumber == 1)
            {

            }
            else if (taskNumber == 2)
            {

            }
            else if (taskNumber == 3)
            {

            }
        }

        public static void PrismType(byte prismType)
        {
            if (prismType == 1)
            {
                TrianglePrismTaskChoose(prismType);
            }
            else if (prismType == 2)
            {
                SquarePrismTaskChoose(prismType);
            }
        }

        public static void Main(string[] args)
        {
            


        }

    }
}
