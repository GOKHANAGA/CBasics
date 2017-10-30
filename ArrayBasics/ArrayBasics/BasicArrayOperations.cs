using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasics
{
    class BasicArrayOperations
    {
        static void Main(string[] args)
        {
            int[] dizi=new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = i+1;
            }

            #region 1.a
            ///*-----Bir dizinin elemanlarını alt alta yazdıran program---------------*/
            ///
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            #endregion

            #region 1.b
            ///*----------Bir diziyi tersten alt alta yazdıran program-----------------*/

            //int temp;
            //for (int i = (dizi.Length - 1), j = 0; i >= (dizi.Length) / 2 && j < (dizi.Length) / 2; i--, j++)
            //{
            //    temp = dizi[i];
            //    dizi[i] = dizi[j];
            //    dizi[j] = temp;
            //}
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            #endregion

            #region 1.c
            ///*-----------Dizi elemanlarını arada - ile yan yana yazdıran program----------------*/
            //
            //for (int i = 0; i < (dizi.Length)-1; i++)
            //{
            //    Console.Write(dizi[i]+"-");
            //}
            //Console.WriteLine(dizi[dizi.Length - 1]);
            #endregion

            #region 1.d
            ///*----------Dizi elemanlarını kolonda sırayla ekrana yazdıran program---------*/

            //Console.Write("***1***\t\t***2***\n");
            //int colCount=0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (colCount == 0)
            //    {
            //        Console.Write("   {0}",dizi[i]);
            //        colCount++;
            //    }
            //    else
            //    {
            //        Console.Write("\t\t   {0}\n", dizi[i]);
            //        colCount = 0;
            //    }
            //}
            #endregion

            #region 1.e
            ///*------------Bir dizinin elemanlarını sıralı şekilde sağdan sola 3 kolonda yazdıran program-------*/

            //Console.Write("***3***\t\t***2***\t\t***1***\n");
            //int colCount = 0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (colCount == 0)
            //    {
            //        Console.Write("\t\t\t\t   {0}", dizi[i]);
            //        colCount++;
            //    }
            //    else if (colCount == 1)
            //    {
            //        Console.Write("\r");
            //        Console.Write("\t\t   {0}", dizi[i]);
            //        colCount++;
            //    }
            //    else
            //    {
            //        Console.Write("\r");
            //        Console.Write("   {0}\n", dizi[i]);
            //        colCount = 0;
            //    }
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
