using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperationsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            /*
             * Ekrandan giriş yapılacak üç sayının karşılaştırması yapılacak. 
             * Yapılan karşılaştırmalar bool tipinde değişkenlere atanacak ve sonuçlar ekrana yazdırılacak
             */

            int numToComp, numToComp1, numToComp2;

            Console.WriteLine("ilk sayiyi giriniz ");
            numToComp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi giriniz: ");
            numToComp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü sayiyi giriniz ");
            numToComp2 = Convert.ToInt32(Console.ReadLine());

            bool allEquals = ((numToComp == numToComp1) && (numToComp1 == numToComp2));
            bool allNotEquals = !allEquals;
            bool firstLess = ((numToComp < numToComp1) && (numToComp < numToComp2));
            bool firstLessEqual = ((numToComp <= numToComp1) && (numToComp <= numToComp2));
            bool firstGreater = ((numToComp > numToComp1) && (numToComp > numToComp2));
            bool firstGreaterEqual = ((numToComp >= numToComp1) && (numToComp >= numToComp2));
            bool secondLess = ((numToComp1 < numToComp) && (numToComp1 < numToComp2));
            bool secondLessEqual = ((numToComp1 <= numToComp) && (numToComp1 <= numToComp2));
            bool secondGreater = ((numToComp1 > numToComp) && (numToComp1 > numToComp2));
            bool secondGreaterEquals = ((numToComp1 >= numToComp) && (numToComp1 >= numToComp2));
            bool thirdLess = ((numToComp2 < numToComp) && (numToComp2 < numToComp1));
            bool thirdLessEqual = ((numToComp2 <= numToComp) && (numToComp2 <= numToComp1));
            bool thirdGreater = ((numToComp2 > numToComp) && (numToComp2 > numToComp1));
            bool thirdGreaterEquals = ((numToComp2 >= numToComp) && (numToComp2 >= numToComp1));

            Console.WriteLine("{0},{1} ve {2} birbirine eşittir :{4}", numToComp, numToComp1, numToComp2, allEquals);
            Console.WriteLine("{0},{1} ve {2} birbirine eşit değildir :{4}", numToComp, numToComp1, numToComp2, allNotEquals);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan büyüktür :{4}", numToComp, numToComp1, numToComp2, firstGreater);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan büyüktür veya eşittir :{4}", numToComp, numToComp1, numToComp2, firstGreaterEqual);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan küçüktür :{4}", numToComp, numToComp1, numToComp2, firstLess);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan küçüktür veya eşittir :{4}", numToComp, numToComp1, numToComp2, firstLessEqual);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan büyüktür :{4}", numToComp1, numToComp, numToComp2, secondGreater);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan büyüktür veya eşittir :{4}", numToComp1, numToComp, numToComp2, secondGreaterEquals);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan küçüktür :{4}", numToComp1, numToComp, numToComp2, secondLess);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan küçüktür veya eşittir :{4}", numToComp1, numToComp, numToComp2, secondLessEqual);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan büyüktür :{4}", numToComp2, numToComp, numToComp1, thirdGreater);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan büyüktür veya eşittir :{4}", numToComp2, numToComp, numToComp1, thirdGreaterEquals);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan küçüktür :{4}", numToComp2, numToComp, numToComp1, thirdLess);
            Console.WriteLine("{0} sayisi {1} ve {2} sayilarindan küçüktür veya eşittir :{4}", numToComp2, numToComp, numToComp1, thirdLessEqual);


            #endregion

            #region b
            /*
             * Ekrandan giriş yapılacak üç isim ve yaşlarının karşılaştırması yapılacak. 
             * Yapılan karşılaştırmalar bool tipinde değişkenlere atanacak ve sonuçlar kişi isimleri ile birlikte ekrana yazdırılacak.
             */
            string firstName, secondName, thirdName;
            int firstAge, secondAge, thirdAge;

            Console.WriteLine("İlk kişinin adini giriniz: ");
            firstName = Console.ReadLine();
            Console.WriteLine("İlk kişinin yaşını giriniz:");
            firstAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci kişinin adini giriniz: ");
            secondName = Console.ReadLine();
            Console.WriteLine("İkinci kişinin yaşını giriniz:");
            secondAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üçüncü kişinin adini giriniz: ");
            thirdName = Console.ReadLine();
            Console.WriteLine("Üçüncü kişinin yaşını giriniz:");
            thirdAge = Convert.ToInt32(Console.ReadLine());


            bool allEqualsp = ((firstAge == secondAge) && (secondAge == thirdAge));
            bool allNotEqualsp = !allEquals;
            bool firstLessp = ((firstAge < secondAge) && (firstAge < thirdAge));
            bool firstLessEqualp = ((firstAge <= secondAge) && (firstAge <= thirdAge));
            bool firstGreaterp = ((firstAge > secondAge) && (firstAge > thirdAge));
            bool firstGreaterEqualp = ((firstAge >= secondAge) && (firstAge >= thirdAge));
            bool secondLessp = ((secondAge < firstAge) && (secondAge < thirdAge));
            bool secondLessEqualp = ((secondAge <= firstAge) && (secondAge <= thirdAge));
            bool secondGreaterp = ((secondAge > firstAge) && (secondAge > thirdAge));
            bool secondGreaterEqualsp = ((secondAge >= firstAge) && (secondAge >= thirdAge));
            bool thirdLessp = ((thirdAge < firstAge) && (thirdAge < secondAge));
            bool thirdLessEqualp = ((thirdAge <= firstAge) && (thirdAge <= secondAge));
            bool thirdGreaterp = ((thirdAge > firstAge) && (thirdAge > secondAge));
            bool thirdGreaterEqualsp = ((thirdAge >= firstAge) && (thirdAge >= secondAge));


            Console.WriteLine("{0},{1},{2} isimli kişilerin yaşları eşittir: {3}", firstName, secondName, thirdName, allEqualsp);
            Console.WriteLine("{0},{1},{2} isimli kişilerin yaşları eşit değildir: {3}", firstName, secondName, thirdName, allNotEqualsp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden büyüktür: {3}", firstName, secondName, thirdName, firstGreaterp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden büyüktür veya eşittir: {3}", firstName, secondName, thirdName, firstGreaterEqualp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden küçüktür: {3}", firstName, secondName, thirdName, firstLessp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden küçüktür veya eşittir: {3}", firstName, secondName, thirdName, firstLessEqualp);

            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden büyüktür: {3}", secondName, firstName, thirdName, secondGreaterp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden büyüktür veya eşittir: {3}", secondName, firstName, thirdName, secondGreaterEqualsp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden küçüktür: {3}", secondName, firstName, thirdName, secondLessp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden küçüktür veya eşittir: {3}", secondName, firstName, thirdName, secondLessEqualp);

            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden büyüktür: {3}", thirdName, firstName, secondName, thirdGreaterp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden büyüktür veya eşittir: {3}", thirdName, firstName, secondName, thirdGreaterEqualsp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden küçüktür: {3}", thirdName, firstName, secondName, thirdLessp);
            Console.WriteLine("{0} isimli kişinin yaşı {1} ve {2} kişilerinden küçüktür veya eşittir: {3}", thirdName, firstName, secondName, thirdLessEqualp);

            #endregion
        }
    }
}
