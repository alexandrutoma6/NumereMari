using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereMari
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numar1 = createNumber();
            Console.Write("numar1 este : ");
            for (int i = 0; i < numar1.Length; i++)
            {
                Console.Write(numar1[i]);
            }
            Console.WriteLine();
            int[] numar2 = createNumber();
            Console.Write("numar2 este : ");
            for (int i = 0; i < numar2.Length; i++)
            {
                Console.Write(numar2[i]);
            }
            int bigger = Compar(numar1, numar2);
            Console.WriteLine();
            Console.WriteLine("Alegeti operatia: 1.adunare 2.scadere 3.modulo 4.impartire 5.inmultire");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Adunare(numar1, numar2, bigger);
                    break;
                case 2:
                    Scadere(numar1, numar2, bigger);
                    break;
                case 3:
                    Modulo(numar1, numar2, bigger);
                    break;
                case 4:
                    Impartire(numar1, numar2, bigger);
                    break;
                case 5:
                    Inmultire(numar1, numar2, bigger);
                    break;

                default:
                    Console.WriteLine("error");
                    break;

            }
        }
        /// <summary>
        /// Compara cei doi vectori, returnand un numar intre 0-2
        /// </summary>
        /// <param name="numar1"></param> primul numar
        /// <param name="numar2"></param> al doilea numar
        /// <returns></returns> 0 egali 1 numarul 1 mai mare   2 numarul 2 mai mare
        private static int Compar(int[] numar1, int[] numar2)
        {
            int nr1 = numar1.Length;
            int nr2 = numar2.Length;
            if (nr1 > nr2)
                return 1;
            if (nr1 < nr2)
                return 2;
            int x = 0;
            if (nr1 == nr2)
            {
                for (int i = 0; i < nr1; i++)
                {
                    if (numar1[i] > numar2[i])
                    {
                        x++;
                        return 1;
                    }
                    if (numar1[i] < numar2[i])
                    {
                        x++;
                        return 2;
                    }
                }
            }
            return 0;
        }

        /// <summary>
        /// Functia inmulteste cei doi vectori
        /// </summary>
        /// <param name="numar1"></param>
        /// <param name="numar2"></param>
        /// <param name="bigger"></param>
        private static void Inmultire(int[] numar1, int[] numar2, int bigger)
        {

        }
        
        /// <summary>
        /// Functia imparte numarul mai mic la cel mai mare
        /// </summary>
        /// <param name="numar1"></param>
        /// <param name="numar2"></param>
        /// <param name="bigger"></param>
        private static void Impartire(int[] numar1, int[] numar2, int bigger)
        {

        }

        /// <summary>
        /// Functia imparte numarul la un numar ales, afisand restul impartirii
        /// </summary>
        /// <param name="numar1"></param>
        /// <param name="numar2"></param>
        /// <param name="bigger"></param>
        private static void Modulo(int[] numar1, int[] numar2, int bigger)
        {

        }

        /// <summary>
        /// Functia scade numarul 1 din numarul 2
        /// </summary>
        /// <param name="numar1"></param>
        /// <param name="numar2"></param>
        /// <param name="bigger"></param>
        private static void Scadere(int[] numar1, int[] numar2, int bigger)
        {
            int[] v = v = new int[numar1.Length+numar2.Length];
            int nr1 = numar1.Length;
            int nr2 = numar2.Length;
            int pos = 0;
            int imprumut = 0;
            if (bigger == 1)
            {
                for (int i = 0; i < nr2; i++)
                {
                    numar1[i] -= imprumut;
                    imprumut = 0;
                    if (numar1[i] - numar2[i] >= 0)
                    {
                        v[i] = numar1[i] - numar2[i];
                    }

                    if (numar1[i] - numar2[i] < 0)
                    {
                        imprumut = 1;
                        v[i] = (10 + numar1[i]) - numar2[i];
                    }
                    pos = i;
                }
                for (int i = nr2; i < nr1; i++)
                {
                    if (imprumut != 0)
                    {
                        if (numar1[i] != 0)
                        {
                            numar1[i] -= imprumut;
                            imprumut = 0;
                        }
                        else
                        {
                            numar1[i] = 10 - imprumut;
                            imprumut = 1;
                        }
                    }
                    v[i] = numar1[i];
                    pos = i;
                }
                writeNEGNumber(v, pos);
            }
            if (bigger == 2)
            {
                for (int i = 0; i < nr1; i++)
                {
                    numar2[i] -= imprumut;
                    imprumut = 0;
                    if (numar2[i] - numar1[i] >= 0)
                    {
                        v[i] = numar2[i] - numar1[i];
                    }

                    if (numar2[i] - numar1[i] < 0)
                    {
                        imprumut = 1;
                        v[i] = (10 + numar2[i]) - numar1[i];
                    }
                    pos = i;
                }
                for (int i = nr1; i < nr2; i++)
                {
                    if (imprumut != 0)
                    {
                        if (numar2[i] != 0)
                        {
                            numar2[i] -= imprumut;
                            imprumut = 0;
                        }
                        else
                        {
                            numar2[i] = 10 - imprumut;
                            imprumut = 1;
                        }
                    }
                    v[i] = numar2[i];
                    pos = i;
                }
                writeNEGNumber(v, pos);
            }
            if (bigger == 0)
            {
                Console.WriteLine("v = 0");
            }
        }

        /// <summary>
        /// Afisarea numarului final dupa scadere (numar negativ)
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        private static void writeNEGNumber(int[] v, int pos)
        {
            Console.Write("v = -");
            for (int i = pos; i >= 0; i--)
            {
                Console.Write(v[i]);

            }
            Console.WriteLine();
        }
        
        /// <summary>
        /// Functia aduna cele doua numere
        /// </summary>
        /// <param name="numar1"></param>
        /// <param name="numar2"></param>
        /// <param name="bigger"></param>
        private static void Adunare(int[] numar1, int[] numar2, int bigger)
        {
            int[] v = new int[numar1.Length + numar2.Length];
            int nr1 = numar1.Length;
            int nr2 = numar2.Length;
            int pos = 0;
            int rest = 0;

            if (bigger == 1)
            {
                for (int j = 0; j < nr2; j++)
                {
                    v[j] += rest;
                    v[j] += (numar1[j] + numar2[j]) % 10;
                    rest = (numar1[j] + numar2[j]) / 10;
                    pos = j;
                }
                for (int i = nr2; i < nr1; i++)
                {
                    v[i] += rest;
                    rest = (v[i] + numar1[i]) / 10;
                    v[i] = (v[i] + numar1[i]) % 10;
                    pos = i;

                }
                if (rest != 0)
                {
                    pos = nr1;
                    v[nr1] += rest;
                }
            }
            if (bigger == 2)
            {
                for (int j = 0; j < nr1; j++)
                {
                    v[j] += rest;
                    v[j] += (numar1[j] + numar2[j]) % 10;
                    rest = (numar1[j] + numar2[j]) / 10;
                    pos = j;
                }
                for (int i = nr1; i < nr2; i++)
                {
                    v[i] += rest;
                    rest = (v[i] + numar2[i]) / 10;
                    v[i] = (v[i] + numar2[i]) % 10;
                    pos = i;

                }
                if (rest != 0)
                {
                    pos = nr2;
                    v[nr2] += rest;
                }
            }
            writeNumber(v, pos);
        }

        /// <summary>
        /// Afisarea numarului final dupa operatie
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        private static void writeNumber(int[] v, int pos)
        {
            Console.Write("v = ");
            for (int i = pos; i >= 0; i--)
            {
                Console.Write(v[i]);

            }
            Console.WriteLine();
        }

        /// <summary>
        /// Se creeaza vectorul (numarul) prin separarea char - urilor din stringul introdus de la tastatura
        /// </summary>
        /// <returns></returns>
        private static int[] createNumber()
        {
            Console.Write("introduceti numarul: ");
            string line = Console.ReadLine();
            int n = line.Length;
            int[] v = new int[n];
            int j = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                j++;
                v[i] = line[j] - 48;
            }
            return v;
        }
    }
}
