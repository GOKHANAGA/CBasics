using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperationsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            #region a
            //. Ekrandan girilen iki tam sayıyı toplayın ve yeni bir değişkene atayın ve sonucu görüntüleyin.

            string consoleValuea;
            int userNumbera, userNumber1a, resulta;
            short shortUserNumbera, shortUserNumber1a, shortResulta;
            long longUserNumbera, longUserNumber1a, longResulta;
            sbyte sByteuserNumbera, sByteuserNumber1a, sByteresulta;
            byte byteUserNumbera, byteUserNumber1a, byteresulta;
            ushort uShortUserNumbera, uShortUserNumber1a, uShortResulta;
            uint uUserNumbera, uUserNumber1a, uResulta;
            ulong uLongUserNumbera, uLongUserNumber1a, uLongResulta;

            Console.WriteLine("Toplanacak ilk sayinizi giriniz");
            consoleValuea = Console.ReadLine();
            userNumbera = Int32.Parse(consoleValuea);
            shortUserNumbera = Int16.Parse(consoleValuea);
            longUserNumbera = long.Parse(consoleValuea);
            sByteuserNumbera = sbyte.Parse(consoleValuea);
            byteUserNumbera = byte.Parse(consoleValuea);
            uShortUserNumbera = ushort.Parse(consoleValuea);
            uUserNumbera = uint.Parse(consoleValuea);
            uLongUserNumbera = ulong.Parse(consoleValuea);





            Console.WriteLine("Toplanacak ikinci sayinizi giriniz");
            //Her tip için atama yap.
            consoleValuea = Console.ReadLine();
            userNumber1a = Int32.Parse(consoleValuea);
            shortUserNumber1a = Int16.Parse(consoleValuea);
            longUserNumber1a = long.Parse(consoleValuea);
            sByteuserNumber1a = sbyte.Parse(consoleValuea);
            byteUserNumber1a = byte.Parse(consoleValuea);
            uShortUserNumber1a = ushort.Parse(consoleValuea);
            uUserNumber1a = uint.Parse(consoleValuea);
            uLongUserNumber1a = ulong.Parse(consoleValuea);




            resulta = userNumber1a + userNumbera;
            shortResulta = (short)(shortUserNumbera + shortUserNumber1a);
            longResulta = longUserNumbera + longUserNumber1a;
            sByteresulta = (sbyte)(sByteuserNumbera + sByteuserNumber1a);
            byteresulta = (byte)(byteUserNumbera + byteUserNumber1a);
            uShortResulta = (ushort)(uShortUserNumbera + uShortUserNumber1a);
            uResulta = uUserNumbera + uUserNumber1a;
            uLongResulta = uLongUserNumbera + uLongUserNumber1a;



            Console.WriteLine("Girilen sayilarin toplamiInt16: " + shortResulta);
            Console.WriteLine("Girilen sayilarin toplamiInt32: " + resulta);
            Console.WriteLine("Girilen sayilarin toplamiInt64: " + longResulta);
            Console.WriteLine("Girilen sayilarin toplamiuInt: " + uResulta);
            Console.WriteLine("Girilen sayilarin toplamisByte: " + sByteresulta);
            Console.WriteLine("Girilen sayilarin toplamiByte: " + byteresulta);
            Console.WriteLine("Girilen sayilarin toplamiuShort: " + uShortResulta);
            Console.WriteLine("Girilen sayilarin toplamiuLong: " + uLongResulta);


            #endregion

            #region b
            //. Ekrandan girilen iki tam sayının farkını hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin.
            string consoleValueb;
            int userNumberb, userNumber1b, resultb;
            short shortUserNumberb, shortUserNumber1b, shortResultb;
            long longUserNumberb, longUserNumber1b, longResultb;
            sbyte sByteuserNumberb, sByteuserNumber1b, sByteresultb;
            byte byteUserNumberb, byteUserNumber1b, byteresultb;
            ushort uShortUserNumberb, uShortUserNumber1b, uShortResultb;
            uint uUserNumberb, uUserNumber1b, uResultb;
            ulong uLongUserNumberb, uLongUserNumber1b, uLongResultb;



            Console.WriteLine("kendisinden çıkarılacak sayinizi giriniz");
            consoleValueb = Console.ReadLine();
            userNumberb = Int32.Parse(consoleValueb);
            shortUserNumberb = short.Parse(consoleValueb);
            longUserNumberb = long.Parse(consoleValueb);
            sByteuserNumberb = sbyte.Parse(consoleValueb);
            byteUserNumberb = byte.Parse(consoleValueb);
            uShortUserNumberb = ushort.Parse(consoleValueb);
            uUserNumberb = uint.Parse(consoleValueb);
            uLongUserNumberb = ulong.Parse(consoleValueb);



            Console.WriteLine("çıkan sayinizi giriniz");
            consoleValueb = Console.ReadLine();
            userNumber1b = Int32.Parse(consoleValueb);
            shortUserNumber1b = short.Parse(consoleValueb);
            longUserNumber1b = long.Parse(consoleValueb);
            sByteuserNumber1b = sbyte.Parse(consoleValueb);
            byteUserNumber1b = byte.Parse(consoleValueb);
            uShortUserNumber1b = ushort.Parse(consoleValueb);
            uUserNumber1b = uint.Parse(consoleValueb);
            uLongUserNumber1b = ulong.Parse(consoleValueb);





            resultb = userNumberb - userNumber1b;
            shortResultb = (short)(shortUserNumberb - shortUserNumber1b);
            longResultb = longUserNumberb - longUserNumber1b;
            sByteresultb = (sbyte)(sByteuserNumberb - sByteuserNumber1b);
            byteresultb = (byte)(byteUserNumberb - byteUserNumber1b);
            uShortResultb = (ushort)(uShortUserNumberb - uShortUserNumber1b);
            uResultb = uUserNumberb - uUserNumber1b;
            uLongResultb = uLongUserNumberb - uLongUserNumber1b;





            Console.WriteLine("Girilen sayilarin farkiInt16: " + shortResultb);
            Console.WriteLine("Girilen sayilarin farkiInt32: " + resultb);
            Console.WriteLine("Girilen sayilarin farkiInt64: " + longResultb);
            Console.WriteLine("Girilen sayilarin farkiuInt: " + uResultb);
            Console.WriteLine("Girilen sayilarin farkisByte: " + sByteresultb);
            Console.WriteLine("Girilen sayilarin farkiByte: " + byteresultb);
            Console.WriteLine("Girilen sayilarin farkiuShort: " + uShortResultb);
            Console.WriteLine("Girilen sayilarin farkiuLong: " + uLongResultb);
            #endregion

            #region c
            //Ekrandan girilen iki tam sayının çarpımını hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin
            string consoleValuec;
            int userNumberc, userNumber1c, resultc;
            short shortUserNumberc, shortUserNumber1c, shortResultc;
            long longUserNumberc, longUserNumber1c, longResultc;
            sbyte sByteuserNumberc, sByteuserNumber1c, sByteresultc;
            byte byteUserNumberc, byteUserNumber1c, byteresultc;
            ushort uShortUserNumberc, uShortUserNumber1c, uShortResultc;
            uint uUserNumberc, uUserNumber1c, uResultc;
            ulong uLongUserNumberc, uLongUserNumber1c, uLongResultc;

            Console.WriteLine("çarpilacak ilk sayinizi giriniz");
            consoleValuec = Console.ReadLine();
            userNumberc = Int32.Parse(consoleValuec);
            shortUserNumberc = short.Parse(consoleValuec);
            longUserNumberc = long.Parse(consoleValuec);
            sByteuserNumberc = sbyte.Parse(consoleValuec);
            byteUserNumberc = byte.Parse(consoleValuec);
            uShortUserNumberc = ushort.Parse(consoleValuec);
            uUserNumberc = uint.Parse(consoleValuec);
            uLongUserNumberc = ulong.Parse(consoleValuec);

            Console.WriteLine("çarpilacak ikinci sayinizi giriniz");
            consoleValuec = Console.ReadLine();
            userNumber1c = Int32.Parse(consoleValuec);
            shortUserNumber1c = short.Parse(consoleValuec);
            longUserNumber1c = long.Parse(consoleValuec);
            sByteuserNumber1c = sbyte.Parse(consoleValuec);
            byteUserNumber1c = byte.Parse(consoleValuec);
            uShortUserNumber1c = ushort.Parse(consoleValuec);
            uUserNumber1c = uint.Parse(consoleValuec);
            uLongUserNumber1c = ulong.Parse(consoleValuec);




            resultc = userNumberc * userNumber1c;
            shortResultc = (short)(userNumberc * userNumber1c);
            longResultc = userNumberc * userNumber1c;
            sByteresultc = (sbyte)(sByteuserNumberc * sByteuserNumber1c);
            byteresultc = (byte)(byteUserNumberc * byteUserNumber1c);
            uShortResultc = (ushort)(uShortUserNumberc * uShortUserNumber1c);
            uResultc = uUserNumberc * uUserNumber1c;
            uLongResultc = uLongUserNumberc * uLongUserNumber1c;

            Console.WriteLine("Girilen sayilarin carpimiInt16: " + shortResultc);
            Console.WriteLine("Girilen sayilarin carpimiInt32: " + resultc);
            Console.WriteLine("Girilen sayilarin carpimiInt64: " + longResultc);
            Console.WriteLine("Girilen sayilarin carpimiuInt: " + uResultc);
            Console.WriteLine("Girilen sayilarin carpimisByte: " + sByteresultc);
            Console.WriteLine("Girilen sayilarin carpimiByte: " + byteresultc);
            Console.WriteLine("Girilen sayilarin carpimiuShort: " + uShortResultc);
            Console.WriteLine("Girilen sayilarin carpimiuLong: " + uLongResultc);
            #endregion

            #region d
            //Ekrandan girilen iki tam sayının bölümünü hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin.
            string consoleValue;
            int userNumber, userNumber1, result;
            short shortUserNumber, shortUserNumber1, shortResult;
            long longUserNumber, longUserNumber1, longResult;
            sbyte sByteuserNumber, sByteuserNumber1, sByteresult;
            byte byteUserNumber, byteUserNumber1, byteresult;
            ushort uShortUserNumber, uShortUserNumber1, uShortResult;
            uint uUserNumber, uUserNumber1, uResult;
            ulong uLongUserNumber, uLongUserNumber1, uLongResult;


            Console.WriteLine("Bölünecek sayiyi giriniz");
            consoleValue = Console.ReadLine();
            userNumber = Int32.Parse(consoleValue);
            shortUserNumber = short.Parse(consoleValue);
            longUserNumber = long.Parse(consoleValue);
            sByteuserNumber = sbyte.Parse(consoleValue);
            byteUserNumber = byte.Parse(consoleValue);
            uShortUserNumber = ushort.Parse(consoleValue);
            uUserNumber = uint.Parse(consoleValue);
            uLongUserNumber = ulong.Parse(consoleValue);


            Console.WriteLine("Bölen sayinizi giriniz");
            consoleValue = Console.ReadLine();
            userNumber1 = Int32.Parse(consoleValue);
            shortUserNumber1 = short.Parse(consoleValue);
            longUserNumber1 = long.Parse(consoleValue);
            sByteuserNumber1 = sbyte.Parse(consoleValue);
            byteUserNumber1 = byte.Parse(consoleValue);
            uShortUserNumber1 = ushort.Parse(consoleValue);
            uUserNumber1 = uint.Parse(consoleValue);
            uLongUserNumber1 = ulong.Parse(consoleValue);


            result = userNumber1 / userNumber;
            shortResult = (short)(shortUserNumber / shortUserNumber1);
            longResult = longUserNumber / longUserNumber1;
            sByteresult = (sbyte)(sByteuserNumber / sByteuserNumber1);
            byteresult = (byte)(byteUserNumber / byteUserNumber1);
            uShortResult = (ushort)(uShortUserNumber / uShortUserNumber1);
            uResult = uUserNumber / uUserNumber1;
            uLongResult = uLongUserNumber / uLongUserNumber1;


            Console.WriteLine("Girilen sayilarin BölümüInt16: " + shortResult);
            Console.WriteLine("Girilen sayilarin BölümüInt16: " + result);
            Console.WriteLine("Girilen sayilarin BölümüInt16: " + longResult);
            Console.WriteLine("Girilen sayilarin BölümüuInt: " + uResultc);
            Console.WriteLine("Girilen sayilarin BölümüsByte: " + sByteresultc);
            Console.WriteLine("Girilen sayilarin BölümüByte: " + byteresultc);
            Console.WriteLine("Girilen sayilarin BölümüuShort: " + uShortResultc);
            Console.WriteLine("Girilen sayilarin BölümüuLong: " + uLongResultc);



            #endregion



            /*----------------------FOR FRACTIONAL NUMBERS-----------------*/

            #region e
            //Ekrandan girilen iki ondalık sayıyı toplayın ve yeni bir değişkene atayın ve sonucu görüntüleyin.

            string consoleValuee;
            float fUserNumber, fUserNumber1, fResult;
            double dUserNumber, dUserNumber1, dResult;
            decimal deUserNumber, deUserNumber1, deResult;

            Console.WriteLine("Toplanacak ilk ondalikli sayiyi giriniz: ");
            consoleValuee = Console.ReadLine();
            fUserNumber = float.Parse(consoleValuee);
            dUserNumber = double.Parse(consoleValuee);
            deUserNumber = decimal.Parse(consoleValuee);


            Console.WriteLine("Toplanacak ikinci ondalikli sayiyi giriniz: ");
            consoleValuee = Console.ReadLine();
            fUserNumber1 = float.Parse(consoleValuee);
            dUserNumber1 = double.Parse(consoleValuee);
            deUserNumber1 = decimal.Parse(consoleValuee);

            fResult = fUserNumber + fUserNumber1;
            dResult = dUserNumber + dUserNumber1;
            deResult = deUserNumber + deUserNumber1;

            Console.WriteLine("Toplam degeri-Float: " + fResult);
            Console.WriteLine("Toplam degeri-Double: " + dResult);
            Console.WriteLine("Toplam degeri-Decimal: " + deResult);

            #endregion

            #region f
            //. Ekrandan girilen iki ondalık sayıyı farkını hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin.
            string consoleValuef;
            float fUserNumberf, fUserNumber1f, fResultf;
            double dUserNumberf, dUserNumber1f, dResultf;
            decimal deUserNumberf, deUserNumber1f, deResultf;

            Console.WriteLine("Eksilen ondalikli sayiyi giriniz: ");
            consoleValuef = Console.ReadLine();
            fUserNumberf = float.Parse(consoleValuef);
            dUserNumberf = double.Parse(consoleValuef);
            deUserNumberf = decimal.Parse(consoleValuef);

            Console.WriteLine("Çıkan ondalikli sayiyi giriniz: ");
            consoleValuef = Console.ReadLine();
            fUserNumber1f = float.Parse(consoleValuef);
            dUserNumber1f = double.Parse(consoleValuef);
            deUserNumber1f = decimal.Parse(consoleValuef);

            fResultf = fUserNumberf - fUserNumber1f;
            dResultf = dUserNumberf - dUserNumber1f;
            deResultf = deUserNumberf - deUserNumber1f;


            Console.WriteLine("Fark degeri-Float: " + fResultf);
            Console.WriteLine("Fark degeri-Double: " + dResultf);
            Console.WriteLine("fark degeri-Decimal: " + deResultf);

            #endregion

            #region g
            //Ekrandan girilen iki ondalık sayının çarpımını hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin.
            string consoleValueg;
            float fUserNumberg, fUserNumber1g, fResultg;
            double dUserNumberg, dUserNumber1g, dResultg;
            decimal deUserNumberg, deUserNumber1g, deResultg;

            Console.WriteLine("Çarpılan ilk ondalikli sayiyi giriniz: ");
            consoleValueg = Console.ReadLine();
            fUserNumberg = float.Parse(consoleValueg);
            dUserNumberg = double.Parse(consoleValueg);
            deUserNumberg = decimal.Parse(consoleValueg);

            Console.WriteLine("Çarpılan ikinci ondalikli sayiyi giriniz: ");
            consoleValueg = Console.ReadLine();
            fUserNumber1g = float.Parse(consoleValueg);
            dUserNumber1g = double.Parse(consoleValueg);
            deUserNumber1g = decimal.Parse(consoleValueg);

            fResultg = fUserNumberg * fUserNumber1g;
            dResultg = dUserNumberg * dUserNumber1g;
            deResultg = deUserNumberg * deUserNumber1g;


            Console.WriteLine("çarpım degeri-Float: " + fResultg);
            Console.WriteLine("Çarpım degeri-Double: " + dResultg);
            Console.WriteLine("Çarpım degeri-Decimal: " + deResultg);

            #endregion

            #region h
            //Ekrandan girilen iki ondalık sayının bölümünü hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin.
            string consoleValueh;
            float fUserNumberh, fUserNumber1h, fResulth;
            double dUserNumberh, dUserNumber1h, dResulth;
            decimal deUserNumberh, deUserNumber1h, deResulth;

            Console.WriteLine("Bölünen ondalikli sayiyi giriniz: ");
            consoleValueh = Console.ReadLine();
            fUserNumberh = float.Parse(consoleValueh);
            dUserNumberh = double.Parse(consoleValueh);
            deUserNumberh = decimal.Parse(consoleValueh);

            Console.WriteLine("Bölen ondalikli sayiyi giriniz: ");
            consoleValueh = Console.ReadLine();
            fUserNumber1h = float.Parse(consoleValueh);
            dUserNumber1h = double.Parse(consoleValueh);
            deUserNumber1h = decimal.Parse(consoleValueh);

            fResulth = fUserNumberh / fUserNumber1h;
            dResulth = dUserNumberh / dUserNumber1h;
            deResulth = deUserNumberh / deUserNumber1h;


            Console.WriteLine("Böüm degeri-Float: " + fResulth);
            Console.WriteLine("Bölüm degeri-Double: " + dResulth);
            Console.WriteLine("Bölüm degeri-Decimal: " + deResulth);
            #endregion

            #region i
            //Ekrandan girilen bir ondalık sayıyı ve bir tam sayıyı toplayın ve yeni bir değişkene atayın ve sonucu görüntüleyin.
            double doubleNumber, doubleResult;
            int intNumber;

            Console.WriteLine("Ondalikli sayiyi giriniz: ");
            doubleNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tam sayiyi giriniz: ");
            intNumber = Convert.ToInt32(Console.ReadLine());

            doubleResult = doubleNumber + intNumber;
            Console.WriteLine("Toplam sonucu: " + doubleResult);
            #endregion

            #region j
            //Ekrandan girilen bir ondalık sayı ve bir tam sayının farkını hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin.
            double doubleNumberj, doubleResultj;
            int intNumberj;

            Console.WriteLine("Ondalikli sayiyi giriniz: ");
            doubleNumberj = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tam sayiyi giriniz: ");
            intNumberj = Convert.ToInt32(Console.ReadLine());

            doubleResultj = doubleNumberj - intNumberj;
            Console.WriteLine("Fark sonucu: " + doubleResultj);
            #endregion

            #region k
            //Ekrandan girilen bir ondalık sayı ve bir tam sayının çarpımını hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin.
            double doubleNumberk, doubleResultk;
            int intNumberk;

            Console.WriteLine("Ondalikli sayiyi giriniz: ");
            doubleNumberk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tam sayiyi giriniz: ");
            intNumberk = Convert.ToInt32(Console.ReadLine());

            doubleResultk = doubleNumberk - intNumberk;
            Console.WriteLine("Fark sonucu: " + doubleResultk);
            #endregion

            #region l
            //Ekrandan girilen bir ondalık sayı ve bir tam sayının bölümünü hesaplayıp yeni bir değişkene atayın ve sonucu görüntüleyin.
            double doubleNumberl, doubleResultl;
            int intNumberl;

            Console.WriteLine("Ondalikli sayiyi giriniz: ");
            doubleNumberl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tam sayiyi giriniz: ");
            intNumberl = Convert.ToInt32(Console.ReadLine());

            doubleResultl = doubleNumberl / intNumberl;
            Console.WriteLine("Bölme sonucu: " + doubleResultl);
            #endregion
        }
    }
}
