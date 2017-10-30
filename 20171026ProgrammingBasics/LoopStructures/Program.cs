using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            /*
             * a. Kullanıcıdan istenecek 10 adet sayının içerisinde en büyük ve en küçük olanları tespit edip ekrana
                    sonucu yazan programı geliştirin. Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü
                    yapılmalıdır. Kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı
                    döndürülecek ve girilen değer geçersiz sayılacaktır.
             */

            int lowest = 2000000000, highest = -2000000000, value;
            string consoleValue;

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("Bir sayi giriniz: ");
                consoleValue = Console.ReadLine();
                if (!(int.TryParse(consoleValue, out value)))
                {
                    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz: ");
                    continue;
                }
                value = int.Parse(consoleValue);
                if (value < lowest)
                {
                    lowest = value;
                }
                else if (value > highest)
                {
                    highest = value;
                }

                counter++;
            }
            Console.WriteLine("en büyük" + highest);
            Console.WriteLine("en küçük" + lowest);
            Console.ReadLine();

            #endregion

            #region b
            /*
             * Kullanıcıdan istenecek belirsiz miktardaki sayı içerisinden en büyük ve en küçük olanları tespit
                edip ekrana sonucu yazan programı geliştirin. Kullanıcıdan toplamda kaç adet sayı alınacağı
                kullanıcıya bağlı olacak, kullanıcı “end” yazdığında sayı alma işlemi durdurulacak ve sonuçlar ekrana
                yazdırılacak. Ancak kullanıcı minimum 2 sayı yazmak zorundadır. Kullanıcının yazdığı değerlerin sayı
                olup olmadığının kontrolü yapılmalıdır. Kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”,
                “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
             */


            int lowest1 = 2000000000, highest1 = -2000000000, value1, limitCounter = 0;
            string consoleValue1 = "";

            while (consoleValue1 != "exit")
            {
                Console.WriteLine("Bir sayi giriniz: ");
                consoleValue1 = Console.ReadLine();
                if (consoleValue1 == "end" && limitCounter >= 2)
                {
                    Console.WriteLine("en büyük girilen deger: " + highest1);
                    Console.WriteLine("en küçük girilen deger: " + lowest1);
                    continue;
                }
                else if (consoleValue1 == "end" && limitCounter < 2)
                {
                    Console.WriteLine("Lütfen en az iki sayi girdikten sonra \"end\" işlemini yapmayı deneyin");
                    Console.WriteLine("Çıkış için \"exit\" yazınız: ");
                    continue;
                }

                if (!(int.TryParse(consoleValue1, out value1)) && (consoleValue1 != "exit" || consoleValue1 != "Exit"))
                {
                    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz: ");
                    continue;
                }

                value1 = int.Parse(consoleValue1);
                if (value1 < lowest1)
                {
                    lowest1 = value1;
                }
                else if (value1 > highest1)
                {
                    highest1 = value1;
                }

                limitCounter++;
            }
            #endregion

            #region c
            int numToCalc, numToCalc1, lessCounter = 0, greaterCounter = 0;
            string consoleValuec = "";



            while (consoleValuec != "exit")
            {
                Console.WriteLine("İlk Degerinizi giriniz: ");
                consoleValuec = Console.ReadLine();
                if (!(int.TryParse(consoleValuec, out numToCalc)) && (consoleValuec != "exit" || consoleValuec != "Exit"))
                {
                    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz: ");
                    continue;
                }
                numToCalc = Convert.ToInt32(consoleValuec);



                Console.WriteLine("İkinci Degerinizi giriniz: ");
                consoleValuec = Console.ReadLine();
                if (!(int.TryParse(consoleValuec, out numToCalc1)) && (consoleValuec != "exit" || consoleValuec != "Exit"))
                {
                    Console.WriteLine("Lütfen Tam Sayi Degeri Giriniz: ");
                    continue;
                }
                numToCalc1 = Convert.ToInt32(consoleValuec);

                if (numToCalc < numToCalc1)
                {
                    lessCounter = numToCalc;
                    greaterCounter = numToCalc1;
                }
                else
                {
                    lessCounter = numToCalc1;
                    greaterCounter = numToCalc;
                }
                while (lessCounter < greaterCounter - 1)
                {
                    lessCounter++;
                    Console.WriteLine("Sayi: {0} - Karesi: {1} - Küpü: {2}", lessCounter, (lessCounter * lessCounter), (lessCounter * lessCounter * lessCounter));
                }


            }
            #endregion
        }
    }
}
