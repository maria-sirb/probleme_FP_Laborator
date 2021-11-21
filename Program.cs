using System;

namespace probleme_FP_Laborator
{
    class Program
    {
        static void Main(string[] args)
        {
            P5();
        }
        /// <summary>
        /// Convrteste tempertura din celsius in fahrenheit si invers
        /// </summary>
        private static void P1()
        {
            double temperature = double.Parse(Console.ReadLine());
            string scale = Console.ReadLine();
            double result;
            switch (scale)
            {
                case "C":
                    result = (temperature - 32) * 5 / 9;
                    Console.WriteLine(result);
                    break;
                case "F":
                    result = temperature * 1.8 + 32;
                    Console.WriteLine(result);
                    break;
            }


        }
        /// <summary>
        /// Efectueaza operatii
        /// </summary>
        private static void P2()
        {
            string operatie = Console.ReadLine();
            double result, nr1, nr2;
            switch (operatie)
            {
                case "+":
                    nr1 = double.Parse(Console.ReadLine());
                    nr2 = double.Parse(Console.ReadLine());
                    result = nr1 + nr2;
                    Console.WriteLine(result);
                 break;
                case "-":
                   
                     nr1 = int.Parse(Console.ReadLine());
                     nr2 = int.Parse(Console.ReadLine());
                    result = nr1 - nr2;
                    Console.WriteLine(result);
                    break;
                case "*":
                   
                    nr1 = double.Parse(Console.ReadLine());
                    nr2 = double.Parse(Console.ReadLine());
                    result = nr1 * nr2;
                    Console.WriteLine(result);
                    break;
                case ":":
                     nr1 = double.Parse(Console.ReadLine());
                    nr2 = double.Parse(Console.ReadLine());
                    result = nr1 / nr2;
                    Console.WriteLine(result);
                    break;

                case "radical":
                    nr1 = double.Parse(Console.ReadLine());

                    result = Math.Sqrt(nr1);
                    Console.WriteLine(result);
                    break;
                case "modul":
                    nr1 = double.Parse(Console.ReadLine());

                    result = Math.Abs(nr1);
                    Console.WriteLine(result);
                    break;
            }


        }
        /// <summary>
        /// Calculeaza restul impartirii numarului i^j la k
        /// </summary>
        private static void P3()
        {
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(i,j) % k);
        }
        /// <summary>
        /// Determina daca un numar este perfect (este egali cu suma divizorilor diferiti de el insusi)
        /// </summary>
        private static void P4()
        {
            int n = int.Parse(Console.ReadLine());
            int div, suma = 0;
            for(div = 1; div <= n/2; div++)
            {
                if(n% div == 0)
                {
                    suma += div;
                }

            }
            Console.WriteLine("Numarul " + (suma == n? "":"nu ") + "este perfect.");
        }
        /// <summary>
        /// Determina numerele perfecte din intervalul [a, b]
        /// </summary>
        private static void P5()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int div, suma;
            for(int i = a; i<= b; i++)
            {
                suma = 0;
                for (div = 1; div <= i / 2; div++)
                {
                    if (i % div == 0)
                    {
                        suma += div;
                    }

                }
                if(suma == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
