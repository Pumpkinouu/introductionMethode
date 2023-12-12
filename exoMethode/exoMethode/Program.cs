using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoMethode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Déclaration des Variables ////

            int intValeur1;
            int intValeur2;
            int intAdditionner;
            int intSoustraire;
            float fltDiviser;
            int intMultiplier;
            char chr;

            //// Programme Principal ////

            Titre();

            // Demande de saisir la première valeur à l'utilisateur
            Console.Write("\nVeuillez saisir la valeur 1 :");
            intValeur1 = Convert.ToInt32(Console.ReadLine());

            // Demande la deuxième saisie à l'utilisateur
            Console.Write("\nVeuillez saisir la valeur 2 :");
            intValeur2 = Convert.ToInt32(Console.ReadLine());

            // Demande de chosir entre A et D
            Console.Write("\nVeuillez choisir la méthode (A/B/C/D) :");
            chr = Convert.ToChar(Console.ReadLine());

            // Instruction pour choix faire un choix multiple si 'A' fais la méthode additionner
            switch (chr)
            {
                case 'A':
                    intAdditionner = additionner(intValeur1, intValeur2);
                    Console.WriteLine("\nLe resultat est : " + intAdditionner);
                    break;
                case 'B':
                    intSoustraire = soustraire(intValeur1, intValeur2);
                    Console.WriteLine("\nLe resultat est : " + intSoustraire);
                    break;
                case 'C':
                    fltDiviser = diviser(intValeur1, intValeur2);
                    Console.WriteLine("\nLe resultat est : " + fltDiviser);
                    break;
                case 'D':
                    intMultiplier = multiplier(intValeur1, intValeur2);
                    Console.WriteLine("\nLe resultat est : " + intMultiplier);
                    break;
            }

            Console.ReadLine();
        }
        /// <summary>
        /// Affichage du titre
        /// </summary>
        static void Titre()
        {

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                  4 méthodes (Danilo Zivanovic)                  *");
            Console.WriteLine("*******************************************************************");
        }

        /// <summary>
        /// Condition qui addtionne les valeurs saisie par l'utilisateur
        /// </summary>
        /// <param name="intMValeur1"></param>
        /// <param name="intMValeur2"></param>
        /// <returns></returns>
        static int additionner(int intMValeur1, int intMValeur2)
        {
            int ResultA = (intMValeur1 + intMValeur2);
            return  ResultA;
        }

        /// <summary>
        /// Condition qui soustrait les valeurs saisie par l'utilisateur
        /// </summary>
        /// <param name="intTValeur1"></param>
        /// <param name="intTValeur2"></param>
        /// <returns></returns>
        static int soustraire(int intTValeur1, int intTValeur2)
        {
            int ResultS = (intTValeur1 - intTValeur2);
            return ResultS;
        }

        /// <summary>
        /// Condition qui divise les valeurs saisie par l'utilisateur
        /// </summary>
        /// <param name="intDValeur1"></param>
        /// <param name="intDValeur2"></param>
        /// <returns></returns>
        static float diviser(int intDValeur1, int intDValeur2)
        {
            float ResultD = (intDValeur1 / intDValeur2);
            return ResultD;
        }

        /// <summary>
        /// Condition qui multiplie les valeurs saisie par l'utilisateur
        /// </summary>
        /// <param name="intRValeur1"></param>
        /// <param name="intRValeur2"></param>
        /// <returns></returns>
        static int multiplier(int intRValeur1, int intRValeur2)
        {
            int ResultM = (intRValeur1 * intRValeur2);
            return ResultM;
        }
    }
}
