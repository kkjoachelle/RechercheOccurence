using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechercheOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Entrer la chaine de caractères");
            var chaine1 = Console.ReadLine();
            int NbreFois = 0;
            //
            StringBuilder stbAffiche = new StringBuilder();
            
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("la chaine saisie est: "+ chaine1);
            string chaine = chaine1.ToUpper();
            //boucle de recherche
            foreach (var item in chaine)
            {
                foreach (var item2 in chaine)
                {
                    if (item == item2)
                    {
                        NbreFois++;
                    }
                }
                //Eregistrement des elements qui ne se repètent pas
                if (NbreFois ==1)
                {
                    stbAffiche.Append(item);
                }
                NbreFois = 0;
            }
            Console.WriteLine("  ");
            Console.WriteLine("*******************************");
            Console.WriteLine("la chaine finale est: " + stbAffiche);
            Console.ReadKey();
        }
    }
}
