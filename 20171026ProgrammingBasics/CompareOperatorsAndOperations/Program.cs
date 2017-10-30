using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareOperatorsAndOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            #region a
            /*
             * Ekrandan giriş yapılan iki string değeri, kullanılabilecek tüm karşılaştırma operatörlerini kullanarak değerlendirmesini yapın. 
             * Sonucu bool tipinde bir değişkene atayın ve örnekte olduğu gibi alt alta sonuçları yazdırın.
             */
            string consoleValue1, consoleValue2;
            Console.WriteLine("ilk metni giriniz ");
            consoleValue1 = Console.ReadLine();
            Console.WriteLine("İkinci metni giriniz: ");
            consoleValue2 = Console.ReadLine();

            bool compare = (consoleValue1 == consoleValue2);
            Console.WriteLine("{0} ile {1} birbirine eşittir: {2} ", consoleValue1, consoleValue2, compare);

            bool compare1 = (consoleValue1 != consoleValue2);
            Console.WriteLine("{0} ile {1} birbirine eşit değildir: {2} ", consoleValue1, consoleValue2, compare1);
            #endregion


            #region b
            /*
             *  Ekrandan giriş yapılan iki tam sayı değeri, kullanılabilecek tüm karşılaştırma operatörlerini kullanarak değerlendirmesini yapın. 
             *  Sonucu bool tipinde bir değişkene atayın ve örnekte olduğu gibi alt alta sonuçları yazdırın.
             */

            int numToComp, numToComp1;

            Console.WriteLine("ilk sayiyi giriniz ");
            numToComp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi giriniz: ");
            numToComp1 = Convert.ToInt32(Console.ReadLine());

            bool equals = (numToComp == numToComp1);
            bool notEqual = (numToComp != numToComp1);
            bool less = (numToComp < numToComp1);
            bool greater = (numToComp > numToComp1);
            bool lessEquals = (numToComp <= numToComp1);
            bool greaterEquals = (numToComp >= numToComp1);

            Console.WriteLine("{0} ve {1} eşittir:{2} ", numToComp, numToComp1, equals);
            Console.WriteLine("{0} ve {1} eşit degildir:{2} ", numToComp, numToComp1, notEqual);
            Console.WriteLine("{0} , {1}'den küçüktür:{2} ", numToComp, numToComp1, less);
            Console.WriteLine("{0} , {1} 'den büyüktür:{2} ", numToComp, numToComp1, greater);
            Console.WriteLine("{0} , {1} 'den küçük eşittir:{2} ", numToComp, numToComp1, lessEquals);
            Console.WriteLine("{0} , {1} 'den büyük eşittir:{2} ", numToComp, numToComp1, greaterEquals);

            #endregion

            #region c
            /*
             * Ekrandan giriş yapılan iki ayrı tek karakter değeri, kullanılabilecek tüm karşılaştırma operatörlerini kullanarak değerlendirmesini yapın. 
             * Sonucu bool tipinde bir değişkene atayın ve örnekte olduğu gibi alt alta sonuçları yazdırın.
             */

            char firstChar, secondChar;

            Console.WriteLine("ilk karakteri giriniz ");
            firstChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("İkinci karakteri giriniz: ");
            secondChar = Convert.ToChar(Console.ReadLine());

            bool equalsc = (firstChar == secondChar);
            bool notEqualc = (firstChar != secondChar);
            bool lessc = (firstChar < secondChar);
            bool greaterc = (firstChar > secondChar);
            bool lessEqualsc = (firstChar <= secondChar);
            bool greaterEqualsc = (firstChar >= secondChar);

            Console.WriteLine("{0} ve {1} eşittir:{2} ", firstChar, secondChar, equalsc);
            Console.WriteLine("{0} ve {1} eşit degildir:{2} ", firstChar, secondChar, notEqualc);
            Console.WriteLine("{0} , {1}'den küçüktür:{2} ", firstChar, secondChar, lessc);
            Console.WriteLine("{0} , {1} 'den büyüktür:{2} ", firstChar, secondChar, greaterc);
            Console.WriteLine("{0} , {1} 'den küçük eşittir:{2} ", firstChar, secondChar, lessEqualsc);
            Console.WriteLine("{0} , {1} 'den büyük eşittir:{2} ", firstChar, secondChar, greaterEqualsc);


            #endregion
            Console.ReadLine();
        }
    }
}
