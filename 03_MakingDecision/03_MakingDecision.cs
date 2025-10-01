using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //} 
            //else
            //{
            //    Console.Write("Veriler Doğrulanamadı");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //double exam1, exam2, average;
            //string result = "Geçersiz Not";
            //Console.Write("Vize Notunuzu Girin: ");
            //exam1 = double.Parse(Console.ReadLine());            
            //Console.Write("Final Notunuzu Girin: ");
            //exam2 = double.Parse(Console.ReadLine());            
            //average = (4 * exam1 + 6 * exam2) / 10;
            //Console.WriteLine("Ortalamanız: " + average);
            //if (average >= 0 & average < 30)
            //{
            //    result = "FF ile Kaldınız";
            //}
            //if (average >= 30 & average < 40)
            //{
            //    result = "FD ile Kaldınız";
            //}
            //if (average >= 40 & average < 50)
            //{
            //    result = "DD ile Kaldınız";
            //}
            //if (average >= 50 & average < 60)
            //{
            //    result = "DC (koşullu)";
            //}
            //if (average >= 60 & average < 70)
            //{
            //    result = "CC ile Geçtiniz";
            //}
            //if (average >= 70 & average < 75)
            //{
            //    result = "CB ile Geçtiniz";
            //}
            //if (average >= 75 & average < 80)
            //{
            //    result = "BB ile Geçtiniz";
            //}
            //if (average >= 80 & average < 90)
            //{
            //    result = "BA ile Geçtiniz";
            //}
            //if (average >= 90 & average <= 100)
            //{
            //    result = "Tebrikler AA ile Geçtiniz";
            //}
            //Console.WriteLine("Notunuz: " + result);
            //double GNO;
            //if (average >= 50 & average < 60)
            //{
            //    Console.Write("Genel Not Ortalamanızı Giriniz ( [0,4] aralığında olmalı ) : ");
            //    GNO = double.Parse(Console.ReadLine());
            //    if (GNO >= 0 & GNO < 2)
            //    {
            //        result = "DC ile Kaldınız";
            //    }
            //    if (GNO >= 2 & GNO <= 4)
            //    {
            //        result = "DC ile Geçtiniz";
            //    }
            //    else
            //    {
            //        result = "Geçersiz GNO";
            //    }
            //    Console.WriteLine(result);
            //}

            //string city;
            //Console.Write("Lütfen bir şehir ismi giriniz: ");
            //city = Console.ReadLine();
            //if(city == "istanbul" | city == "izmir" | city == "bursa" | city == "adana" | city == "antalya" | city == "trabzon")
            //{
            //    Console.WriteLine("Bu şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}
            #endregion

            #region Mod Islemleri
            //int number;
            //number = 33;
            //int result = number % 7;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("Birinci sayının ikinci sayısa bölümünden kalan: " + result);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number= int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Girilen sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı Tektir.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen bir takımının baş harfini giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("******C# Eğitim Kampı Restoran ******");
            //Console.WriteLine("*************************************");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-İçecekler");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("*************************************");
            //Console.Write("Lütfen Menüden Bir Seçim Yapınız: ");
            //int firstChoice = int.Parse(Console.ReadLine());
            //if (firstChoice == 1)
            //{
            //    Console.WriteLine("Ana Yemekler :");
            //    Console.WriteLine("--------------");
            //    Console.WriteLine("1-Adana Kebap");
            //    Console.WriteLine("2-Urfa Kebap");
            //    Console.WriteLine("3-İskender");
            //    Console.WriteLine("4-Kuzu Tandır");
            //    Console.WriteLine("--------------");
            //}
            //if (firstChoice == 2)
            //{
            //    Console.WriteLine("Çorbalar :");
            //    Console.WriteLine("--------------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Tavuk Çorbası");
            //    Console.WriteLine("3-Yayla Çorbası");
            //    Console.WriteLine("4-Mantar Çorbası");
            //    Console.WriteLine("--------------");
            //}
            //if (firstChoice == 3)
            //{
            //    Console.WriteLine("İçecekler :");
            //    Console.WriteLine("--------------");
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Gazoz");
            //    Console.WriteLine("3-Çay");
            //    Console.WriteLine("4-Soda");
            //    Console.WriteLine("--------------");
            //}
            //if (firstChoice == 4)
            //{
            //    Console.WriteLine("Tatlılar :");
            //    Console.WriteLine("--------------");
            //    Console.WriteLine("1-Künefe");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Aşure");
            //    Console.WriteLine("4-Baklava");
            //    Console.WriteLine("--------------");
            //}
            //if (firstChoice != 1 & firstChoice != 2 & firstChoice != 3 & firstChoice != 4)
            //{
            //Console: Console.WriteLine("Hatalı Seçim Yaptınız!");
            //}
            #endregion

            #region Switch Case
            //Console.Write("Lütfen Bir Ay Numarası Giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Ay Numarası Girdiniz!"); break;
            //}
            //Console.WriteLine("--------------------------------------------");
            #endregion

            #region Switch Case Hesap Makinesi
            //double number1, number2, result;
            //char operation;
            //Console.Write("Lütfen Birinci Sayıyı Giriniz: ");
            //number1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            //number2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz (+, -, *, /) : ");
            //operation = char.Parse(Console.ReadLine());
            //switch (operation)
            //{
            //    case '+': result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result); break;
            //    case '-': result = number1 - number2;
            //        Console.WriteLine("Fark: " + result); break;
            //    case '*': result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result); break;
            //    case '/': result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result); break;
            //    default: Console.WriteLine("Hatalı İşlem Girdiniz!"); break;
            //}
            #endregion
        }
    }
}
