using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TrackScoreExam
{
    public class Generics
    {

            public static void Main(string[] args)
            {


                int[] intArray = { 1, 2, 3, 4 };
                char[] charArray = { 'T', 'E', 'S', 'T' };
                MainClass.toPrint<int>(intArray);
                MainClass.toPrint<char>(charArray);
            }

            public static void toPrint<T>(T[] inputArray)
            {
                foreach (var element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("--------");
            }
        
    }

}
