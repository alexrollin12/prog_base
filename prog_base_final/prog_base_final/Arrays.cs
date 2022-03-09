using System;

namespace prog_base_final
{
    public class Arrays
    {
        public static void Lab04()
        {
            //Question 4.1

byte[] tableau41 = new byte[] {0,1,2,3,4,5,6,7,8,9};

//Question 4.2

int[] list42 = new int[5];

for (int i = 0; i < list42.Length; i++)
{
    Console.WriteLine($"Entrer nombre #{i + 1} : ");
    list42[i] = int.Parse(Console.ReadLine());
}
Console.Write("Les nombres sont :");
for (int k = 0; k < list42.Length;k++)
{
    Console.Write($" {list42[k]} ");
}

//Question 4.3

int[] list43 = new int[5];
int sum43 = 0;


for (int i = 0; i < list43.Length; i++)
{
    Console.WriteLine($"\nEntrer nombre #{i + 1} : ");
    list43[i] = int.Parse(Console.ReadLine());
    sum43 += list43[i];
}
Console.Write($"La moyenne est de : {sum43 / list43.Length}");


//Question 4.4

int[] list44 = new int[5];
int numTop44 = 0, position = 0;
for (int i = 0; i < list44.Length; i++)
{
    Console.WriteLine($"Entrer nombre #{i + 1} : ");
    list44[i] = int.Parse(Console.ReadLine());
    if (list44[i] > numTop44)
    {
        numTop44 = list44[i];
        position = i + 1;
    }
}
Console.WriteLine($"Maximum = {numTop44} Position = {position}");


//Question 4.5

Random numRandom = new Random();
int[] tableau1 = new int[8];
int[] tableau2 = new int[8];
Console.WriteLine("Tableau 1 : ");
for (int i = 0; i < tableau1.Length; i++)
{
    tableau1[i] = numRandom.Next(0,9);
    Console.Write($"{tableau1[i]} ");
}
Console.WriteLine("\nTableau 2 : ");
for (int j = 0; j < tableau2.Length; j++)
{
    tableau2[j] = numRandom.Next(0, 9);
    Console.Write($"{tableau2[j]} ");
}
Console.WriteLine("\nResultat : ");
for (int k = 0; k < 8; k++)
{
    Console.Write($"{tableau1[k] * tableau2[k]} ");
}


//Question 4.6

int[] notes46 = new int[9];
int moyenne46 = 0, supMoyenne46 = 0;
for (int i = 0; i < notes46.Length; i++)
{
    Console.Write($"\nEntrer note #{i + 1} : ");
    notes46[i] = int.Parse(Console.ReadLine());
    moyenne46 += notes46[i];
}
moyenne46 /= notes46.Length;
for (int j = 0; j < notes46.Length; j++)
{
    if (notes46[j] > moyenne46)
    {
        supMoyenne46++;
    }
}
Console.WriteLine($"Nombre de notes > moyenne = {supMoyenne46}");



//Question 4.7


int[] tableau47 = new int[20];
int[] numTimes = new int[10];

for (int i = 0; i < tableau47.Length; i++)
{
    Console.Write("Enter un chiffre : ");
    tableau47[i] = int.Parse(Console.ReadLine());
    while (tableau47[i] > 9)
    {
        Console.WriteLine($"{tableau47[i]} n'est pas un chiffre");
        Console.Write("Enter un chiffre : ");
        tableau47[i] = int.Parse(Console.ReadLine());
    }

    switch (tableau47[i])
    {
        case 0 :
            numTimes[0]++;
            break;
        case 1 :
            numTimes[1]++;
            break;
        case 2 :
            numTimes[2]++;
            break;
        case 3 :
            numTimes[3]++;
            break;
        case 4 :
            numTimes[4]++;
            break;
        case 5 :
            numTimes[5]++;
            break;
        case 6 :
            numTimes[6]++;
            break;
        case 7 :
            numTimes[7]++;
            break;
        case 8 :
            numTimes[8]++;
            break;
        case 9 :
            numTimes[9]++;
            break;
            }
        }
        for (int i = 0; i < tableau47.Length; i++)
        {
            Console.WriteLine($"{i} --> {numTimes[i]}");
        }
        
// BONUS
        
/*
//Question 4.1
    Console.WriteLine("Saisir le nombre d'element :");
    int[] element = new int[int.Parse(Console.ReadLine())];
    for (int i = 0; i < element.Length; i++)
    {
        Console.WriteLine($"Element {i + 1} :");
        element[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("\nLes elements negatifs sont : ");
    for (int j = 0; j < element.Length; j++)
    {
        if (element[j] < 0)
        {
            Console.Write($"{element[j]} ");
        }
    }
    
    //Question 4.2
    Console.WriteLine("Combien de nombre voulez vous entrer : ");
    int[] userNum = new int[int.Parse(Console.ReadLine())];
    int numTop = 0, numSecond = 0;
    for (int i = 0; i < userNum.Length; i++)
    {
        Console.WriteLine($"Entrer numero {i + 1}: ");
        userNum[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < userNum.Length; i++)
    {
        if (userNum[i] > numTop)
        {
            numSecond = numTop;
            numTop = userNum[i];
        }
        else if (userNum[i] > numSecond && userNum[i] < numTop)
        {
            numSecond = userNum[i];
        }
    }
    Console.WriteLine($"Le premier grand nombre est {numTop}");
    Console.WriteLine($"Le deuxieme grand nombre est {numSecond}");
    //Question 4.3
    Console.WriteLine("Combien d'element dans le tableau : ");
    int[] tableau = new int[int.Parse(Console.ReadLine())];
    int pair = 0, impair = 0;

    for (int i = 0; i < tableau.Length; i++)
    {
        Console.Write($"\nEntrer nombre #{i + 1}: ");
        tableau[i] = int.Parse(Console.ReadLine());
        if (tableau[i] % 2 == 0)
        {
            pair++;
        }
        else
        {
            impair++;
        }
    }
    Console.WriteLine($"Nombre d'element pair : {pair}");
    Console.WriteLine($"Nombre d'element impair : {impair}");
    
    //Question 4.4
    Console.WriteLine("Entrer le nombre d'elements du tableau 1");
    int[] tableau1 = new int[int.Parse(Console.ReadLine())];
    int[] temp = new int[tableau1.Length];
    for (int i = 0; i < tableau1.Length; i++)
    {
        Console.Write($"\nEntrer nombre #{i + 1}: ");
        tableau1[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Entrer le nombre d'elements du tableau 2");
    int[] tableau2 = new int[int.Parse(Console.ReadLine())];
    for (int i = 0; i < tableau2.Length; i++)
    {
        Console.Write($"\nEntrer nombre #{i + 1}: ");
        tableau2[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < 5; i++)
    {
        temp[i] = tableau1[i];
        tableau1[i] = tableau2[i];
        tableau2[i] = temp[i];
    }
    */
        }
    }
}