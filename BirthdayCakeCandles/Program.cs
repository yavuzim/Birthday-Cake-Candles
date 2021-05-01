using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace BirthdayCakeCandles
{
    class Program
    {
        public static int BirthdayCakeCandles(List<int> candles)
        {
            int big = candles[0], sayac = 0;
            List<int> bigCandles = new List<int>();
            for (int i = 0; i < candles.Count; i++)
            {   
                if (big < candles[i])
                { 
                    sayac = i;
                    big = candles[i];
                }
                if (i + 1 == candles.Count)
                {
                    bigCandles.Add(big);
                    candles.RemoveAt(sayac);
                    for (int j = 0; j < candles.Count; j++)
                    {
                        if (big == candles[j])
                        {
                            bigCandles.Add(candles[j]);
                        }
                    }
                }
            }
            return bigCandles.Count;
        }
        static void Main(string[] args)
        {

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = BirthdayCakeCandles(candles);
            Console.Write(result + " Tane Mum Üfleyecek");
            Console.ReadLine();
        }
    }
}
