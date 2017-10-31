using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171031Marathon2
{
    class GuessTheNumberGame
    {
        static void Main(string[] args)
        {

            string consoleValue="";
            char oyunDevam = 'E';
            int secim=2,tutulanSayi,tahmin,guessCount=1;



            Console.WriteLine("Bir Zorluk Derecesi Seçiniz");
            Console.WriteLine("Kolay Seviye İçin 1'i Tuşlayınız.");
            Console.WriteLine("Orta Seviye İçin 2'yi Tuşlayınız.");
            Console.WriteLine("Zor Seviye İçin 3'ü Tuşlayınız. ");
            consoleValue = Console.ReadLine();

            while (oyunDevam == 'E' || oyunDevam=='e')
            {
                while (!(int.TryParse(consoleValue, out secim)))
                {
                    Console.WriteLine("Yanlis Bir Giris Yaptiniz\n--------------\n");
                    Console.WriteLine("Bir Zorluk Derecesi Seçiniz");
                    Console.WriteLine("Kolay Seviye İçin 1'i Tuşlayınız.");
                    Console.WriteLine("Orta Seviye İçin 2'yi Tuşlayınız.");
                    Console.WriteLine("Zor Seviye İçin 3'ü Tuşlayınız. ");
                    consoleValue = Console.ReadLine();
                }


                tutulanSayi = generateNumber(secim);
                Console.WriteLine(tutulanSayi);
                Console.WriteLine("Tahmininizi yaziniz: ");
                tahmin = int.Parse(Console.ReadLine());

                while (!NumberCheck(tutulanSayi, tahmin))
                {
                    if (Math.Abs(tahmin - tutulanSayi) <= tutulanSayi * 0.3)
                    {
                        Console.WriteLine("Sıcak");
                    }
                    else if (Math.Abs(tahmin - tutulanSayi) <= tutulanSayi * 0.6)
                    {
                        Console.WriteLine("Ilık");
                    }
                    else
                    {
                        Console.WriteLine("Soğuk");
                    }
                    Console.WriteLine("Tahmininizi yaziniz: ");
                    tahmin = int.Parse(Console.ReadLine());
                    guessCount++;
                }

                Console.WriteLine("Tebrikler {0} Doğru Tahmin", tahmin);
                Console.WriteLine("{0} tahminde cevaba ulaştınız", guessCount);
                Console.WriteLine("Puaniniz: " + PointCount(secim, guessCount));
                Console.WriteLine("\n\nOyuna Devam Etmek İster Misiniz? E/H");
                oyunDevam = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("****İyi Oyundu Tebrikler****");
            Console.ReadLine();


        }

        static int generateNumber(int rndNumber)
        {
            Random rnd = new Random();
            switch (rndNumber)
            {
                case 1:
                    return rndNumber = rnd.Next(1, 10);
                case 2:
                    return rndNumber = rnd.Next(1, 100);
                case 3:
                    return rndNumber = rnd.Next(1, 1000);
                default:
                    Console.WriteLine("Bir Hata Oluştu 1. Zorluk Seviye Seçildi");
                    return rndNumber = rnd.Next(1, 10);
            }

            
        }

        static bool NumberCheck(int rndNumber,int userGuess)
        {
            if (rndNumber == userGuess)
            {
                return true;
            }
            return false;
        }

        static int PointCount(int difficulty,int guessCount)
        {
            int totalPoint;
            //3 tahminde bilirse zorluk derecesine göre tahmin sayısının yüzdesi üzerinden puan alacak.
            if (guessCount <= 3)
            {
                totalPoint = (1000 - (1000 * (guessCount / 100)))*difficulty;
            }
            else if (guessCount <= 6)
            {
                //tamin sayısı arttıkça puan azalacak, 3 ile 6 arasında zorluk derecesi de işin içinde olmakla beraber tahmin sayısının ondalığı üzerinden puan hesaplanacak.
                totalPoint = (1000 - (1000 * (guessCount / 10)))*difficulty;
            }
            else
            {
                //6 dan fazla tahmin olursa sonuç sadece seçilen zorluk derecesine göre değerlendirme yapacak...
                totalPoint = 50*difficulty;
            }

            return totalPoint;
        }

    }
}
