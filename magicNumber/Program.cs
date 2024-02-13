using System;

namespace magicNumber
{
    class Program
    {
           const int NUMBER_MIN = 0;
           const int NUMBER_MAX = 10;
        
        static int ValidNumber()
        {
            int number = NUMBER_MIN - 1;
            while ((number > NUMBER_MAX) || (number < NUMBER_MIN))
            {
                Console.Write("entrez un chiffre entre " + NUMBER_MIN + " et " + NUMBER_MAX + " : ");
                string getNumber = Console.ReadLine();

                try
                {
                    number = int.Parse(getNumber);
                    if (number < 0)
                    {
                        Console.WriteLine("entre un chiffre positif");
                    }
                    else if ((number > NUMBER_MAX) || (number < NUMBER_MIN))
                    {
                        Console.WriteLine("le chiffre doit etre compris entre " + NUMBER_MIN + " et " + NUMBER_MAX);
                    }
                }
                catch
                {
                    Console.WriteLine("tu n'as pas entré de chiffre");
                }
            }
            return number;
        }       

        static void AskNumber()
        {
            Random rand = new Random();
            int magicNumber = rand.Next(NUMBER_MIN, NUMBER_MAX+1);
            int number =  ValidNumber();
            string reponse = "oui";
            int count = 3;
                Console.WriteLine();
                Console.WriteLine("vous avez " + count + " chances");
            while (count > 0 && reponse == "oui")

            {
                if (number < magicNumber)
                {
                    Console.WriteLine("le nombre à deviner est plus grand. Retentez de nouveau : ");
                    number = ValidNumber();
                   // count--;
                    Console.WriteLine("il vous reste " + count + " chance(s)");
                }
                else if (number > magicNumber)
                {
                    Console.WriteLine("le nombre à deviner est plus petit. Retentez de nouveau : ");
                    number = ValidNumber();
                   // count--;
                    Console.WriteLine("il vous reste " + count + " chance(s)");
                }
                else
                {
                    break;
                }
                count--; 
            }
                if (number == magicNumber)
                {
                    Console.WriteLine("bravo, le nombre magique était bien : " + magicNumber);
                Console.WriteLine("Voulez vous recommencer ? (oui / non) ");
                reponse = Console.ReadLine();
            }
                else if (count <= 0)
                {
                    Console.WriteLine("dommage vous avez épuisé toutes vos chances.");
                Console.WriteLine("le nombre magique était : " + magicNumber);
                Console.WriteLine("Voulez vous recommencer ? (oui / non) ");
                reponse = Console.ReadLine();
                }
                if(reponse == "oui")
            {
                AskNumber();
                   
                }
                else
            {
                    Console.WriteLine("Merci d'avoir joué");
                }   
        }

    
        static void Main(string[] args)
        {
            AskNumber(); 

           
        }
    }
}
