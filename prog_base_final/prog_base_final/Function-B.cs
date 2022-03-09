using System;

namespace prog_base_final
{
    public class Function_B
    {
        public static void Advance()
        {
            E08();
            E09();
            E10();
        }

        public static void E10()
        {
            Console.WriteLine("Combien de nombre dans le tableau");
            int[] userNum = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("entrer suite de numero");
            for (int i = 0; i < userNum.Length; i++)
            {
                userNum[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Le plus petit nombre est {getSmall(userNum)}");
            Console.WriteLine($"Le plus gros nombre est {getBigNbr(userNum)}");
        }

        public static int getSmall(int[] userArray)
        {
            int small = userArray[0];
            for (int i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] < small)
                {
                    small = userArray[i];
                }
            }

            return small;
        }

        public static int getBigNbr(int[] userArray)
        {
            int big = userArray[0];
            for (int i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] > big)
                {
                    big = userArray[i];
                }
            }

            return big;
        }

        public static void E09()
        {
            bool singulier = true;
            string mot;
            Console.WriteLine("Entrez un mot : ");
            mot = Console.ReadLine().ToUpper();
            if (isSingulier(mot))
            {
                Console.WriteLine($"{mot} est un mot singulier");
            }

            if (!isSingulier(mot))
            {
                Console.WriteLine($"{mot} est un mot pluriels");
            }
        }

        public static void E08()
        {
            int number;
            Console.WriteLine("entrer nombre :  ");
            number = int.Parse(Console.ReadLine());
            if (Prime(number))
            {
                Console.WriteLine($"{number} est un nombre premier");
            }

            if (!Prime(number))
            {
                Console.WriteLine($"{number} est un nombre divisible");
            }
        }

        public static bool Prime(int number)
        {
            int userNum = number;
            bool isPrime = false;
            if (userNum == 0 || userNum == 1)
            {
                Console.WriteLine($"{userNum} n'est pas un nombre premier");
            }
            else
            {
                for (int i = 2; i <= userNum / 2; i++)
                {
                    if (userNum % i == 0)
                    {
                        isPrime = false;
                    }
                }

                isPrime = true;
            }

            return isPrime;
        }

        public static bool isSingulier(string userWord)
        {
            if (userWord.EndsWith("S"))
            {
                return false;
            }

            return true;
        }
    }
}