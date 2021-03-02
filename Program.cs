using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_04_03___Największa_suma_cyfr
{
    class Program
    {
        public static int najwieksza(int a, int b)
        {
            int najwieksza = 0;
            int indeks = 0;
            int[] liczba;
            int suma = 0;

            for(int i = a; i <= b; i++)
            {
                char[] help1 = i.ToString().ToCharArray();//tworzenie tablicy charow z inta(iteracja)
                liczba= new int[help1.Length];//tworzenie tablicy dlugosci tablicy charow
                for (int j = 0; j < help1.Length; j++)// przepisywanie charow na inty
                {
                    liczba[j] = int.Parse(help1[j].ToString());// przepisywanie charow na inty
                //    Console.WriteLine(liczba[j]);
                }
                for(int k = 0; k < liczba.Length; k++)
                {
                    suma += liczba[k];//sumowanie cyfr w liczbie
                }
              // Console.WriteLine("Liczba: " + i + "Suma =" + suma);
                if (suma >= najwieksza)// sprawdza czy suma cyfr z obecnej liczby jest wieksza badz rowna najwiekszej sumie dotychczasowej
                {
                    najwieksza = suma;
                    suma = 0;
                    indeks = i;// liczba o najwiekszej dotychczas sumie cyfr
                }
                else
                {
                    suma = 0;
                }
              
            }

            return indeks;
        }
        static void Main(string[] args)
        {
            int t = 0;
            t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string dane = Console.ReadLine();
                string[] daneStr = dane.Split(' ');
                int a = int.Parse(daneStr[0]);
                int b = int.Parse(daneStr[1]);
                if (b < a)
                {
                    Console.WriteLine("Wprowadzono niepoprawny zakres!");
                }
                else
                {
                    Console.WriteLine(najwieksza(a, b));
                    Console.ReadKey();
                }
            }
        }
    }
}
