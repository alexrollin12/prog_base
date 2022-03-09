using System;

namespace prog_base_final
{
    public class Functions
    {
        public static void lab05()
        {
            E01();
            E02();
            E03();
            E04();
            E05();
            E06();
        }

        public static void E01()
        {
            //Question 6.1
            decimal n1, n2, n3, n4, n5;
            Console.WriteLine("Entrer 5 nombres : ");
            n1 = decimal.Parse(Console.ReadLine());
            n2 = decimal.Parse(Console.ReadLine());
            n3 = decimal.Parse(Console.ReadLine());
            n4 = decimal.Parse(Console.ReadLine());
            n5 = decimal.Parse(Console.ReadLine());
            decimal resultat = Accumulator(n1, n2, n3, n4, n5);
            Console.WriteLine($"La somme est de : {resultat}");
        }

        public static void E02()
        {
            //Question 6.2
            decimal[] tableau = new decimal[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Entrer nombre #{i + 1} : ");
                tableau[i] = decimal.Parse(Console.ReadLine());
            }

            decimal result = Sum(tableau);
            Console.WriteLine($"Le resultat est de : {result}");
        }

        public static void E03()
        {
            double x1, x2, y1, y2;
            Console.WriteLine("Entrer X1 : ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrer Y1 : ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrer X2 : ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrer Y2 : ");
            y2 = double.Parse(Console.ReadLine());
            Distance(x1, x2, y1, y2);
        }
        public static void E04()
        {
            Console.WriteLine($"Entrez une quantite de nombre : ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes nombre sont : ");
            RandomNumbers(count);
        }
        public static void E05()
        {
            char answer;
            while (true)
            {
                Console.WriteLine($"Entrer un calcul (O/N)?");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'o' || answer == 'O')
                {
                    Power();
                }
                else if (answer == 'n' || answer == 'N')
                {
                    break;
                }
            }
        }
        public static void E06()
        {
            char input2;
            while (true)
            {
                Console.WriteLine("Entrer un calcul (O/N)?");
                input2 = char.ToUpper(char.Parse(Console.ReadLine()));
                while (input2 != 'N')
                {
                    bool choice = AnotherPower(input2);
                    if (choice)
                    {
                        if (input2 == 'O')
                        {
                            Power();
                        }
                    }

                    input2 = char.ToUpper(char.Parse(Console.ReadLine()));
                }
            }
        }
        public static bool AnotherPower(char input2)
        {
            if (input2 == 'N')
            {
                return false;
            }
            return true;
        }

        public static double Distance(double x1, double x2, double y1, double y2)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return distance;
        }

        public static decimal Accumulator(decimal n1, decimal n2, decimal n3, decimal n4, decimal n5)
        {
            decimal userTotal = n1 + n2 + n3 + n4 + n5;
            return userTotal;
        }

        public static decimal Sum(decimal[] tableau)
        {
            decimal result = 0;
            for (int i = 0; i < tableau.Length; i++)
            {
                result += tableau[i];
            }

            return result;
        }

        public static void RandomNumbers(int count)
        {
            int[] tableau = new int[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                tableau[i] = random.Next(0, 100);
                Console.Write($"{tableau[i]} ");
            }
        }

        public static void Power()
        {
            double x, y, result = 1;
            Console.WriteLine("Entrer nombre : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer la puissance : ");
            y = int.Parse(Console.ReadLine());
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            Console.WriteLine($"Resultat : {result}");
        }
    }
}