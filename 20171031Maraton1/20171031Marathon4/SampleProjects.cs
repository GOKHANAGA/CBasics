using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171031Marathon4
{
    class SampleProjects
    {
        static void Main(string[] args)
        {

            #region 4.a
            //string consoleValue = "";
            //double kalmaSuresi;
            //int secim;

            //Console.WriteLine("Otopark Sistemine HoşGeldiniz\nLütfen Araç Tipinizi Seçiniz\n");
            //Console.WriteLine("Otomobil İçin 1'e Basınız.");
            //Console.WriteLine("Motosikler İçin 2'ye Basınız.");
            //Console.WriteLine("Minibüs İçin 3'e Basınız.");
            //Console.WriteLine("Kamyon (ve diger ticari araçlar) İçin 4'e Basınız.");
            //consoleValue = Console.ReadLine();

            ////Araç tipi seçme işlemini kontrol et---------------
            //while (true)
            //{
            //    if (!(int.TryParse(consoleValue, out secim)))
            //    {
            //        consoleValue = Console.ReadLine();
            //        continue;
            //    }
            //    else if (secim < 1 || secim > 4)
            //    {
            //        consoleValue = Console.ReadLine();
            //        continue;
            //    }
            //    else
            //    {
            //        break;
            //    }

            //}

            ////-----Aracın kaç saat kaldığını kontrol et-----
            //Console.WriteLine("Aracınızın otoparkta kaldığı süreyi yazınız:(ör: 2.5) ");
            //consoleValue = Console.ReadLine();

            //while (!(double.TryParse(consoleValue, out kalmaSuresi)))
            //{
            //    Console.WriteLine("Yanlis deger girdiniz lutfen yanda verilen formata uyunuz: (örnek giris: 2.5)");
            //    consoleValue = Console.ReadLine();
            //}

            //Console.WriteLine("Borcunuz {0} TL, Bizi Seçtiginiz icin teşekkurler.",Secim(secim, kalmaSuresi));

            //Console.ReadLine();

            #endregion

            #region 4.b

            //string[] ucakBilgisi = new string[20];
            //string consoleValue;
            //int classChoice,seatChoice;
            ///*  0-7  Business Class -------- 8-19  Economy Class   */

            //while (true)
            //{
            //    Console.WriteLine("Business Class için 1'e basınız.");
            //    Console.WriteLine("Economy Class için 2'e basınız.");
            //    consoleValue = Console.ReadLine();
            //    CheckValidity(consoleValue, out classChoice, 1, 2);


            //    //if there is no empty seat..........
            //    if (ShowEmpty(ucakBilgisi, classChoice) == 0)
            //    {
            //        //if there is no place and passenger chose H on screen program goes to top without doing anything else.
            //        if (!NoEmptyPlaceMessage(ucakBilgisi, ref classChoice))
            //        {
            //            continue;
            //        }

            //    }


            //    Console.WriteLine("\nLütfen listeden bir koltuk numarası seciniz");
            //    while (true)
            //    {
            //        consoleValue = Console.ReadLine();
            //        CheckValidity(consoleValue, out seatChoice, 1, ucakBilgisi.Length);

            //        // if the chosen seat is not empty there show an information text on screen with empty seats and go to top to choose again.... 
            //        if (!IsEmpty(ucakBilgisi[seatChoice-1]))
            //        {
            //            Console.WriteLine("{0} numaralı koltuk {1} isimli yolcuya aittir\nLutfen bos koltuklardan birini seciniz...", seatChoice, ucakBilgisi[seatChoice-1]);
            //            ShowEmpty(ucakBilgisi, classChoice);
            //            continue;
            //        }
            //        break;
            //    }

            //    Console.WriteLine("Secilen koltuk No: {0}", seatChoice);
            //    Console.WriteLine("Lutfen yolcunun adini ve soyadini giriniz.");
            //    ucakBilgisi[seatChoice-1] = Console.ReadLine();
            //    LastMessage(classChoice, seatChoice, ucakBilgisi[seatChoice]);

            //    Console.ReadLine();

            //}

            #endregion
        }

        #region 4.a Methods
        //static int Secim(int aracTipi,double kalisSuresi)
        //{
        //    switch (aracTipi)
        //    {
        //        case 1:
        //            return OtomobilTarife(kalisSuresi);
        //        case 2:
        //            return MotosikletTarife(kalisSuresi);
        //        case 3:
        //            return MinibüsTarife(kalisSuresi);
        //        case 4:
        //            return DigerTarife(kalisSuresi);
        //        default:
        //            return OtomobilTarife(kalisSuresi);
        //    }
        //}

        //static int OtomobilTarife(double kalmaSuresi)
        //{
        //    if(kalmaSuresi>0 && kalmaSuresi<2){
        //        return 5;
        //    }else if(kalmaSuresi>2 && kalmaSuresi<6){
        //        return 10;
        //    }
        //    else if (kalmaSuresi > 6 && kalmaSuresi < 12)
        //    {
        //        return 20;
        //    }
        //    else if (kalmaSuresi > 12 && kalmaSuresi < 24)
        //    {
        //        return 35;
        //    }
        //    else
        //    {
        //        return (35 + (20 * (int)kalmaSuresi / 24));
        //    }

        //}

        //static int MotosikletTarife(double kalmaSuresi)
        //{
        //    if (kalmaSuresi > 0 && kalmaSuresi < 2)
        //    {
        //        return 0;
        //    }
        //    else if (kalmaSuresi > 2 && kalmaSuresi < 6)
        //    {
        //        return 3;
        //    }
        //    else if (kalmaSuresi > 6 && kalmaSuresi < 12)
        //    {
        //        return 6;
        //    }
        //    else if (kalmaSuresi > 12 && kalmaSuresi < 24)
        //    {
        //        return 12;
        //    }
        //    else
        //    {
        //        return (12 + (10 * (int)kalmaSuresi / 24));
        //    }

        //}

        //static int MinibüsTarife(double kalmaSuresi)
        //{
        //    if (kalmaSuresi > 0 && kalmaSuresi < 2)
        //    {
        //        return 8;
        //    }
        //    else if (kalmaSuresi > 2 && kalmaSuresi < 6)
        //    {
        //        return 16;
        //    }
        //    else if (kalmaSuresi > 6 && kalmaSuresi < 12)
        //    {
        //        return 32;
        //    }
        //    else if (kalmaSuresi > 12 && kalmaSuresi < 24)
        //    {
        //        return 45;
        //    }
        //    else
        //    {
        //        return (45 + (25 * (int)kalmaSuresi / 24));
        //    }

        //}

        //static int DigerTarife(double kalmaSuresi)
        //{
        //    if (kalmaSuresi > 0 && kalmaSuresi < 2)
        //    {
        //        return 15;
        //    }
        //    else if (kalmaSuresi > 2 && kalmaSuresi < 6)
        //    {
        //        return 30;
        //    }
        //    else if (kalmaSuresi > 6 && kalmaSuresi < 12)
        //    {
        //        return 60;
        //    }
        //    else if (kalmaSuresi > 12 && kalmaSuresi < 24)
        //    {
        //        return 100;
        //    }
        //    else
        //    {
        //        return (100 + (55*(int)kalmaSuresi / 24));
        //    }

        //}

        #endregion

        #region 4.b Methods


        ////NULL CHECK...
        //static bool IsEmpty(string chrToCheck)
        //{

        //    if (chrToCheck == null)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //static int ShowEmpty(string[] passengers,int passengerClass)
        //{
        //    int emptyCount=0;
        //    if (passengerClass == 1) /*Check if the choice is business class*/
        //    {
        //        for (int i = 0; i < 8; i++)
        //        {
        //            if (IsEmpty(passengers[i])) /*Check if the seat is free*/
        //            {
        //                Console.WriteLine("-{0}",i + 1); /*If it is free then show on screen*/
        //                emptyCount++;
        //            }
        //        }
        //    }
        //    else/*if not business class make the same process for the economy class*/
        //    {
        //        for (int i = 8; i < passengers.Length; i++)
        //        {
        //            if (IsEmpty(passengers[i]))
        //            {
        //                Console.WriteLine("-{0}",i + 1);
        //                emptyCount++;
        //            }
        //        }
        //    }

        //    return emptyCount;
        //}

        //static void CheckValidity(string consoleValue,out int choice,int first,int second)
        //{
        //    while (true)
        //    {
        //        if (!(int.TryParse(consoleValue, out choice)))
        //        {
        //            consoleValue = Console.ReadLine();
        //            continue;
        //        }
        //        else if (choice < first || choice > second)
        //        {
        //            consoleValue = Console.ReadLine();
        //            continue;
        //        }
        //        else
        //        {
        //            break;
        //        }


        //    }
        //}

        //static void LastMessage(int clsChoice,int seatNo,string passenger)
        //{
        //    if (clsChoice == 1)
        //    {
        //        Console.WriteLine("Business Class bölümündeki {0} Numaralı koltugu {1} isimli yolcuya restore ettiniz.",seatNo,passenger);
        //    }
        //    else if (clsChoice == 2)
        //    {
        //        Console.WriteLine("Economy Class bölümündeki {0} Numaralı koltugu {1} isimli yolcuya restore ettiniz.", seatNo, passenger);
        //    }
        //}

        //static bool NoEmptyPlaceMessage(string[] passengers,ref int clsChoice)
        //{
        //    string consoleRead;
        //    if (clsChoice == 1)
        //    {
        //        Console.WriteLine("Sectiginiz Business Class Bölümünde Yer Kalmamıştır\n Economy Class Bölümündeki Boş Yerleri Görmek İster Misiniz E/H?");
        //        consoleRead=Console.ReadLine();
        //        if (consoleRead == "e" || consoleRead == "E")
        //        {
        //            clsChoice = 2;
        //            ShowEmpty(passengers, clsChoice);
        //            return true;
        //        }
        //        else if (consoleRead == "h" || consoleRead == "H")
        //        {
        //            Console.WriteLine("Bir sonraki ucus kayitlari 4 saat sonradir.");
        //            return false;
        //        }
                
        //    }
        //    else if (clsChoice == 2)
        //    {
        //        Console.WriteLine("Sectiginiz Economy Class Bölümünde Yer Kalmamıştır\n Business Class Bölümündeki Boş Yerleri Görmek İster Misiniz E/H?");
        //        consoleRead = Console.ReadLine();
        //        if (consoleRead == "e" || consoleRead == "E")
        //        {
        //            clsChoice = 1;
        //            ShowEmpty(passengers, clsChoice);
        //            return true;
        //        }
        //        else if (consoleRead == "h" || consoleRead == "H")
        //        {
        //            Console.WriteLine("Bir sonraki ucus kayitlari 4 saat sonradir.");
        //            return false;
        //        }
                
        //    }

        //    return false;
        //}

        #endregion
    }
}
