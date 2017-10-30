using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArraysAndAssignment
{
    class ArrayAssignment
    {
        static void Main(string[] args)
        {
            #region 2.a
            ///*-------------5 elemanlı string dizisine döngüsüz atama yapma--------------*/

            //string[] stringArray = new string[5];

            //Console.WriteLine("İlk Metni giriniz");
            //stringArray[0]=Console.ReadLine();

            //Console.WriteLine("İkinci Metni giriniz");
            //stringArray[1] = Console.ReadLine();

            //Console.WriteLine("Üçüncü Metni giriniz");
            //stringArray[2] = Console.ReadLine();

            //Console.WriteLine("Dördüncü Metni giriniz");
            //stringArray[3] = Console.ReadLine();

            //Console.WriteLine("Beşinci Metni giriniz");
            //stringArray[4] = Console.ReadLine();

            #endregion

            #region 2.b
            ///*-------5 elemanlı bir int dizisi oluşturup klavyeden 5 adet girilecek değeri dizi elemanlarına atayın--------*/
            ///*-------Eğer kullanıcı hatalı giriş yaparsa uyarı döndürülecek ve giriş işlemi tekrar istenecek-------*/
            ///
            //int[] intArray=new int[5];
            //int value;

            ///*-------Sayi Alimina Başla------*/
            //Console.WriteLine("İlk Sayiyi Giriniz...");
            ////---------Eleman Girişi Hatalıysa Kullanıcıyı Uyar-----------
            //while (!(int.TryParse(Console.ReadLine(), out value)))
            //{
            //    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz...");
            //}
            //intArray[0] = value;


            //Console.WriteLine("İkinci Sayiyi Giriniz...");
            //while (!(int.TryParse(Console.ReadLine(), out value)))
            //{
            //    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz...");
            //}
            //intArray[1] = value;


            //Console.WriteLine("Üçüncü Sayiyi Giriniz...");
            //while (!(int.TryParse(Console.ReadLine(), out value)))
            //{
            //    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz...");
            //}
            //intArray[2] = value;


            //Console.WriteLine("Dördüncü Sayiyi Giriniz...");
            //while (!(int.TryParse(Console.ReadLine(), out value)))
            //{
            //    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz...");
            //}
            //intArray[3] = value;

            //Console.WriteLine("Beşinci Sayiyi Giriniz...");
            //while (!(int.TryParse(Console.ReadLine(), out value)))
            //{
            //    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz...");
            //}
            //intArray[4] = value;

            ////----Diziyi Yazdırma işlemi------
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            #endregion

            #region 2.c
            ///*Kullanıcıdan alınan dizi boyutuna göre dizi oluşturulacaktır, eğer kullanıcı 0 veya yanlış değer girerse,
            ///giriş tekrarlanacak,boyut girildikten sonra sırasıyla diziye elemanlar girilecektir...*/

            // /*
            //  * Kullanıcıdan dizinin boyutu istenecektir.Kullanıcı sayısal olarak 
            //  * dizi boyutunu girdikten sonra bu boyutta yeni string dizisi oluşturulacaktır.
            //  * Eğer kullanıcı dizi boyutu için 0 veya yanlış bir ifade girdiyse giriş tekrar istenecektir.
            //  * Dizi oluşturulduktan sonra kullanıcıdan dizi boyutu kadar sırasıyla giriiş istencektir ve dizi
            //  * elemanlarına atanacak....
            //  */
            // int arrayLength;
            // string consoleValue;

            // //--------Dizi için eleman sayısı girişi---------
            // Console.WriteLine("Dizinin Boyutunu Giriniz: ");
            // consoleValue=Console.ReadLine();
            // bool assignment=(int.TryParse(consoleValue, out arrayLength));
            // while ((consoleValue=="0" && assignment) || (!assignment))
            // {
            //     if (arrayLength == 0)
            //     {
            //         Console.WriteLine("Lütfen tam sayi veya 0'dan farklı bir deger giriniz...");
            //         arrayLength--;
            //     }

            //     consoleValue = Console.ReadLine();
            //     assignment = (int.TryParse(consoleValue, out arrayLength));
            // }
            // //-------------Girilen boyuta göre dizinin oluşturulması-----------
            //string[] myArray = new string[arrayLength];



            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    Console.WriteLine("{0}. Sayiyi Giriniz...",i+1);
            //    consoleValue = Console.ReadLine();
            //    myArray[i] = consoleValue;
            //}

            ////----Diziyi Yazdırma işlemi------
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            #endregion

            #region 2.d
            ///*yine dizi boyutu kullanıcıdan alınacak ve integer dizisi oluşturulacaktır.Daha sonra girilecek elemanlar da
            ///kontrol edilerek alınacaktır,integer olmayan değer girilirse giriş tekrarlanacaktır...*/

            ///*
            // * Dizinin boyutunu kullanıcı girecek, Eğer kullanıcı dizi boyutu için 0 veya
            // * yanlış bir ifade girildiyse giriş tekrar istenecektir. Dizi oluşturulduktan sonra
            // * kullanıcıdan dizi boyutu kadar sırasıyla giriş istenecektir ve dizi elemanlarına atacak.
            // * Eğer kullanıcı hatalı giriş yaparsa uyarı döndürülecek ve giriş tekrar istenecek.
            // */
            //int arrayLength, value;
            //string consoleValue;

            ////--------Dizi için eleman sayısı girişi---------
            //Console.WriteLine("Dizinin Boyutunu Giriniz: ");
            //consoleValue = Console.ReadLine();
            //bool assignment = (int.TryParse(consoleValue, out arrayLength));
            //while ((consoleValue == "0" && assignment) || (!assignment))
            //{
            //    if (arrayLength == 0)
            //    {
            //        Console.WriteLine("Lütfen tam sayi veya 0'dan farklı bir deger giriniz...");
            //        arrayLength--;
            //    }

            //    consoleValue = Console.ReadLine();
            //    assignment = (int.TryParse(consoleValue, out arrayLength));
            //}
            ////-------------Girilen boyuta göre dizinin oluşturulması-----------
            //int[] myArray = new int[arrayLength];



            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("{0}. Sayiyi Giriniz...", i + 1);
            //    while (!(int.TryParse(Console.ReadLine(), out value)))
            //    {
            //        Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz...");
            //    }
            //    myArray[i] = value;
            //}



            ////----Diziyi Yazdırma işlemi------
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}


            #endregion
            Console.ReadLine();


        }
    }
}
