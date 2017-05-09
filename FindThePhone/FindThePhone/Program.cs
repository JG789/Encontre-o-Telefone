using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThePhone
{
    class Program
    {
        public static string letters = "";
        public static int nCharacters = 30;


        static void Main(string[] args)
        {
            

            while (letters != null)
            {
                Console.WriteLine("Insira uma frase:");
                letters = Console.ReadLine().ToUpper();

                if(letters.Length > nCharacters)
                {
                    letters = letters.Substring(0, nCharacters);
                    
                }

                Conversion();
            }
       
        }

        public static void Conversion()
        {
            letters = letters.Replace("A", "2");
            letters = letters.Replace("B", "2");
            letters = letters.Replace("C", "2");
            letters = letters.Replace("D", "3");
            letters = letters.Replace("E", "3");
            letters = letters.Replace("F", "3");
            letters = letters.Replace("G", "4");
            letters = letters.Replace("H", "4");
            letters = letters.Replace("I", "4");
            letters = letters.Replace("J", "5");
            letters = letters.Replace("K", "5");
            letters = letters.Replace("L", "5");
            letters = letters.Replace("M", "6");
            letters = letters.Replace("N", "6");
            letters = letters.Replace("O", "6");
            letters = letters.Replace("P", "7");
            letters = letters.Replace("Q", "7");
            letters = letters.Replace("R", "7");
            letters = letters.Replace("S", "7");
            letters = letters.Replace("T", "8");
            letters = letters.Replace("U", "8");
            letters = letters.Replace("V", "8");
            letters = letters.Replace("W", "9");
            letters = letters.Replace("X", "9");
            letters = letters.Replace("Y", "9");
            letters = letters.Replace("Z", "9");
            Console.WriteLine("Este é o número de telefone, equivalente a sua frase:");
            Console.WriteLine(letters);
        }
    }
}
