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
            Console.WriteLine();
            Console.WriteLine("Alegeti operatia: 1.adunare 2.scadere 3.modulo 4.impartire 5.inmultire");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    Adunare();
                    break;
                case 2:
                    Scadere();
                    break;
                case 3:
                    Modulo();
                    break;
                case 4:
                    Impartire();
                    break;
                case 5:
                    Inmultire();
                    break;

                default:
                    Console.WriteLine("error");
                    break;

            }
        }

        private static void Inmultire()
        {

        }

        private static void Impartire()
        {

        }

        private static void Modulo()
        {

        }

        private static void Scadere()
        {

        }

        private static void Adunare()
        {

        }

        private static int[] createNumber()
        {
            Console.Write("introduceti numarul: ");
            string line = Console.ReadLine();
            int n = line.Length;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = line[i] -48;
            }
            return v;
        }
    }
}
