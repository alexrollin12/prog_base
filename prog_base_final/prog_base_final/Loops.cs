using System;

namespace prog_base_final
{
    public class Loops
    {
        public static void Lab03()
        {
            //Question 3.1


        int choice;
        Console.WriteLine("Faite votre choix de menu [1, 2 ou 3] :");
        do
        {
            choice = int.Parse(Console.ReadLine());
        } while (choice > 3 || choice < 1);

        switch (choice)
        {
            case 1:
                Console.WriteLine("Ajouter une note");
                break;
            case 2: 
                Console.WriteLine("Modifier une note");
                break;
            case 3:
                Console.WriteLine("Supprimer une note");
                break;
        }


        //Question 3.2

        //aurait du etre fait avec un do while
        int userNumber5;
        Console.WriteLine("Entrez un nombre entre 10 et 20 inclusivement :");
        userNumber5 = int.Parse(Console.ReadLine());
        while (userNumber5 < 10)
        {
            Console.WriteLine("Plus grand!");
            userNumber5 = int.Parse(Console.ReadLine());
            while (userNumber5 > 20)
            {
                Console.WriteLine("Plus petit!");
                userNumber5 = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Bravo!");


        //Question 3.3

        //3.3.1 : (result !=0)

        //3.3.2 : 6

        //3.3.3 : 1

        //3.3.4 : modulo du resultat sans arret tant que resultat n'egale pas 0

        //Question 3.4

        int input, ogInput;
        double numFact;
        Console.WriteLine("Entrez un nombre entier");
        input = int.Parse(Console.ReadLine());
        ogInput = input;

        numFact = 1;
            while (input != 1)
            {
                numFact = numFact * input;
                input = input - 1;
            }
            Console.WriteLine($"La factorielle de {ogInput} est de {numFact}");


        //Question 3.5

        int randomNumber, amountTry = 0, userNumber;
        randomNumber = new Random().Next(0, 9);
        do
        {
            Console.WriteLine("Entrez un nombre de 0 a 9 : ");
            userNumber = int.Parse(Console.ReadLine());
        } while (userNumber < 0 || userNumber > 9);

        while (userNumber != randomNumber)
        {
            Console.WriteLine("Essaie encore!");
            userNumber = int.Parse(Console.ReadLine());
            amountTry = amountTry + 1;
        }
        Console.WriteLine($"Bravo tu as trouve le bon nombre en seulement {amountTry} essaies! ");


        //Question 3.6

        int randomNumber1, amountTry1 = 0, userNumber3;
        randomNumber1 = new Random().Next(0, 50);
        do
        {
            Console.WriteLine("Entrez un nombre de 0 a 50 : ");
            userNumber3 = int.Parse(Console.ReadLine());
        } while (userNumber3 < 0 || userNumber3 > 50);
        while(userNumber3 != randomNumber1)
        {
            if (userNumber3 > randomNumber1)
            {
                Console.WriteLine("Trop haut");
                userNumber3 = int.Parse(Console.ReadLine());
                amountTry1++;
            }
            else if (userNumber3 < randomNumber1){
                Console.WriteLine("Trop bas");
                userNumber3 = int.Parse(Console.ReadLine());
                amountTry1++;
            }
            
        }
        Console.WriteLine($"Bravo tu as reussi en seulement {amountTry1} essaies!");


        //Question 3.7

        int numClient;
        do
        {
            Console.WriteLine("Entrez un chiffre pair :");
            numClient = int.Parse(Console.ReadLine());
        } while (numClient % 2 != 0);

        Console.Write($"Resultat = ");
        for (int i = 0; i < 10; i++)
        {
            numClient = numClient + 2;
            Console.Write($"{numClient} ");
        }


        //Question 3.8

        double user1 = 0, user2;

        Console.WriteLine("Entre 5 nombre consecutif :");
        for (int i = 0; i < 5; i++)
        {
            user2 = double.Parse(Console.ReadLine());
            if(user2 > user1)
            {
                user1 = user2;
            }
        }
        Console.WriteLine($"Le plus grand nombre est {user1}");
        }
    }
}