using System;

namespace prog_base_final
{
    public class Conditionnelles
    {
        public static void Lab02()
        {
            //Question 2.1
            
            int userInput1;
            Console.WriteLine("Entrez un chiffre pour connaitre le carre : ");
            userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Le carre de {userInput1} est de : {userInput1 * userInput1}");
            
            // OR

            int userInput2, userSquare;
            Console.WriteLine("Entre un chifre pour connaitre son carre");
            userInput2 = int.Parse(Console.ReadLine());
            userSquare = (int) Math.Pow(userInput1, 2);
            Console.WriteLine($"Le carre de {userInput2} est de : {userSquare}");
            
            //Question 2.2
            
            double prix, tps, tvq;
            Console.WriteLine("Quel est le prix de la vente : ");
            prix = double.Parse(Console.ReadLine());
            Console.WriteLine($"Montant : {prix} $");
            Console.WriteLine($"TPS     : {tps =Math.Round(prix *0.10,2)} $ ");
            Console.WriteLine($"TVQ     : {tvq =Math.Round(prix * 0.0475,2)} $");
            Console.WriteLine($"Total   : {prix + tps + tvq} $");
            
            
            
            //Question 2.3
            
            float temp;
            string state = null;
            
            Console.WriteLine("Entrer la temperature : ");
            temp = float.Parse(Console.ReadLine());

            if (temp  >= 0)
            {
                state = "solide";
            }

            if (temp > 100)
            {
                state = "gazeux";
            }
            if(temp > 0 && temp < 100)
            {
                state = "liquide";
            }
            Console.WriteLine($"L'eau est dans un etat : {state}");
            
            
            //2.4 voir solution
            
            //Question 2.5 
            
            int nombre;
            Console.WriteLine("Entrer un nombre : ");
            nombre = int.Parse(Console.ReadLine());
            if (nombre % 5 == 0 && nombre % 7 != 0)
            {
                Console.WriteLine($"nombre {nombre} est valide");
            }
            else
            {
                Console.WriteLine($"nombre {nombre} est invalide");
            }
            //Question 2.6 see above.

            string jour = null;
            int userDay;
            
            Console.WriteLine("Quel jour de la semaine sommes nous?");
            userDay = int.Parse(Console.ReadLine());
            
            switch(userDay)
            {
                case 1 :
                    jour = "Bon Dimanche";
                    break;
                case 2 :
                    jour = "Bon Lundi";
                    break;
                case 3 :
                    jour = "Bon Mardi";
                    break;
                case 4 :
                    jour = "Bon Mercredi";
                    break;
                case 5 :
                    jour = "Jeudi";
                    break;
                case 6 :
                    jour = "Vendredi";
                    break;
                case 7 :
                    jour = "Samedi";
                    break;
                default:
                    Console.WriteLine("Tu es perdu dans l'espace toi!");
                    break;
            }
            Console.WriteLine(jour);
        }
    }
}