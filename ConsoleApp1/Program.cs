using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.PigIt("Pig latin is cool");
        }
    }

    public class Kata
    {
        public static string PigIt(string str)
        {
            string[] str1 = str.Split(' ');
            string res = "";
            for(int i = 0; i < str1.Length; i++)
            {
                if (str1[i].Length != 1)
                {
                    res += str1[i].Substring(1, str1[i].Length - 1) + str1[i][0] + "ay" + " ";
                }
                else
                {
                    res += str1[i];
                }
            }
            return res.TrimEnd(' ');
        }
    }
}
