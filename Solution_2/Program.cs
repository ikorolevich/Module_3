using System.Globalization;

namespace Solution_2
{
    public class myClass
    {
        public static string code (string s)
        {
            string r = null;
            int cntr = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i-1])
                {
                    cntr++;
                }
                else
                {
                    r += Convert.ToString(cntr)+ s[i - 1];
                    cntr = 1;
                }
            }

            r += Convert.ToString(cntr) + s[s.Length-1];

            return r;
        }
        public static string encode(string s) 
        {
            char[] ar = s.ToCharArray();
            string r = null;
            double numOfchars = 0;
            char charToConvert;
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                
                if (i % 2 == 0)
                {
                    numOfchars = Char.GetNumericValue(s[i]); 
                    charToConvert = s[i+1];
                    for (int j = 0; j < numOfchars; j++)
                    {
                        r += charToConvert;
                    }
                }
            }
            return r;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "addddffffggggggggggggbddddddddddddddddddc";
            Console.WriteLine(input);
            string coded = myClass.code(input);
            Console.WriteLine(coded);
            string encoded = myClass.encode(coded);
            Console.WriteLine(encoded);
            return;
            Console.WriteLine("\t{0}",myClass.code("fffffggggggfffff"));
            myClass.code("abc");
            Console.WriteLine("Hello, World!");
        }
    }
}
