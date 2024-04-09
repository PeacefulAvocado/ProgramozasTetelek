using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progtetelek
{
    internal class tetelek
    {
        static bool isKituno(int a)
        {
            return a == 5;
        }

        static bool isOszto(int a, int b)
        {
            return a % b == 0;
        }

        public float Sorozatszamitas(int[] T) //átlag
        {
            float S = 0;
            int N = T.Length;
            for (int i = 0; i < N; i++)
            {
                S += T[i];
            }
            return S/N;
        }

        public bool Eldontes(int[] X) { //kitunoe
        int i = 0;
        int N = X.Length;
        while (i < N && isKituno(X[i]))
            {
                i++;
            }
        return i == N;
        } 

        public int Kivalasztas(int X)
        {
            int i = 2;
            int N = X;
            while(i <= N && !isOszto(X,i))
            {
                i++;
            }
            return i;
        }

        public int LinearisKereses(int[] T, int keresett)
        {
            int i = 0;
            int N = T.Length;
            while (i < N && T[i] != keresett)
            {
                i++;
            }
            bool van = i < N;
            if (van)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        public bool Mgh(string character)
        {
            string[] mgh = { "a", "á", "e", "é", "i", "í", "u", "ú", "ü", "ű", "ö", "ő" };
            return mgh.Contains(character);
        }

        public int Megszamolas(string T)
        {
            int db = 0;
            int N = T.Length;
            for (int i = 0; i < N; i++)
            {
                if (Mgh(T[i].ToString()))
                {
                    db++;
                }
            }
            return db;
        }

        public int Maximumkivalasztas(int[] T)
        {
            int max = 0;
            int N = T.Length;
            for (int i = 1; i < N; i++)
            {
                if (T[i] > T[max])
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
