namespace Trihacklon2
{
    public class CalculatriceCrypto
    {
        /// <summary>
        /// 6★ Transforme un entier en sa représentation binaire (base 2).
        /// Plus d'étoiles si vous séparez les bits en blocs de 4.
        /// </summary>
        /// <example>28 --> 0001 1100</example>
        /// <param name="n">Un nombre en base 10</param>
        /// <returns>Le nombre en base 2</returns>
        public static string DecimalABinaire(int n)
        {
            return "";
        }

        /// <summary>
        /// 6★ Transforme un entier en sa représentation octale (base 8).
        /// Plus d'étoiles si vous séparez les chiffres en blocs de 3.
        /// </summary>
        /// <example>28 423 --> 067 407</example>
        /// <param name="n">Un nombre en base 10</param>
        /// <returns>Le nombre en base 8</returns>
        public static string DecimalAOctal(int n)
        {
            return "";
        }

        /// <summary>
        /// 6★ Transforme un entier en sa représentation hexadécimale (base 16).
        /// Plus d'étoiles si vous séparez les bits en blocs de 2.
        /// Les chiffres en hexadécimal sont : 
        /// 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A (10), B (11), C (12), D (13), E (14), F (15)
        /// </summary>
        /// <example>28 423 --> 6F 07</example>
        /// <param name="n">Un nombre en base 10</param>
        /// <returns>Le nombre en base 16</returns>
        public static string DecimalAHexa(int n)
        {
            return "";
        }

        /// <summary>
        /// ★★★ Calcule le nombre de bits qu'il faut pour écrire un entier
        /// </summary>
        /// <example>Il faut 2 bits pour écrire le chiffre 3 (3 --> 11)</example>
        /// <param name="n">Un entier</param>
        /// <returns>Le nombre de bits nécessaires pour l'écrire.</returns>
        public static int NbDeBits(int n)
        {
            return -1;
        }

        /// <summary>
        /// ★★★ Calcule le nombre d'octets nécessaires pour écrire le nombre. Un octet (byte) vaut 8 bits.
        /// </summary>
        /// <example>255 entre dans 1 octet</example>
        /// <example>260 entre dans 2 octets</example>
        /// <param name="n">Un nombre</param>
        /// <returns>Le nombre d'octet suffisants pour le contenir</returns>
        public static int NbOctets(int n)
        {
            return -1;
        }

        /// <summary>
        /// 5★ Détermine si un nombre est premier ou non. Un nombre est premier si 
        /// ses seuls facteurs sont 1 et lui-même
        /// </summary>
        /// <example>13 est premier</example>
        /// <example>14 n'est pas premier (14 = 7 * 2)</example>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool EstPremier(int n)
        {
            return false;
        }

        /// <summary>
        /// 5★ Détermine si un nombre est semi-premier. Un nombre est semi-premier s'il a 
        /// exactement 2 facteurs premiers.
        /// </summary>
        /// <example>299 est semi-premier (299 = 13  * 23)</example>
        /// <example>300 n'est pas semi-premier (il a trop de facteurs)</example>
        /// <param name="n">Un nombre</param>
        /// <returns>Vrai si le nombre est semi-premier. Faux sinon.</returns>
        public static bool EstSemiPremier(int n)
        {
            return false;
        }

        /// <summary>
        /// 5★ Détermine si un nombre est semi-premier. Un nombre est semi-premier s'il a 
        /// exactement 2 facteurs premiers.
        /// Si le nombre est semi-premier, la fonction donne en plus ses deux facteurs premiers
        /// </summary>
        /// <example>299 est semi-premier (299 = 13  * 23)</example>
        /// <example>300 n'est pas semi-premier (il a trop de facteurs)</example>
        /// <param name="n">Un nombre</param>
        /// <param name="p">Son premier facteur premier</param>
        /// <param name="q">Son deuxièe facteur premier</param>
        /// <returns>Vrai si le nombre est semi-premier. Faux sinon.</returns>
        public static bool EstSemiPremier(int n, out int p, out int q)
        {
            p = -1;
            q = -1;
            return false;
        }

        /// <summary>
        /// ★★ Détermine si un nombre est un jumeau. Un nombre n est jumeau s'il est premier
        /// et que n - 2 ou n + 2 sont premiers.
        /// </summary>
        /// <example>29 et 31 sont jumeaux</example>
        /// <param name="n">Un entier</param>
        /// <returns>Vrai si n est un jumeau, faux sinon</returns>
        public static bool EstJumeau(int n)
        {
            return false;
        }

        /// <summary>
        /// ★★ Détermine si un nombre est un premier de Sophie Germain.
        /// Un nombre n est un premier de Sophie Germain si :
        /// Il est premier et
        /// 2 * n + 1 est premier
        /// </summary>
        /// <param name="n">Un nombre</param>
        /// <returns>Vrai si le nombre est un premier de Sophie Germain, faux sinon</returns>
        public static bool EstPremierSophieGermain(int n)
        {
            return false;
        }

        /// <summary>
        /// ★★ Détermine si un nombre est un premier sûr
        /// Un nombre n est un premier sûr si :
        /// Il est premier et
        /// (n - 1) / 2 est premier
        /// </summary>
        /// <param name="n">Un nombre</param>
        /// <returns>Vrai si le nombre est un premier sûr, faux sinon</returns>
        public static bool EstPremierSur(int n)
        {
            return false;
        }

        /// <summary>
        /// ★★ Trouve la quantité de fois où le chiffre c apparaît dans un nombre en base 10.
        /// </summary>
        /// <example>Il y a 3 zéros dans 10010</example>
        /// <param name="n">Un entier</param>
        /// <returns>Le nombre de c dans la représentation en base 10 du chiffre</returns>
        public static int NbDeChiffre(int n, int c)
        {
            return -1;
        }

        /// <summary>
        /// 4★ Trouve le chiffre le plus populaire dans un nombre en base 10.
        /// </summary>
        /// <example>Le mode dans 788848388 est 8 (il apparait 6 fois)</example>
        /// <example>Dans 445566, 4, 5 ou 6 sont des bonnes réponses</example>
        /// <param name="n">un entier</param>
        /// <returns>Le mode de n</returns>
        public static int Mode(int n)
        {
            return -1;
        }

        /// <summary>
        /// ★★ Calcule la somme des chiffres dans un nombre
        /// </summary>
        /// <example>128 --> 1 + 2 + 8 = 11</example>
        /// <param name="n">Un entier</param>
        /// <returns>La somme des chiffres dans l'entier</returns>
        public static int SommeDesChiffres(int n)
        {
            return -1;
        }

        /// <summary>
        /// ★★ Calcule la somme des chiffres dans un nombre et recommence jusqu'à l'obtention
        /// d'un seul chiffre.
        /// </summary>
        /// <example>128 --> 1 + 2 + 8 = 11 --> 1 + 1 = 2</example>
        /// <param name="n">Un entier</param>
        /// <returns>La somme des chiffres dans l'entier, 
        /// récursivement jusquà l'obtention d'un seul chiffre.</returns>
        public static int SommeDesChiffresJusquaUnChiffre(int n)
        {
            return -1;
        }

        /// <summary>
        /// ★★ Détermine si un nombre est constitué de tout le même chiffre.
        /// </summary>
        /// <example>11111 est tout pareil</example>
        /// <param name="n">n entier</param>
        /// <returns>Vrai si le nombre est constitué de répétitions du même chiffre, faux sinon.</returns>
        public static bool EstToutPareil(int n)
        {
            return false;
        }

        /// <summary>
        /// 4★ Détermine si un nombre est un palindrome. Un nombre est un palindrome s'il s'écrit
        /// de la même manière à partir de la gauche et à partir de la droite. Par exemple, 
        /// les nombres 120021 et 64146 sont des palindromes.
        /// </summary>
        /// <param name="n">Un nombre</param>
        /// <returns>Vrai si le nombre est un palindrome, faux sinon.</returns>
        public static bool EstPalindrome(int n)
        {
            return false;
        }

        /// <summary>
        /// ★★★ Détermine si un nombre apparait dans la suite de Fibonacci.
        /// La suite de fibonacci est la suivante :
        /// 0, 1, 1, 2, 3, 5, 8, 13, ...
        /// Chaque élément est la somme des deux précédents
        /// </summary>
        /// <param name="n">Un nombre</param>
        /// <returns>Vrai si le nombre est dans la suite de Fibonacci, faux sinon</returns>
        public static bool EstDansFibonacci(int n)
        {
            return false;
        }

        /// <summary>
        /// ★★★ Détermine si un nombre apparait dans la suite de Fibonacci. S'il l'est, la
        /// fonction retourne la position du nombre dans la suite.
        /// 
        /// La suite de fibonacci est la suivante :
        /// 0, 1, 1, 2, 3, 5, 8, 13, ...
        /// Le 2 est à la position 3.
        /// Chaque élément est la somme des deux précédents
        /// </summary>
        /// <param name="n">Un nombre</param>
        /// <param name="position">La position du nombre dans la suite de Fibonacci, s'il en fait partie.</param>
        /// <returns>Vrai si le nombre est dans la suite de Fibonacci, faux sinon</returns>
        public static bool EstDansFibonacci(int n, out int position)
        {
            position = -1;
            return false;
        }
    }
}
