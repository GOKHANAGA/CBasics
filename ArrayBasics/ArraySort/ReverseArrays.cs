using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class ReverseArrays
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = new int[] { 10, 35, 12, 71, 5 };
            int[] reversedArray = new int[5];
            int temp;


            #region 3.a

            ///*
            // *------------- İkinci bir dizi yardımıyla bir dizinin elemanlarını ters sıralamak(Sayı sıralama)---------------
            // */
            //for (int i = 0; i < arrayToSort.Length; i++)
            //{
            //    for (int j = i+1; j < arrayToSort.Length; j++)
            //    {
            //        if (arrayToSort[i] > arrayToSort[j] )
            //        {
            //            temp = arrayToSort[i];
            //            arrayToSort[i] = arrayToSort[j];
            //            arrayToSort[j] = temp;
            //        }
            //    }
            //}

            //for (int i = 0; i < arrayToSort.Length;i++ )
            //{
            //    reversedArray[i] = arrayToSort[i];
            //}

            //for (int i = 0, j = arrayToSort.Length-1; i < reversedArray.Length && j >= 0; i++, j--)
            //{
            //    arrayToSort[j] = reversedArray[i];
            //}



            /*
             *---------------- İndise Göre Ters çevirme---------------
             */

            //for (int i = 0, j = reversedArray.Length - 1; i < arrayToSort.Length && j >= 0; i++, j--)
            //{
            //    reversedArray[j] = arrayToSort[i];
            //}
            //for (int i = 0; i < reversedArray.Length;i++ )
            //{
            //    arrayToSort[i] = reversedArray[i];
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(arrayToSort[i]);
            //}

            #endregion

            #region 3.b

            ///*
            // *-------------İkinci bir dizi yardımı veya hazır metot olmadan bir dizinin elemanlarını ters sıralamak
            // *(Sayı büyüklük küçüklüğüne göre)-------------
            // */

            //for (int i = 0; i < arrayToSort.Length; i++)
            //{
            //    for (int j = i + 1; j < arrayToSort.Length; j++)
            //    {
            //        if (arrayToSort[i] < arrayToSort[j])
            //        {
            //            temp = arrayToSort[i];
            //            arrayToSort[i] = arrayToSort[j];
            //            arrayToSort[j] = temp;
            //        }
            //    }
            //}


            ///*
            ///*-------------Dizi indisine göre ters çevirmek--------------
            ///*/
            //for (int i = 0; i < arrayToSort.Length; i++)
            //{
            //    for (int j = i + 1; j < arrayToSort.Length; j++)
            //    {
            //            temp = arrayToSort[i];
            //            arrayToSort[i] = arrayToSort[j];
            //            arrayToSort[j] = temp;
            //    }
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(arrayToSort[i]);
            //}

            #endregion

            Console.ReadLine();

        }
    }
}
