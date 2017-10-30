using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class PrimeArray
    {
        static void Main(string[] args)
        {

            /*
             * Sınırsız veri girişi yapılacaktır. Kontrollü alınan sayılar bir diziye atılacaktır.
             * Girilen sayıların asal sayı olup olmadığı kontrol edilip, asal sayı olanlar ekrana yazdırılacaktır.
             * Bu işlemden sonra tekrar kullanıcıdan sınırsız sayıda veri girişi istenecektir.Kullanıcı, sil ile dizi
             * indeksi yazdığında dizinin o indisi 0 olarak güncellenir. Kullanıcı exit girdisi verdiğinde program sonlanır.
             */

            int[] myArray = new int[100];
            int value, index = 0, primeCount, valueToDelete;
            string sub1 = "", sub2 = "", consoleValue = "";
            while (!consoleValue.Equals("exit"))
            {
                Console.WriteLine("Eleman eklemek için tam sayı degeri\nÇıkış için \"exit\"\n ve eleman silmek için \"sil elemanIndisi\" giriniz");
                consoleValue = Console.ReadLine();
                bool intParse = int.TryParse(consoleValue, out value);

                //------exit komutu gelene kadar döngüde kal-------------- 
                while (!intParse && !consoleValue.Equals("exit"))
                {
                    /*------Girilen Değer sayı değilse alt string al, sil ve değer var mı diye bak------*/
                    if (consoleValue.Length > 4)
                    {

                        sub1 = consoleValue.Substring(0, 3);
                        sub2 = consoleValue.Substring(4, consoleValue.Length - 4);
                    }
                    /*------Girilen değerden 4 karakter sonrasında işleme başladık o yüzden başladığımız yerden itibaren sonuna kadar sayı bekliyoruz sil 23 gibi
                     * -----(-4 string uzunluğunu taşmamak için çünkü 4 birim ilerdeyiz-----)
                     */

                    //----başta sil dizisi girilmişse ve silden sonra gelen karakterler bir sayiyi oluşturuyorsa dizideki o indexteki elemanı sıfırla-----
                    if (sub1.Equals("sil") && (int.TryParse(sub2, out valueToDelete)))
                    {
                        myArray[valueToDelete] = 0;
                    }
                    Console.WriteLine("Eleman eklemek için tam sayı degeri\nÇıkış için \"exit\"\n ve eleman silmek için \"sil elemanIndisi\" giriniz");
                    consoleValue = Console.ReadLine();
                    intParse = int.TryParse(consoleValue, out value);
                }
                myArray[index] = value;
                index++;



                /*--------------ASALLIK KONTROLÜ--------------*/
                #region primeCheck
                if (value == 2)
                {
                    Console.WriteLine("{0} asal bir sayidir.", value);
                }
                else
                {
                    for (primeCount = 2; primeCount <= value; primeCount++)
                    {
                        if (value % primeCount == 0 && value != primeCount)
                        {
                            primeCount++;
                            break;
                        }
                        else if (value % primeCount == 0)
                        {
                            break;
                        }
                    }
                    if (primeCount == value)
                    {
                        Console.WriteLine("{0} asal bir sayidir.", value);
                    }
                }
                #endregion
                /*-------------ASALLIK KONTROLÜ SONU----------------*/
            
            
            }

            //-----Deneme için 2. elemanı ekrana yazdırıp sonuca bakmak için ------------
            Console.WriteLine(myArray[2]);
            Console.ReadLine();
        }
    }
}
