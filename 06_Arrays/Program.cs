using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // 2.4.6.8
            // sarı,mavi,turuncu,kırmızı
            //adana ankara bursa bolu
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //Örnek1

            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "yellow";
            //colors[2] = "white";
            //colors[3] = "blue";

            //Console.WriteLine(colors[2]);

            //Örnek2

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //Örnek3

            //int[] numbers = new int[10];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[7] = 8;

            //Console.WriteLine(numbers[5]);  

            //Note:Girmediğimiz boş değerler 0 ile doldurulur.

            //Örnek4

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //Örnek1

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{

            //    Console.WriteLine(colors[i]);
            //}

            //Örnek2

            //int[] numbers = { 101, 230, 30, 45, 57, 69 };

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //Örnek3

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //Örnek4

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //Örnek5

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };

            //Console.WriteLine(persons.Length);

            //Örnek6

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Örnek7

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotlar

            //1

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };

            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(index);

            //2

            //int[] numbers = { 1, 2, 10, 20, 50, 36, 48, 75 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max()) ;
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min()) ;



            #endregion

            #region Kullanıcıdan Değer Alma

            //1

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //2

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //3

            //int[] numbers = { 12, 321, 4324, 543, 64, 5656, 756, 87, 9, 80 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
          //  Console.Read();
        }
    }
}
