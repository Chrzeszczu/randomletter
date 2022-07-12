using System;

namespace RandomLetter // Note: actual namespace depends on the project name.
{
    public class RanLetterGenerator
    {
        public static void Main(string[] args)
        {
            string chars = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            Console.WriteLine(chars[num]);
            string str = Char.ToString(chars[num]);
            File.WriteAllText(@"C:\Users\michal.chrzeszczyk\Desktop\Jenkins_Workspace\rLetter.txt", str);
        }
    }
}