using System;

namespace numeronArvausPeli_V2
{
    class Program
    {
        static int salainenNumero(int MIN,int MAX)
        {
            var rand = new Random();
            return rand.Next(MIN,MAX);
        }

        static bool tarkistaNumero(int salanumero,int arvaus)
        {
            if(salanumero > arvaus)
            {
                Console.WriteLine("Luku on suurempi!");
                return false;
            }
            if(salanumero < arvaus)
            {
                Console.WriteLine("Luku on pienempi!");
                return false;
            }

            return true;
        }

        static void arvaaNumero(int salainenLuku)
        {
            int tmp = salainenLuku;
            Console.WriteLine("Arvaa salainen luku!");
            
            int arvaus = Convert.ToInt32(Console.ReadLine());

            bool tulos = tarkistaNumero(tmp, arvaus);

            if (tulos == true)
            {
                Console.WriteLine("Oikein arvattu!");
                return;
            }
            else
            {
                Console.WriteLine("Arvaa uudestaan!");
                arvaaNumero(tmp);
            }

        }

        static void Main(string[] args)
        {
            int salaluku = salainenNumero(1, 100);
            arvaaNumero(salaluku);
            Console.WriteLine("GAME OVER!");
        }
    }
}
