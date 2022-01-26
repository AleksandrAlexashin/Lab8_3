using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string put = "lab8_3.txt";
            int str = 0;
            string s = "";
            string[] textMass;
            string text = "";
            string text1 = "";



            int symbol = 0;
            using (StreamReader sr1 = new StreamReader(put))
            {
                while (sr1.Peek() >= 0)
                {
                    str++;
                   sr1.ReadLine();


                }
                Console.WriteLine("Количество строк равно {0}", str);




            }
                        
            StreamReader sr = new StreamReader(put);
            {
               

                while (sr.EndOfStream != true)
                {
                    s += sr.ReadLine();
                }
                textMass = s.Split(' ');
                Console.WriteLine("Количество слов равно {0}", textMass.Length);
                
            }
            using (StreamReader sr2 = new StreamReader(put))
            {

                while ((text = sr2.ReadLine()) != null)
                {

                    text1 = Regex.Replace(text, @" ", "");
                    symbol += text1.Length;

                }

                Console.WriteLine("Количество символов равно {0}", symbol);

            }







            Console.ReadKey();
        }
        
    } 
}
