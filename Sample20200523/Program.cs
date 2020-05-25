using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;
using System.Globalization;
using System.Net.Http.Headers;

namespace Sample20200523
{
    class Program
    {
        static void Main(string[] args)
        {
            //2020.05.25
            Console.WriteLine("文字列を2つ入力して下さい。");
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            var cultureinfo = new CultureInfo("ja-jp");

            //1 - 大文字・小文字を区別する
            if (string.Compare(str1, str2, ignoreCase: true) == 0)
            {
                Console.WriteLine("Upper/Lower Check---str1 & str2 is Equal");
            }
            else
            {
                Console.WriteLine("Upper/Lower Check---str1 & str2 is Not Equal");
            }

            //2 - ひらがな・カタカナを区別する
            if (string.Compare(str1, str2, cultureinfo, CompareOptions.IgnoreKanaType) == 0)
            {
                Console.WriteLine("Kana Check---str1 & str2 is Equal");
            }
            else
            {
                Console.WriteLine("Kana Check---str1 & str2 is Not Equal");
            }

            //3 - 全角・半角を区別する
            if (string.Compare(str1, str2, cultureinfo, CompareOptions.IgnoreWidth) == 0)
            {
                Console.WriteLine("Width Check---str1 & str2 is Equal");
            }
            else
            {
                Console.WriteLine("Width Check---str1 & str2 is Not Equal");
            }


        }
       
    }
}
