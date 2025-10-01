using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //For(x;y;z)
            //x: Başlangıç değeri
            //y: Bitiş değeri
            //z: Artış-Azalış miktarı

            //int i;
            //for(i=1;i<=5;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3;i<=50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları
            //for(int i=0;i<=100;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1;i<= 10;i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for(int i=1;i<=20;i++)
            //{
            //    if(i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine("  " + i);
            //    }
            //}
            //Console.WriteLine("+");
            //Console.WriteLine("-----");
            //Console.WriteLine(" " + totalValue);

            //int count = 0;
            //for (int i=1;i<=50;i++)
            //{
            //    if(i%7==0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----");
            //Console.WriteLine(count + " tane");

            //Console.WriteLine("Başlangıçta 1 Bakteri");
            //int bakteriSayisi = 1;
            //for(int i=1;i<=24;i++)
            //{
            //    bakteriSayisi *= 2;
            //    Console.WriteLine(i + " Saat Sonra: " + bakteriSayisi + " Bakteri");
            //}
            //Console.WriteLine("Toplam Bakteri Sayısı: " + bakteriSayisi + " Bakteri");
            #endregion

            #region While Döngüsü
            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    i++;
            //    if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int i = 1;
            //int totalValue = 0;
            //while(i<=10)
            //{
            //    totalValue += i;
            //    i++;
            //}
            //Console.WriteLine(totalValue);
            #endregion

            #region Örnek Sınav Sorusu
            //Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz");
            //int girilenSayi = int.Parse(Console.ReadLine());
            //int sayi1 = girilenSayi;
            //int sayi2 = girilenSayi;
            //if (Convert.ToString(girilenSayi).Length==3)
            //{
            //    sayi1 /= 100;
            //    Console.WriteLine("Girdiğiniz sayının yüzler basamağı: " + sayi1);
            //    while (Convert.ToString(sayi2).Length == 3 & sayi2 >=0)
            //    {
            //        sayi2 -= 100;
            //    }
            //    sayi2 /= 10;
            //    Console.WriteLine("Girdiğiniz sayının onlar basamağı: " + sayi2);
            //    while ((Convert.ToString(girilenSayi).Length == 2 | Convert.ToString(girilenSayi).Length == 3) & girilenSayi>=0)
            //    {
            //        girilenSayi -= 10;
            //    }
            //    Console.WriteLine("Girdiğiniz sayının birler basamağı: " + girilenSayi);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız. Lütfen 3 basamaklı bir sayı giriniz.");
            //}
            //Console.WriteLine(sayi1 + sayi2 + girilenSayi);
            #endregion
        }
    }
}
