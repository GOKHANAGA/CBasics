using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3.a

            //string consoleValue="";
            //int nrToAnalyze;


            //while (consoleValue != "exit")
            //{
            //    Console.WriteLine("Lütfen Bir Sayi Giriniz");
            //    consoleValue = Console.ReadLine();
            //    if (!(int.TryParse(consoleValue, out nrToAnalyze)) && consoleValue != "exit") 
            //    {
            //    Console.WriteLine("Yanlış Bir Değer Girdiniz\n********************\n");
            //    continue;
            //    }
            //    else if (consoleValue == "exit")
            //    {
            //        continue;
            //    }

            //    IntegerAnalyze(nrToAnalyze);

            //}

            #endregion

            #region 3.b

            string consoleValue = "";
            int nrToReverse,nrToCheck;
            int reversedNumber = 0;



            while (consoleValue != "exit")
            {
                Console.WriteLine("Lütfen Bir Sayi Giriniz");
                consoleValue = Console.ReadLine();
                reversedNumber = 0;

                if (!(int.TryParse(consoleValue, out nrToReverse)) && consoleValue != "exit")
                {
                    Console.WriteLine("Yanlış Bir Değer Girdiniz\n********************\n");
                    continue;
                }
                else if (consoleValue == "exit")
                {
                    continue;
                }

                nrToCheck = nrToReverse;

                while (nrToReverse > 0)
                {
                    int remainder = nrToReverse % 10;
                    reversedNumber = (reversedNumber * 10) + remainder;
                    nrToReverse = nrToReverse / 10;
                }

                if (nrToCheck == reversedNumber)
                {
                Console.WriteLine("{0} Palindrome bir sayidir...\n------------\n",reversedNumber);
                }
                else
                {
                    Console.WriteLine("{0} Palindrome bir sayi degildir...\n------------\n", nrToReverse);
                }

            }


            #endregion
            Console.ReadLine();
        }






        static void IntegerAnalyze(int nrToAnalyze)
        {
            int tenStep = 10;
            int counter = 1;
            int stepValue;

            while (true)
            {
                if (nrToAnalyze == 0)
                {
                    break;
                }

                stepValue = nrToAnalyze % tenStep;
                Console.WriteLine("{0}×{1}  =  {2}", stepValue / counter, counter, stepValue);

                nrToAnalyze -= stepValue;
                tenStep *= 10;
                counter *= 10;

            }

            Console.WriteLine("*******************\n\n");

        }

    }
}
