using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yıldız oluşturma başlangıç

            //Alt alta 10 tane yıldız

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            //Yan yana 10 tane yıldız

            //for (int i = 1; i <= 10 ; i++)
            //{
            //    Console.Write("*");
            //}

            //Alt alta 10 tane yıldız her satırda 10 tane yıldız

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            //Dik Üçgen

            for (int i = 1; i <= 5; i++)
            {
               for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }







            #endregion
            Console.Read();
        }
    }
}
