using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    class Program
    {
        internal static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            string[] lines = File.ReadAllLines("input.txt");

            string firstLine = lines[0];

            Console.WriteLine(firstLine);

            var wordList = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            wordList.ForEach(a => { Console.WriteLine(a); });

            // davate comentari
            int lineSize = 20;
            string s = string.Empty;
            List<string> newList = new List<string>();

            for (int i = 0; i < wordList.Count; i++)
            {
                string wx = wordList[i];
                if (s.Length + wx.Length < lineSize)
                {
                    if (s.Length == 0)
                    {
                        s += wx;
                    }
                    else
                    {
                        s += " " + wx;
                    }
                }
                else
                {
                    newList.Add(s);
                    s = string.Empty;
                    s += wx;
                }
            }

            wl();
            wl();

            newList.ForEach(a => { Console.WriteLine(a); });

            wl();
            wl();

            wl();
            wl();


            wl(gatanabreba( newList.ToArray(), lineSize, "-"));


            wl();
            wl();

            wl();
            wl();


            wl(staring( gatanabreba(newList.ToArray(), lineSize, " "), "*"));


            wl();
            wl();

            wl("Hello World!");
            Console.ReadKey();
            wl("Hello World!");

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static void wl()
        {
            Console.WriteLine();
        }
        private static void wl(string s)
        {
            Console.WriteLine(s);
        }
        private static void wl(string[] ss)
        {
            for (int i = 0; i < ss.Length; i++)
            {
                Console.WriteLine(ss[i]);
            }
        }

        private static string[] gatanabreba(string[] ss, int zoma, string boloSimlolo)
        {
            //string[] res = new string[] { };
            List<string> res1 = new List<string>();

            for (int i = 0; i < ss.Length; i++)
            {
                string s = ss[i];
                while (s.Length < zoma)
                {
                    s += boloSimlolo;
                }
                res1.Add(s);
            }
            return res1.ToArray() ;
        }

        private static string rl(string s)
        {
            return Console.ReadLine();
        }

        private static string[] staring(string[] ss,  string starSimlolo)
        {
            //string[] res = new string[] { };
            int zoma = ss[0].Length;
            char ch = starSimlolo[0];
            List<string> res1 = new List<string>();
            string fLine = rep(starSimlolo, zoma + 2); // new string(ch, zoma + 2);

            res1.Add(fLine);
            for (int i = 0; i < ss.Length; i++)
            {
                string s = ss[i];
                res1.Add(starSimlolo+ s+starSimlolo);
            }
            res1.Add(fLine);

            return res1.ToArray();
        }

        private static string rep(string s, int zoma)
        {
            return new string(s[0], zoma);
        }

    }
}
