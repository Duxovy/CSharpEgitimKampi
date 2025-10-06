using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop
            //Foreach(1;2;3;4)
            //1:variable type
            //2:variable name
            //3:In
            //4:Liste, Kolesksiyon veya Dizi adi

            //string[] cities = { "istanbul", "Ankara", "Bursa", "Edirne", "Vancouver", "Seul", "Berlin" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach(int number in numbers)
            //{
            //    if(number%2==0)
            //    {
            //        Console.WriteLine(number + " is a double number");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number + " is a double number");
            //    }
            //}   

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total = total + i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,4,5,8                
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}            
            #endregion

            #region EX/Exam System App     
            //Console.Write("Please Enter Students Count: ");
            //int studentsCount = int.Parse(Console.ReadLine());
            //string[] studentsName = new string[studentsCount];
            //for (int i = 0; i < studentsCount; i++)
            //{
            //    Console.Write("Please Enter " + (i + 1) + ". Student Name: ");
            //    studentsName[i] = Console.ReadLine();
            //}
            //double[] vize = new double[studentsCount];
            //for (int i = 0; i < studentsCount; i++)
            //{
            //    Console.Write("Please Enter " + studentsName[i] + "`s Vize Result: ");
            //    vize[i] = double.Parse(Console.ReadLine());
            //    if (vize[i]>100 | vize[i]<0)
            //    {
            //        Console.WriteLine("Wrong Value!");
            //        i--;
            //    }
            //}            
            //double[] final = new double[studentsCount];
            //for (int i = 0; i < studentsCount; i++)
            //{
            //    Console.Write("Please Enter " + studentsName[i] + "`s Final Result: ");
            //    final[i] = double.Parse(Console.ReadLine());
            //    if (final[i] > 100 | final[i]<0)
            //    {
            //        Console.WriteLine("Wrong Value!");
            //        i--;
            //    }
            //}
            //double[] examsAverage = new double[studentsCount];
            //for (int i = 0; i < studentsCount; i++)
            //{
            //    examsAverage[i] = (vize[i] * 4 + final[i] * 6) / 10;
            //    Console.WriteLine(studentsName[i] + "`s Exams Average: " + examsAverage[i]);
            //}
            //Console.WriteLine("---------------------------------------------------");
            //for (int i = 0; i < studentsCount; i++)
            //{
            //    Console.WriteLine("Student Name: " + studentsName[i]);
            //    Console.WriteLine("Vize Result: " + vize[i]);
            //    Console.WriteLine("Final Result: " + final[i]);
            //    Console.WriteLine("Exams Average: " + (vize[i] * 4 + final[i] * 6) / 10);
            //    Console.WriteLine("---------------------------------------------------");
            //}
            //double examsAveragesTotal = 0;
            //foreach (double i in examsAverage)
            //{
            //    examsAveragesTotal = examsAveragesTotal + i;
            //}
            //Console.WriteLine("All Students Exam Average: " + examsAveragesTotal / studentsCount);
            #endregion
        }
    }
}
