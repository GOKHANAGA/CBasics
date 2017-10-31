using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171031Maraton1
{
    class MethodBasics
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }




        ////check if given number is even
        static bool IsEven(int nrToCheck)
        {
            if (nrToCheck % 2 == 0)
            {
                return true;
            }
            return false;
        }
        ////

        //get the square of an integer
        static double SquareOf(double nrToMultiply)
        {
            return nrToMultiply * nrToMultiply;
        }
        ////

        //get the cube of an integer
        static double CubeOf(int cubeNumber)
        {
            return cubeNumber * cubeNumber;
        }
        //

        //get the given power of the given number
        static void PowerOf(ref double nrToMultiply, int power)
        {
            for (int i = 0; i < power; i++)
            {
                nrToMultiply *= nrToMultiply;
            }
        }

        /////

        //find the absolute of the given number
        static double Absolute(double nrToAbs)
        {
            if (nrToAbs < 0)
            {
                return nrToAbs * (-1);
            }
            return nrToAbs;
        }
        ////

        //reverse a string
        static string ReverseString(string textToReverse)
        {
            char[] reversedText = new char[textToReverse.Length];
            for (int i = textToReverse.Length - 1, j = 0; i >= 0 && j < textToReverse.Length; i--, j++)
            {
                reversedText[j] = textToReverse[i];
            }

            string a = "";
            for (int i = 0; i < reversedText.Length; i++)
            {
                a += reversedText[i];
            }

            return a;
        }


        static int[] ReverseInt(int[] intArrayToReverse)
        {
            int[] reversedInt = new int[intArrayToReverse.Length];
            for (int i = intArrayToReverse.Length - 1, j = 0; i >= 0 && j < intArrayToReverse.Length; i--, j++)
            {
                reversedInt[j] = intArrayToReverse[i];
            }

            return reversedInt;
        }


        static string[] ReverseStrArray(string[] strArrayToReverse)
        {
            string[] reversedStr = new string[strArrayToReverse.Length];
            for (int i = strArrayToReverse.Length - 1, j = 0; i >= 0 && j < strArrayToReverse.Length; i--, j++)
            {
                reversedStr[j] = strArrayToReverse[i];
            }

            return reversedStr;
        }


        static char[] ReverseCharArray(char[] charArrayToReverse)
        {
            char[] reversedChr = new char[charArrayToReverse.Length];
            for (int i = charArrayToReverse.Length - 1, j = 0; i >= 0 && j < charArrayToReverse.Length; i--, j++)
            {
                reversedChr[j] = charArrayToReverse[i];
            }

            return reversedChr;
        }


        ////

        //taking wanted part of a string
        static string SubString(string strToGetSub, int beginningIndex, int Length)
        {
            string subText = "";
            for (int i = beginningIndex; i < beginningIndex + Length; i++)
            {
                Console.WriteLine(strToGetSub[i]);
                subText += strToGetSub[i];
            }
            return subText;
        }
        ////

        //trim left and right for blanks
        static void Trim(ref string strToTrim)
        {
            int countRightBlank = 0, countLeftBlank = 0;

            for (int i = 0; i < strToTrim.Length; i++)
            {
                if (strToTrim[i] != ' ')
                {
                    break;
                }
                countRightBlank++;
            }

            for (int i = strToTrim.Length - 1; i >= 0; i--)
            {
                if (strToTrim[i] != ' ')
                {
                    break;
                }
                countLeftBlank++;
            }

            Console.WriteLine(countRightBlank);
            strToTrim = SubString(strToTrim, countRightBlank, strToTrim.Length - countRightBlank);
            strToTrim = SubString(strToTrim, 0, (strToTrim.Length - countLeftBlank));
            Console.WriteLine(strToTrim);

        }
        //Trim end.....

        static string FullTrim(string strToTrim)
        {
            string s;
            Trim(ref strToTrim);
            for (int i = 0; i < strToTrim.Length; i++)
            {
                if (strToTrim[i] == ' ' && strToTrim[i + 1] == ' ')
                {
                    strToTrim = (SubString(strToTrim, 0, i)) + SubString(strToTrim, i + 2, strToTrim.Length - (i + 2));
                }
            }

            return strToTrim;
        }
    }

}
