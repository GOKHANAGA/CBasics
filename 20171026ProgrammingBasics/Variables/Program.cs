using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            string firstString;
            Console.WriteLine("değeri giriniz: ");
            firstString = Console.ReadLine();
            #endregion

            #region b
            int int32ConvertedString = Int32.Parse(firstString);
            short shortConvertedString = Int16.Parse(firstString);
            long longConvertedString = Int64.Parse(firstString);
            sbyte sByteConvertedString = sbyte.Parse(firstString);
            byte byteConvertedString = byte.Parse(firstString);
            ushort uShortConvertedString = ushort.Parse(firstString);
            uint uIntConvertedString = uint.Parse(firstString);
            ulong uLongConvertedString = ulong.Parse(firstString);
            #endregion


            #region c
            double doubleConvertedString = double.Parse(firstString);
            float floatConvertedString = float.Parse(firstString);
            decimal decimalConvertedString = decimal.Parse(firstString);
            #endregion


        }
    }
}
