using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //()
            //Geriye değer döndürmeyen metotlar
            //Customer -->Listele,ekle,sil,güncelle

            //1

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("AyşeYıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();

            //2

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();








            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //1

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Nurullah Avcı");

            //2

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}

            //CustomerCard("Nurullah", "Avcı");
            //CustomerCard("Tahir Ekrem", "Koru");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);






            #endregion

            #region Geriye Değer Döndüren Metotlar

            //1

            //string CustomerName()
            //{
            //    return "Ali Yıldız";
            //}

            //Console.WriteLine(CustomerName());

            //2

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren  Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{

            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: "
            //        + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Griniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{

            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(3, 4));




            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti" + " Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci dersten kaldı" + " Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 23, 45, 90));
            //Console.WriteLine(ExamResult("Ayşe", 50, 50, 50));

            #endregion
            //Console.Read();
        }
    }
}
