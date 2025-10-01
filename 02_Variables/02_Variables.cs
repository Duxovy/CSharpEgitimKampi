using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler

            //double number;
            //number= 12.55;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 15.55;
            //orangePrice = 12.99;
            //strawberryPrice = 20;
            //potatoPrice = 5.25;
            //tomatoPrice = 8.75;

            //Console.WriteLine("Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("***************************");

            //double appleKg, orangeKg, strawberryKg, potatoKg, tomatoKg;

            //appleKg = 2.55;
            //orangeKg = 3.25;
            //strawberryKg = 0.75;
            //potatoKg = 4.509;
            //tomatoKg = 1.255;

            //Console.WriteLine("Alınan Elma Miktarı: " + appleKg + " Kg");
            //Console.WriteLine("Alınan Portakal Miktarı: " + orangeKg + " Kg");
            //Console.WriteLine("Alınan Çilek Miktarı: " + strawberryKg + " Kg");
            //Console.WriteLine("Alınan Patates Miktarı: " + potatoKg + " Kg");
            //Console.WriteLine("Alınan Domates Miktarı: " + tomatoKg + " Kg");
            //Console.WriteLine("***************************");

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            //appleTotalPrice = applePrice * appleKg;
            //orangeTotalPrice = orangePrice * orangeKg;
            //strawberryTotalPrice = strawberryPrice * strawberryKg;
            //potatoTotalPrice = potatoPrice * potatoKg;
            //tomatoTotalPrice = tomatoPrice * tomatoKg;

            //Console.WriteLine("Elma Toplam Fiyatı: " + appleTotalPrice + " TL");
            //Console.WriteLine("Portakal Toplam Fiyatı: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Çilek Toplam Fiyatı: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Patates Toplam Fiyatı: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Domates Toplam Fiyatı: " + tomatoTotalPrice + " TL");
            //Console.WriteLine("---------------------------");

            //double totalPrice;

            //totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("-->Genel Toplam: " + totalPrice + " TL");

            #endregion

            #region Char Degiskenler            
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine("*********************************************");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu İli: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu İlçesi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine("*********************************************");
            //Console.WriteLine("**** Yolcu Bilgileri ****");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yaş: " + passengerAge);
            //Console.WriteLine("TC Kimlik No: " + passengerIdentityNumber);
            //Console.WriteLine("İkametgah: " + passengerCity + "/" + passengerDistrict);
            //Console.WriteLine("*********************************************");
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 25000;
            //chairPrice = 5000;
            //tvPrice = 15000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("************************************************");
            //int totalShoesPrice, totalComputerPrice, totalChairPrice, totalTvPrice;
            //totalShoesPrice = shoesPrice * shoesCount;
            //Console.WriteLine("Ayakkabı Toplam Tutar: " + totalShoesPrice + " TL");
            //totalComputerPrice = computerPrice * computerCount;
            //Console.WriteLine("Bilgisayar Toplam Tutar: " + totalComputerPrice + " TL");
            //totalChairPrice = chairPrice * chairCount;
            //Console.WriteLine("Sandalye Toplam Tutar: " + totalChairPrice + " TL");
            //totalTvPrice = tvPrice * tvCount;
            //Console.WriteLine("Televizyon Toplam Tutar: " + totalTvPrice + " TL");
            //Console.WriteLine("************************************************");
            //int generalTotalPrice;
            //generalTotalPrice = totalShoesPrice + totalComputerPrice + totalChairPrice + totalTvPrice;
            //Console.WriteLine("---> Genel Toplam Tutar: " + generalTotalPrice + " TL");
            #endregion

            #region Klavyeden Ondalıklı Sayı işlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("---> Ortalamanız: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyetinizi Giriniz (E/K) : ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Cinsiyetiniz: " + gender);
            #endregion
        }
    }
}
