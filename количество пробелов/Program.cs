using System;
/*Написать программу, которая считывает символы с клавиатуры, 
 * пока не будет введена точка. Программа должна
сосчитать количество введенных пользователем пробелов.*/

namespace количество_пробелов
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "", s = "";
            int count = 0;

            while (a != ".")
            {
                s += a;
                a = Console.ReadLine();
            }
            Console.WriteLine(s);
            
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
