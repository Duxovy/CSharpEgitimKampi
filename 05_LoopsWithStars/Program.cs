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
            #region Alt alta 10 tane yıldız oluşturma
            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan yana 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region Alt alta 10 tane yıldız oluşturma, her satırda 10 tane yıldız olsun
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region [Dik Üçgen] Alt alta 10 tane yıldız oluşturma, her satırda satır numarası kadar yıldız olsun 
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i-1; j++)
            //    {
            //        Console.Write("*");
            //    }
            // Console.WriteLine("*");
            //}
            #endregion

            #region [Ters Dik Üçgen] Alt alta 10 tane yıldız oluşturma, ilk satırda 10 tane, son satırda 1 tane yıldız olacak şekilde azalsın 
            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Alt alta dik üçgen ve ters dik üçgen oluşturma
            //for(int i=1;i<=10;i++)
            //{
            //    for (int j=1;j<=i-1;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}
            //for(int i=9;i>=1;i--)
            //{
            //    for(int j=1;j<=i-1;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Baklava Dilimi
            int n = -2;
            for (int i=4;i>=0;i--)
            {
                for(int j=i-1;j>=0;j--)
                {
                    Console.Write(" ");
                }                
                n = n + 2;
                for (int k=1;k<=n;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            int m = 9;
            for(int x=1;x<=4;x++)
            {
                for(int y=1;y<=x;y++)
                {
                    Console.Write(" ");
                }
                m = m - 2;
                for(int z=1;z<=m-1;z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            #endregion
        }
    }
}
