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
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            //int[] numbers=new int[10];
            //numbers[0] = 23;
            //numbers[1] = 635;
            //numbers[2] = 3;
            //numbers[5] = 42;
            //numbers[8] = 896;
            //numbers[6] = 0;
            //Console.WriteLine(numbers[4]);

            //string[] cities = { "Prag", "Roma", "Vancouver", "İstanbul", "Bursa" };
            //Console.WriteLine(cities[3]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] color = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for(int i=0; i<color.Length; i++)
            //{
            //    Console.WriteLine(color[i]);
            //}

            //int[] number = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for(int i=0; i<number.Length; i++)
            //{
            //    if (number[i]%3==0)
            //    {
            //        Console.WriteLine("i+1" + number[i]);
            //    }
            //}

            //char[] symbol = { 'A', 'b', '*', '-' };
            //for(int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

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

            //string[] persons = { "ali", "ahmet", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i=0; i< numbers.Length; i++)
            //{
            //    Console.WriteLine("i+1" + numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotları
            //string[] customers = { "ali", "ayşegül", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "çınar");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " // Dizinin En Küçük Elemanı: " + numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for(int i=0;i<cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine("------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    sum=sum + numbers[i];
            //}
            //Console.WriteLine(sum);

            Console.WriteLine("Kaç tane sayı girişi yapmak istiyorsunuz?");
            int a = int.Parse(Console.ReadLine());
            int[] numbers = new int[a];
            int b;            
            int sumB = 0;
            int sumS = 0;
            int[] doubleNumbers = new int[a];
            int[] singleNumbers = new int[a];
            for (int i=0; i<a; i++)
            {
                Console.WriteLine($"Lütfen {i+1}.sayıyı giriniz: ");
                b = int.Parse(Console.ReadLine());                 
                numbers[i] = b;
                if(b%2==0)
                {                    
                    doubleNumbers[i] = b;                    
                }
                if (b % 2 == 1)
                {
                    singleNumbers[i] = b;
                }                
            }            
            for (int j=0; j<a; j++)
            {
                sumB = sumB + doubleNumbers[j];
            }
            if(sumB>0)
            {
                Console.WriteLine("Giriş yaptığınız çift sayılar: ");
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine(doubleNumbers[i]);
                }
            }            
            for(int k=0;k<a;k++)
            {
                sumS = sumS + singleNumbers[k];
            }
            if(sumS>0)
            {
                Console.WriteLine("Giriş yaptığınız tek sayılar: ");
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine(singleNumbers[i]);
                }
            }            
            #endregion
        }
    }
}
