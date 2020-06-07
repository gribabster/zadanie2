using System;
using static System.Convert;
using static System.Console;


namespace Zadanie2
{


    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1  \n2 \n3   ");
            int n = ToInt32(ReadLine());
            if (n == 1)
            {
                string s = ReadLine();
                int chchet = 0;
                int a = s.IndexOf("f");
                for (int i = a + 1; i < s.Length; i++)
                {
                    string p = (s[i] + "");
                    if (String.Compare("f", p) == 0)
                    {
                        WriteLine(i);
                        chchet++;
                        break;
                    }

                }
                if (a < 0) WriteLine(-2);
                else if (chchet == 0) WriteLine(-1);
            }
            else if (n == 2)
            {
                string s = ReadLine();

                string rez = "";

                string[] rus = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
                string[] eng = { "A", "B", "V", "G", "D", "E", "E", "ZH", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "KH", "TS", "CH", "SH", "SHCH", "", "Y", "", "E", "YU", "YA" };


                for (int j = 0; j < s.Length; j++)
                {
                    int i = 0;
                    while (i < rus.Length)
                    {

                        string a = s[j] + "";
                        if (String.Compare(a, rus[i]) == 0)
                        {
                            rez = rez + eng[i];
                            i++;
                        }
                        else i++;
                    }
                }
                WriteLine(rez);
            }
            else if (n == 3)
            {
                string s = ReadLine();
                int a1 = s.IndexOf("f");
                int a2 = s.LastIndexOf("f");
                string prom = "";
                for (int i = 0; i < s.Length; i++)
                {
                    string g = (s[i] + "");
                    if (String.Compare("f", g) == 0 && i != a1 && i != a2)
                    {
                        prom = prom + "F";
                    }
                    else prom = prom + s[i];
                }
                WriteLine(prom);
            }
        }
    }
}
