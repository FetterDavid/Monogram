using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] duplaBetuk = new string[] {"Sz","Zs","Ty","Ly","Ny","Gy","Cs","Dz","Dzs","Dr."};
            int i;

            Console.Write("Név: ");
            string nev = Console.ReadLine().ToUpper();
            string[] nevek = nev.Split(' ');
            Console.Write("Monogram: ");

            for (int y = 0; y < nevek.Length; y++)
            {
                for (i = 0; i < duplaBetuk.Length; i++)
                {
                    if (nevek[y].StartsWith(duplaBetuk[i].ToUpper()))
                    {
                        Console.Write(duplaBetuk[i]);
                        break;
                    }
                }
                if (i == duplaBetuk.Length && nevek[y].Length>0) Console.Write(nevek[y][0]);
            }
            
            Console.ReadLine();
        }
    }
}