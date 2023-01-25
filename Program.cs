using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimatedText
{
    internal class Program
    {
        static char[] Characters = { 'a', 'A', 'b', 'B', 'c', 'C', 'ç', 'Ç', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'ğ', 'Ğ', 'h', 'H', 'ı', 'I', 'i', 'İ', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'ö', 'Ö', 'p', 'P', 'q','Q','r', 'R', 's', 'S', 'ş', 'Ş', 't', 'T', 'u', 'U', 'ü', 'Ü', 'v', 'V', 'w','W','x','X','y', 'Y', 'z', 'Z',' ',
                            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                            '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'
                         };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string text;
                while (true)
                {
                    Console.Write("Enter anything you want to animate: ");
                    text = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(text)) Console.WriteLine("Wrong Entry! retry.");
                    else break;
                }
                Console.Clear();
                var myTextArray = text.ToCharArray();
                string myText = "";
                for (int i = 0; i < myTextArray.Length; i++)
                {
                    foreach (var item in Characters)
                    {
                        if (item == myTextArray[i])
                        {
                            myText += item;
                            Console.WriteLine(myText);
                            break;
                        }
                        else Console.WriteLine(myText + item);
                        Thread.Sleep(15);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
