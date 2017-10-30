using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            /*
             * Ekrandan girilecek 2 tam sayıdan, ikinci girilen değerin birinci sayının tam katı olup olmadığını tespit edip ekrana yazdıran bir program yazınız. 
             * İlk girilen sayı ikinci girilen sayıdan mutlaka küçük olmalıdır, bununla ilgili kontrolü de sağlayın.
             */
            //----Alınan iki sayıdan büyük olanın küçükm olanın tam katı olup olmadığını bulan program.
            int myFirstNuma, mySecondNuma;


            Console.WriteLine("İlk sayiyi giriniz: ");
            myFirstNuma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayiyi giriniz: ");
            mySecondNuma = Convert.ToInt32(Console.ReadLine());

            if (myFirstNuma < mySecondNuma)
            {
                if (mySecondNuma % myFirstNuma == 0)
                {
                    Console.WriteLine("{0} sayisi {1} sayisinin tam katidir.", mySecondNuma, myFirstNuma);
                }
                else
                {
                    Console.WriteLine("{0} sayisi {1} sayisinin tam kati degildir.", mySecondNuma, myFirstNuma);
                }
            }
            else
            {
                Console.WriteLine("İlk sayi ikinci sayidan küçük olmalidir...");
            }
            #endregion


            #region b
            //Ekrandan girilecek 3 adet sayıdan en büyüğünü tespit eden program yazın. Sonucu ekrana yazdırın.
            int nr1, nr2, nr3;

            Console.WriteLine("ilk sayiyi giriniz:");
            nr1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz:");
            nr2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üçüncü sayiyi giriniz:");
            nr3 = Convert.ToInt32(Console.ReadLine());

            if ((nr1 >= nr2) && (nr1 >= nr3))
            {
                Console.WriteLine("{0} en büyük sayidir. ", nr1);
            }
            else if ((nr2 >= nr1) && (nr2 >= nr3))
            {
                Console.WriteLine("{0} en büyük sayidir. ", nr2);
            }
            else
            {
                Console.WriteLine("{0} en büyük sayidir. ", nr3);
            }


            #endregion

            #region c
            double edge1, edge2, edge3;

            Console.WriteLine("ilk sayiyi giriniz:");
            edge1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz:");
            edge2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("üçüncü sayiyi giriniz:");
            edge3 = Convert.ToDouble(Console.ReadLine());



            if (edge1 > 0 && edge2 > 0 && edge3 > 0)
            {
                if (((edge1 + edge2) > edge3) && ((edge1 - edge2) < edge3))
                {
                    Console.WriteLine("bu kenarlar bir üçgen oluşturur");
                }
                else
                {
                    Console.WriteLine("bu degerlerle üçgen elde edilemez");
                }

            }
            else
            {
                Console.WriteLine(" Girilen degerler pozitif olmalıdır... ");
            }
            #endregion

            #region d
            int angle1, angle2, angle3;

            Console.WriteLine("ilk sayiyi giriniz:");
            angle1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz:");
            angle2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üçüncü sayiyi giriniz:");
            angle3 = Convert.ToInt32(Console.ReadLine());

            if (angle1 > 0 && angle2 > 0 && angle3 > 0)
            {
                if ((angle1 + angle2 + angle3) == 180)
                {
                    Console.WriteLine("Bu degerler ile üçgen oluşturulabilir");
                }
                else
                {
                    Console.WriteLine("Bu degerler ile üçgen oluşturulamaz");
                }
            }
            else
            {
                Console.WriteLine("Açı degerleri pozitif olmalıdır... ");
            }
            #endregion

            #region e
            int rEdge1, rEdge2, rEdge3;

            Console.WriteLine("ilk sayiyi giriniz:");
            rEdge1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz:");
            rEdge2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üçüncü sayiyi giriniz:");
            rEdge3 = Convert.ToInt32(Console.ReadLine());

            if (rEdge1 > 0 && rEdge2 > 0 && rEdge3 > 0)
            {
                if (((rEdge1 * rEdge1) + (rEdge2 * rEdge2) == (rEdge3 * rEdge3)) || ((rEdge2 * rEdge2) + (rEdge3 * rEdge3) == (rEdge1 * rEdge1)) || ((rEdge1 * rEdge1) + (rEdge3 * rEdge3) == (rEdge2 * rEdge2)))
                {
                    Console.WriteLine("Bu degerler ile dik üçgen çizilebilir");
                }
                else
                {
                    Console.WriteLine("Bu degerler ile dik üçgen çizilemez");
                }
            }
            else
            {
                Console.WriteLine("Kenarlar Negatif deger alamaz... ");
            }
            #endregion

            #region f

            int rAngle1, rAngle2, rAngle3;

            Console.WriteLine("ilk sayiyi giriniz:");
            rAngle1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz:");
            rAngle2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üçüncü sayiyi giriniz:");
            rAngle3 = Convert.ToInt32(Console.ReadLine());

            if (rAngle1 > 0 && rAngle2 > 0 && rAngle3 > 0)
            {
                if ((rAngle1 == 90 || rAngle2 == 90 || rAngle3 == 90) && (rAngle1 + rAngle2 + rAngle3) == 180)
                {

                    Console.WriteLine(" Girilen degerler ile dik üçgen çizilebilir");
                }
                else
                {
                    Console.WriteLine("Girilen degerler ile dik üçgen çizilemez");
                }
            }
            else
            {
                Console.WriteLine("Açı degerleri negatif olamaz.");
            }
            #endregion

            Console.ReadLine();

        }
    }
}
