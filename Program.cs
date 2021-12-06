using System;

namespace probleme_FP_Laborator
{
    class Program
    {
        static void Main(string[] args)
        {
            P59();

        }
        /// <summary>
        /// Convrtese tempertura din celsius in fahrenheit si invers
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
            Console.WriteLine(Math.Pow(i, j) % k);
        }
        /// <summary>
        /// Determina daca un numar este perfect (este egali cu suma divizorilor diferiti de el insusi)
        /// </summary>
        private static void P4()
        {
            int n = int.Parse(Console.ReadLine());
            int div, suma = 0;
            for (div = 1; div <= n / 2; div++)
            {
                if (n % div == 0)
                {
                    suma += div;
                }

            }
            Console.WriteLine("Numarul " + (suma == n ? "" : "nu ") + "este perfect.");
        }
        /// <summary>
        /// Determina numerele perfecte din intervalul [a, b]
        /// </summary>
        private static void P5()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int div, suma;
            for (int i = a; i <= b; i++)
            {
                suma = 0;
                for (div = 1; div <= i / 2; div++)
                {
                    if (i % div == 0)
                    {
                        suma += div;
                    }

                }
                if (suma == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// Gaseste numerele prietene(au sumele divizorilor egale) din intervalul [a, b]
        /// </summary>
        private static void P6()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sumai = 0, sumaj = 0, div, i, j;
            for (i = a; i <= b; i++)
            {
                sumai = 0;
                for (div = 2; div <= i / 2; div++)
                {
                    if (i % div == 0)
                    {
                        sumai += div;
                    }

                }
                for (j = i + 1; j <= b; j++)
                {
                    sumaj = 0;
                    for (div = 2; div <= j / 2; div++)
                    {
                        if (j % div == 0)
                        {
                            sumaj += div;
                        }

                    }
                    if (sumai == sumaj)
                    {
                        Console.WriteLine($"{i}, {j}");
                    }


                }
            }
        }
        /// <summary>
        /// Calculeaza combinari de n luate cate k
        /// </summary>
        private static void P7()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int numarat = 1, numit = 1;
            for (int i = k + 1; i <= n; i++)
            {
                numarat = numarat * i;
            }
            for (int i = 2; i <= n - k; i++)
            {
                numit = numit * i;

            }
            Console.WriteLine($"Combinari de {n} luate cate {k} = {numarat / numit}.");
        }
        /// <summary>
        /// Calculeaza media aritmetica geometrica si armonica a divizorilor lui a
        /// </summary>
        private static void P8()
        {
            double a = double.Parse(Console.ReadLine());
            double suma = 0, produs = 1, nrdiv = 0, sumaarm = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    suma += i;
                    sumaarm += 1 / i;
                    produs *= i;
                    nrdiv++;
                }

            }
            double ma = suma / nrdiv;
            double mg = Math.Sqrt(produs);
            double mh = nrdiv / sumaarm;
            Console.WriteLine($"m. aritmetica:{ma}\nm. geometrica: {mg}\nm. armonica: {mh}.");
        }
        /// <summary>
        /// cmmdc si cmmmc
        /// </summary>
        private static void P9()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n1 = n, n2 = n;
            int m1 = m, m2 = m;

            int rest;
            while (m1 != 0)
            {
                rest = n1 % m1;
                n1 = m1;
                m1 = rest;

            }
            while (n2 != m2)
            {
                if (n2 < m2)
                {
                    n2 = n2 + n;
                }
                else
                {
                    m2 = m2 + m;

                }
            }
            Console.WriteLine($"Cel mai mare divizor comun al numerelor {n} si {m} este {n1} si cel mai mic multiplu comun este {n2}");

        }
        /// <summary>
        /// Afiseaza primele n numere prime
        /// </summary>
        private static void P10()
        {
            int n = int.Parse(Console.ReadLine());
            int nrprime = 1, nr = 3, verif;
            Console.WriteLine(2);
            while (nrprime < n)
            {
                verif = 1;
                for (int div = 2; div <= nr / 2 && verif == 1; div++)
                {
                    if (nr % div == 0)
                    {
                        verif = 0;
                    }
                }
                if (verif == 1)
                {
                    nrprime++;
                    Console.WriteLine(nr);
                }
                nr += 2;
            }
        }
        /// <summary>
        /// Determina daca doua numere sunt prime intre ele 
        /// </summary>
        private static void P11()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int verif = 1;
            for (int div = 2; div <= Math.Min(a, b); div++)
            {
                if (a % div == 0 && b % div == 0)
                {
                    verif = 0;
                }

            }

            Console.WriteLine($"Numerele {a} si {b}" + (verif == 1 ? " " : " nu ") + "sunt prime intre ele.");

        }
        /// <summary>
        /// Tabel cu valorile temperaturilor F si C
        /// </summary>
        private static void P12()
        {
            double F, C;
            Console.WriteLine("F        C");
            for (F = 0; F <= 300; F++)
            {
                Console.WriteLine($"{F}        {(5 * (F - 32)) / 9}");

            }

        }
        private static void P13()
        {
            double F, C;
            Console.WriteLine("C        F");
            for (C = 0; C <= 300; C++)
            {
                Console.WriteLine($"{C}        {9 * C / 5 + 32}");

            }
        }
        /// <summary>
        /// Citeste nr pana la intalnirea lui 0 si determina cel mai mare si cel mai mic nr citit
        /// </summary>
        private static void P14()
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int numar;

            do
            {
                numar = int.Parse(Console.ReadLine());
                if (numar < min)
                {
                    min = numar;
                }
                if (numar > max)
                {
                    max = numar;
                }
            } while (numar != 0);
            Console.WriteLine($"Cea mai mare valoare din secventa este : {max}.");
            Console.WriteLine($"Cea mai mica valoare din secventa este: {min}.");

        }
        /// <summary>
        /// Calzuleaza n!
        /// </summary>
        private static void P15()
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"{n}! = {factorial}");
        }
        /// <summary>
        /// Cate randuri are o carte cu n foi si r randuri pe o pagina
        /// </summary>
        private static void P16()
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine(2 * n * r);
        }
        /// <summary>
        /// Calculeaza viteza unui punct material in momentul t
        /// </summary>
        private static void P17()
        {
            float x0 = float.Parse(Console.ReadLine());
            float t0 = float.Parse(Console.ReadLine());
            float x = float.Parse(Console.ReadLine());
            float t = float.Parse(Console.ReadLine());
            float viteza = (x - x0) / (t - t0);
            Console.WriteLine($"Viteza in momentul t = {t} este {viteza} m/s.");
        }
        /// <summary>
        /// m aritmetica sau m geometrica
        /// </summary>
        private static void P18()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa calculam: media aritmetica (1) sau media geometrica(2)?");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine((a + b) / 2);
            }
            else if (input == 2)
            {
                if (a >= 0 && b >= 0)
                {
                    Console.WriteLine(Math.Sqrt(a * b));
                }
                else
                {
                    Console.WriteLine("eroare!");
                }
            }

        }
        /// <summary>
        /// Calculeaza aria sau perimetrul unui triunghi
        /// </summary>
        private static void P19()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa calculam: aria sau perimetrul?");
            string input = Console.ReadLine();
            if (input == "aria")
            {
                float p = (a + b + c) / 2;
                Console.WriteLine($"A = {Math.Sqrt(p * (p - a) * (p - b) * (p - c))} ");
            }
            else if (input == "perimetrul")
            {
                Console.WriteLine($"P = {a + b + c}");
            }



        }
        /// <summary>
        /// Calculeaza m. aritmetica a numerelor dintr- o secventa
        /// </summary>
        private static void P20()
        {
            float s = 0, nr = 0;
            float n;
            do
            {
                n = float.Parse(Console.ReadLine());
                s = s + n;
                nr++;


            } while (n != 0);
            nr--;
            Console.WriteLine(s / nr);
        }
        /// <summary>
        /// Determina cate numere dintr-o secventa impartite la p dau restul k
        /// </summary>
        private static void P21()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = 1; i <= n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr % p == k)
                {
                    contor++;
                }
            }
            Console.WriteLine($"{contor} numere din secventa au restul {k} la impartirea cu {p}.");



        }
        /// <summary>
        /// Calculeaza produsul a doua numere prin adunari repetate
        /// </summary>
        private static void P22()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int produs = 0;
            for (int i = 1; i <= p; i++)
            {
                produs += n;
            }
            Console.WriteLine($"{n} * {p} = {produs}");

        }
        /// <summary>
        /// Calculeaza impartirea a doua numere prin scaderi repetate
        /// </summary>
        private static void P23()
        {

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int raport = 0, copien = n;
            while (copien > 0)
            {
                copien = copien - p;
                if (copien >= 0)
                {
                    raport++;
                }
            }
            Console.WriteLine($"{n} / {p} = {raport}");
        }
        /// <summary>
        /// Determina cate cifre are un numar
        /// </summary>
        private static void P24()
        {
            int n = int.Parse(Console.ReadLine());
            int nrCifre = 0;
            while (n > 0)
            {
                n = n / 10;
                nrCifre++;

            }
            Console.WriteLine($"Numarul are {nrCifre} cifre.");
        }
        /// <summary>
        /// Determina daca un nr e palindrom
        /// </summary>
        private static void P25()
        {
            int n = int.Parse(Console.ReadLine());
            int oglindit = 0, cifra, copien = n;
            while (n != 0)
            {
                cifra = n % 10;
                n = n / 10;
                oglindit = oglindit * 10 + cifra;
            }
            Console.WriteLine($"numarul {copien} " + (oglindit == copien ? "" : "nu ") + "este palindrom.");

        }
        /// <summary>
        /// Afiseaza nr prime mai mici sau egale cu m
        /// </summary>
        private static void P26()
        {
            int m = int.Parse(Console.ReadLine());
            if (2 <= m)
            {
                Console.Write(2 + " ");
            }
            for (int i = 3; i <= m; i += 2)
            {
                int prim = 1;
                for (int div = 2; div <= i / 2; div++)
                {
                    if (i % div == 0)
                    {
                        prim = 0;
                        break;
                    }
                }
                if (prim == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
        /// <summary>
        /// Afiseaza primele n nr prime care au suma cifrelor <= m
        /// </summary>
        /// <returns></returns>
        private static void P27()
        {

            int n = int.Parse(Console.ReadLine());

            int m = int.Parse(Console.ReadLine());

            if (2 <= m)
            {
                Console.Write(2 + " ");
            }
            int i = 0, nr = 3, prim, sumaCifre;
            while (i < n)
            {
                int copieNr = nr;
                sumaCifre = 0;
                prim = 1;
                for (int div = 2; div <= nr / 2; div++)
                {
                    if (nr % div == 0)
                    {
                        prim = 0;
                        break;
                    }
                }

                if (prim == 1)
                {
                    while (copieNr > 0)
                    {

                        sumaCifre += copieNr % 10;
                        copieNr = copieNr / 10;
                    }
                    if (sumaCifre <= m)
                    {
                        Console.Write(nr + " ");
                        i++;
                    }

                }
                nr += 2;
            }
        }
        /// <summary>
        /// Afiseaza totate nr prime de 3 cifre care citite invers sunt tot numere prime
        /// </summary>
        private static void P28()
        {
            int n = 101;
            while (n < 1000)
            {
                int prim = 1;
                for (int div = 2; div <= n / 2; div++)
                {
                    if (n % div == 0)
                    {
                        prim = 0;
                        break;
                    }
                }
                if (prim == 1)
                {
                    int oglindit = 0, copien = n;
                    while (copien != 0)
                    {

                        oglindit = oglindit * 10 + copien % 10;
                        copien = copien / 10;
                    }
                    int primo = 1;
                    for (int div = 2; div <= oglindit / 2; div++)
                    {
                        if (oglindit % div == 0)
                        {
                            primo = 0;
                            break;
                        }
                    }
                    if (primo == 1)
                    {
                        Console.WriteLine(n);
                    }
                }
                n += 2;
            }
        }
        /// <summary>
        /// Afiseaza primele n numere care au suma cifrelor divizibila cu 5
        /// </summary>
        private static void P29()
        {
            int n = int.Parse(Console.ReadLine());
            if (0 <= n)
            {
                Console.Write(0 + " ");
            }
            if (5 <= n)
            {
                Console.Write(5 + " ");
            }
            int nr = 14;
            while (nr <= n)
            {
                int sumaCf = 0, copieNr = nr;
                while (copieNr > 0)
                {
                    sumaCf += copieNr % 10;
                    copieNr = copieNr / 10;
                }
                if (sumaCf % 5 == 0)
                {
                    Console.Write(nr + " ");
                }
                nr++;

            }

        }
        /// <summary>
        /// Converteste un numar din baza 10 in baza p < 10
        /// </summary>
        private static void P30A()
        {

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int copien = n, rez = 0, i = 1;
            while (copien > 0)
            {
                rez = rez + i * (copien % p);
                i *= 10;
                copien /= p;

            }
            Console.WriteLine($" {n} (10) = {rez} ({p})");

        }
        /// <summary>
        /// Converteste un numar din baza p < 10 in baza 10
        /// </summary>
        private static void P30B()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int pow = 0, copien = n;
            double rez = 0;
            while (copien > 0)
            {
                rez = rez + (copien % 10) * Math.Pow(p, pow);
                pow++;
                copien /= 10;
            }
            Console.WriteLine($" {n} ({p}) = {rez} (10)");

        }

        ///  /// <summary>
        /// Transforma radiani in grade
        /// </summary>
        private static void P34A()
        {
            double rad = double.Parse(Console.ReadLine());
            Console.WriteLine(rad * 180);
        }
        /// <summary>
        /// Transforma grade in radiani
        /// </summary>
        private static void P34B()
        {
            double gr = double.Parse(Console.ReadLine());
            Console.WriteLine(gr / 180);
        }
        /// <summary>
        /// Ia ca parametru un numar x si fiseaza in oridine inversa cifrele si calculeaza suma cifrelor
        /// </summary>

        private static void P36(int x)
        {
            int suma = 0;
            while (x != 0)
            {
                suma += x % 10;
                Console.Write(x % 10 + " ");
                x /= 10;
            }
            Console.WriteLine($"Suma cifrelor numarului este {suma}");
        }
        /// <summary>
        /// Afiseaza primii n termeni din sirul lui fibonacci
        /// </summary>

        private static void P37()
        {

        }
        /// <summary>
        /// Calculeaza n!
        /// </summary>
        private static void P38()
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"{n}! = {factorial}");
        }
        /// <summary>
        /// Calculeaza diferenta dintre doua momente de timp date in ore minute si secunde
        /// </summary>
        private static void P39()
        {
            Console.WriteLine("Ora inceput:");
            int startH = int.Parse(Console.ReadLine());
            int startM = int.Parse(Console.ReadLine());
            int startS = int.Parse(Console.ReadLine());
            Console.WriteLine("Ora sfarsit:");
            int stopH = int.Parse(Console.ReadLine());
            int stopM = int.Parse(Console.ReadLine());
            int stopS = int.Parse(Console.ReadLine());
            int diffH, diffM, diffS;
            if (stopS < startS)
            {
                stopS += 60;
                stopM--;
            }
            if (stopM < startM)
            {
                stopM += 60;
                stopH--;
            }
            diffS = stopS - startS;
            diffM = stopM - startM;
            diffH = stopH - startH;
            Console.WriteLine($"{diffH}:{diffM}:{diffS}");


        }
        /// <summary>
        /// Transforma viteza din m/s in km/h
        /// </summary>
        private static void P40()
        {
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine($"{v} m/s = {v * 18 / 5}km/h");
        }
        /// <summary>
        /// Un muncitor termina o lucrare in n zile. Determina in cat timp vor termina lucrarea mai multi muncitori
        /// </summary>
        private static void P41()
        {
            float n = float.Parse(Console.ReadLine());
            int nrMuncitori = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nrMuncitori} muncitori vor termina lucrarea in {n / nrMuncitori} zile.");

        }
        /// <summary>
        /// Verifica daca un numar este cub perfect
        /// </summary>
        private static void P42()
        {
            int n = int.Parse(Console.ReadLine());
            int cubP = 0;
            for (int i = (int)Math.Sqrt(n); i >= 0; i--)
            {
                if (i * i * i == n)
                {
                    cubP = 1;
                    break;
                }
            }
            Console.WriteLine($"{n}" + (cubP == 1 ? " " : " nu ") + "este un cub perfect.");

        }
        /// <summary>
        /// Calculeaza patratele elementelor unui tablou
        /// </summary>
        private static void P43()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i] * v[i] + " ");
            }

        }
        /// <summary>
        /// Afiseaza tabla inmultirii pentru un numar
        /// </summary>
        private static void P44()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {n} = {i * n} ");
            }
        }
        /// <summary>
        /// Inverseaza elementele uni tablou
        /// </summary>
        private static void P45()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int aux;
            for (int i = 0; i < n / 2; i++)
            {
                aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i] + " ");
            }

        }
        /// <summary>
        /// Afiseaza nr care se repeta intr- un tablou
        /// </summary>
        private static void P47()
        {
            Random rnd = new Random();
            int[] v = new int[100];
            int[] freq = new int[100];
            for (int i = 0; i < 100; i++)
            {
                v[i] = rnd.Next(99);
            }
            for (int i = 0; i < 100; i++)
            {
                Console.Write(v[i] + " ");
            }

            for (int i = 0; i < 100; i++)
            {
                freq[v[i]]++;

            }
            Console.WriteLine("\nNumerele care se repeta sunt: ");
            for (int i = 0; i < 100; i++)
            {
                if (freq[i] > 1)
                {
                    Console.Write(i + " ");
                }
            }

        }
        /// <summary>
        /// Aduna doua matrici de dimensiunea nxn
        /// </summary> Console.WriteLine("Matricea a:\n");
        private static void P48()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            int[,] suma = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matricea b:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = rnd.Next(10);
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Suma:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    suma[i, j] = a[i, j] + b[i, j];
                    Console.Write(suma[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Calculeaza media aritemtica a numerelor pare dintr un vector
        /// </summary>
        private static void P49()
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(100);
                Console.Write($"{v[i]} ");

            }
            float mediaA = 0, nr = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                {
                    mediaA += v[i];
                    nr++;
                }

            }
            mediaA /= nr;
            Console.WriteLine($"Media aritmetica = {mediaA}");
        }
        /// <summary>
        /// Determina daca un vector e ordonat crescator
        /// </summary>
        private static void P50()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            int cresc = 1; //presupunem ca vectorul e crescator
            for (int i = 1; i < n; i++)
            {
                if (v[i] < v[i - 1])
                {
                    cresc = 0;
                    break;
                }
            }
            Console.WriteLine("Vectorul" + (cresc == 1 ? " " : " nu ") + "este ordonat crescator.");

        }
        /// <summary>
        /// Determina minimul dintr - un vector
        /// </summary>
        private static void P51()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            int minim = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (v[i] < minim)
                {
                    minim = v[i];
                }
            }
            Console.WriteLine($"Valoarea minima din vector este {minim}.");
        }
        /// <summary>
        /// Determina daca un vector are numai elem pare
        /// </summary>
        private static void P52()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            int pare = 1;
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 1)
                {
                    pare = 0;
                    break;
                }
            }
            Console.WriteLine("Vectorul" + (pare == 1 ? " " : " nu ") + "are doar elemente pare.");

        }
        /// <summary>
        /// Determina daca un vector are numai elem impare
        /// </summary>
        private static void P53()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            int impare = 1;
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                {
                    impare = 0;
                    break;
                }
            }
            Console.WriteLine("Vectorul" + (impare == 1 ? " " : " nu ") + "are doar elemente impare.");



        }
        /// <summary>
        /// Determina raportul de elemente pare si impare dintr- un vector
        /// </summary>
        private static void P54()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            float nrPare = 0, nrImpare = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                {
                    nrPare++;
                }
                else
                {
                    nrImpare++;
                }

            }
            Console.WriteLine($"Raportul dintre elementele pare si cele impare este : {nrPare / nrImpare}");
        }
        /// <summary>
        /// Calculeaza expresia e = x1 - x2 + x3 - x4 + … ± xn.(elem unui vector)
        /// </summary>
        private static void P55()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            int e = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) //adunam elementele de indice par si scadem elementele de indice impar
                {
                    e += v[i];
                }
                else
                {
                    e -= v[i];
                }

            }
            Console.WriteLine($"e = {e}");
        }
        /// <summary>
        /// Construieste un vector cu primii n termeni ai sirului lui Fibonacci
        /// </summary>
        private static void P56()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            v[0] = 1;
            v[1] = 1;
            for (int i = 2; i < n; i++)
            {
                v[i] = v[i - 1] + v[i - 2];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
        /// <summary>
        /// Determina pozitia primului element dintr-un vector cu proprietatea
        /// ca este media aritmetică între succesorul și predecesorul său
        /// </summary>
        private static void P57()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            int gasit = 0;
            for (int i = 1; i < n - 1 && gasit == 0; i++)
            {
                if (v[i] == (v[i + 1] + v[i - 1]) / 2)
                {
                    Console.WriteLine($"Pozitia primului element egal cu media aritmetca dintre succesorul si predecesorul sau este {i}.");
                    gasit = 1;
                }
            }
            if (gasit == 0)
            {
                Console.WriteLine("Nu exista.");
            }
        }
        /// <summary>
        /// Determina pozitia ultimului element dintr-un vector care este egal cu k
        /// </summary>
        private static void P58()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for(int i  = n - 1; i >= 0; i--)
            {
                if (v[i] == k)
                {
                    Console.WriteLine($"Ultimul element din vector egal cu {k} este pe pozitia {i}.");
                    break;
                }
            }
        }
        /// <summary>
        /// Elimina elementul de pe pozitia poz dintr-un vector
        /// </summary>
        private static void P59()
        {
            int n = int.Parse(Console.ReadLine());
            int poz = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for(int i = poz; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            for(int i = 0; i< n - 1; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}

