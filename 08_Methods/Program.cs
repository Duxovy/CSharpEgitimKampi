using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            // Bir yapinin metot olarak algilanmasi icin sonuna parantez acilip kapatilmasi gerekiyor ==> ...()
            // C# ta bir metotdun aciklamasina bakildiginda (mouse u ustune getirdiginde) gozuken aciklamanin basinda (en solunda) mor renkli bir kup gozukur.
            // 1) Geriye deger dondurmeyen metotlar (void metotlar)

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali YILDIZ");
            //    Console.WriteLine("Zeynep YILDIZ");
            //    Console.WriteLine("Hakan ORMAN");
            //    Console.WriteLine("Merve Fidan");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Geriye Deger Dondurmeyen String Parametreli Metotlar
            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Customer: " + name + " " + surName);
            //}
            //CustomerCard("Ahmet","Yildirim");
            //CustomerCard("Kerem", "FURUNCU");
            #endregion

            #region Geriye Deger Dondurmeyen Integer Parametreli Metotlar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(13, 32, 61);
            #endregion

            #region Geriye Deger Donduren Metotlar
            //string StudentCard()
            //{
            //    string name = "Egemen";
            //    string surname = "Bey";
            //    return name+" "+surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Deger Donduren String Parametreli Metotlar
            //string CountryCard(string countryName, string capitalName)
            //{
            //    string cardInfo = "Country: " + countryName + " / Capital: " + capitalName;
            //    return cardInfo;
            //}
            //string x, y;
            //Console.Write("Please Enter Your Country Name: ");
            //x = Console.ReadLine();
            //Console.Write("Please Enter Your Country's Capital: ");
            //y = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y));
            #endregion

            #region Geriye Deger Donduren Integer Parametreli Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(41, 61));
            //Console.WriteLine(Sum(6, 34));
            #endregion

            #region Ornek Uygulama
            string ExamResult(string student, double vize, double final)
            {
                double average = (vize * 4 + final * 6) / 10;
                if(average>=50)
                {
                    return student + " Adli Ogrenci Sinavi Gecti / Ortalamasi="+average;
                }
                else
                {
                    return student + " Adli Ogrenci Sinavdan Kaldi / Ortalamasi="+average;
                }
            }
            Console.WriteLine(ExamResult("Kerem", 23,76));
            #endregion
        }
    }
}
