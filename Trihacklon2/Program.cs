using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trihacklon2
{
    class Program
    {
        const int LARGEUR = 50;

        static void MotImportant(string s)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(s);
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime des lignes dans un câdre aligné à gauche ou à droite
        /// </summary>
        /// <param name="left">Vrai pour alignement à gauche, faux pour alignement droite</param>
        /// <param name="lignes">Les lignes de texte à encadrer</param>
        static void ImprimerCadre(bool left = false, string titre = "", params string[] lignes)
        {
            MotImportant("╔");
            for (int i = 0; i < LARGEUR - 2; i++) MotImportant("═");
            MotImportant("╗");
            Console.WriteLine();
            if (titre != "")
            {
                int padL = (LARGEUR - titre.Length) / 2 - 1;
                int padR = (LARGEUR - titre.Length + 1) / 2 - 1;
                MotImportant("║");
                for (int i = 0; i < padL; i++)
                    Console.Write(" ");
                MotImportant(titre);
                for (int i = 0; i < padR; i++)
                    Console.Write(" ");
                MotImportant("║");
                Console.WriteLine();
                MotImportant(lignes.Length > 0 ? "╠" : "╚");
                for (int i = 0; i < LARGEUR - 2; i++)
                    MotImportant("═");
                MotImportant(lignes.Length > 0 ? "╣" : "╝");
                Console.WriteLine();
            }
            foreach (string l in lignes)
                if (l.Length > 0)
                {
                    MotImportant("║");
                    Console.Write(string.Format("{0," + ((left ? -1 : 1) * (LARGEUR - 2)) + "}", l));
                    MotImportant("║");
                    Console.WriteLine();
                }
            if (lignes.Length > 0)
            {
                MotImportant("╚");
                for (int i = 0; i < LARGEUR - 2; i++)
                    MotImportant("═");
                MotImportant("╝");
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        /// <summary>
        /// Imprime des faits intéressants à propos du nombre
        /// </summary>
        /// <param name="n">Un entier positif</param>
        static void ImprimerFunFacts(int n)
        {
            bool estPalindrome = CalculatriceCrypto.EstPalindrome(n);
            bool estFibonacci = CalculatriceCrypto.EstDansFibonacci(n, out int po);
            bool estToutPareil = CalculatriceCrypto.EstToutPareil(n);

            string description = "Il est constitué de : ";
            for (int i = 0; i < 10; i++)
            {
                int nbC = CalculatriceCrypto.NbDeChiffre(n, i);
                description += nbC > 0 ? (nbC + " " + i + "s, ") : "";
            }
            ImprimerCadre(true,
                $"Faits intéressants à propos de {n}",
                $"Il faut {CalculatriceCrypto.NbOctets(n)} octets pour l'écrire" +
                $" ({CalculatriceCrypto.NbDeBits(n)} bits)",
                estToutPareil ? $"Il est tout pareil" : "",
                description,
                $"Son mode est {CalculatriceCrypto.Mode(n)}",
                $"Sa somme des chiffre est {CalculatriceCrypto.SommeDesChiffres(n)}" +
                $" ({CalculatriceCrypto.SommeDesChiffresJusquaUnChiffre(n)}).",
                estPalindrome ? "C'est un palindrome." : "",
                estFibonacci ? $"C'est le {po}^e nombre de fibonacci." : "");

            bool estSemiPremier = CalculatriceCrypto.EstSemiPremier(n, out int p, out int q);
            bool estPremier = !estSemiPremier && CalculatriceCrypto.EstPremier(n);
            if (estPremier || estSemiPremier)
                ImprimerCadre(true,
                    $"{n} et les nombres premiers",
                    estSemiPremier ? $"Il est semi premier. {p}*{q}" : "",
                    estPremier ? $"Il est premier" +
                        (CalculatriceCrypto.EstJumeau(n) ? $" jumeau" : "") +
                        (CalculatriceCrypto.EstPremierSophieGermain(n) ? " de Sophie Germain" : "") +
                        (CalculatriceCrypto.EstPremierSur(n) ? " sûr" : "") + "." : "");
        }

        // Plus grand int :                      2_147_483_647
        // Plus grand int premier :              2_147_483_647
        static void Main(string[] _)
        {
            bool valide;
            do
            {
                Console.Clear();
                ImprimerCadre(true, "** LA CALCULATRICE DU CRYPTOGRAPHE **");
                Console.Write("Entrez un nombre positif en base 10 ");
                valide = int.TryParse(Console.ReadLine(), out int n) && n > 0;
                if (valide)
                {
                    ImprimerCadre(false, "",
                        string.Format("{0:n0} (décimal) ", n),
                        CalculatriceCrypto.DecimalABinaire(n) + " (binaire) ",
                        CalculatriceCrypto.DecimalAOctal(n) + " (octal)   ",
                        CalculatriceCrypto.DecimalAHexa(n) + " (hex)     ");
                    ImprimerFunFacts(n);
                    Console.Write("Appuyez sur une touche pour continuer");
                    Console.ReadKey();
                }
            } while (valide);
            Console.WriteLine("Merci d'avoir utilisé la calculatrice du cryptographe.");
        }
    }
}

