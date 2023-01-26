using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultString = "Пожалуйста, введите предложение, с любыми знаками препинания! (Если не хотите - нажмите Enter.)";
            Console.WriteLine(defaultString);
            string inputString = Console.ReadLine().Trim();

            PrintWords(inputString.Length == 0 ? SplitText(defaultString) : SplitText(inputString) );

            Console.ReadKey();
        }

        /// <summary>
        /// Разделяет строку на слова
        /// </summary>
        /// <param name="str">Предложение со знаками препинания</param>
        /// <returns>Массив строк-слов</returns>
        static string[] SplitText(string str)
        {
            char[] separators = new char[] { ' ', ',', '.', '!', '?', '-', ':', ';', '(', ')', '"' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }

        /// <summary>
        /// Выводит слова через строку
        /// </summary>
        /// <param name="words">Список строк-слов</param>
        static void PrintWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
