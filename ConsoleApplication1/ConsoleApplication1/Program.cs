using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\admin\Desktop\lab-2-zi-chuan-chu-li-zaxl-1234\Data\Input.txt");
            String line = null;
            while ((line = file.ReadLine()) != null)
            {
                var chars = line.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i].Equals('.') || chars[i].Equals('?') || chars[i].Equals('!')) 
                    { 
                        Console.WriteLine(chars[i]); 
                    }
                    else 
                    { 
                        Console.Write(chars[i]); 
                    }
                }
            }
            Console.Read();
        }
    }
}

