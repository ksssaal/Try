using System;
using System.Text;
 
namespace Register
{
    class Register
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            str = str.ToLower();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str[0].ToString().ToUpper());
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 2]) != -1)
                {
                    stringBuilder.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(str[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}