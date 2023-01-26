using System;
using System.Collections.Generic;

namespace Homework5_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultString = "Пожалуйста введите список слов разделенных пробелами";
            Console.WriteLine(defaultString);
            string inputString = Console.ReadLine();

            Console.WriteLine(inputString.Trim().Length == 0 ? Reverse(defaultString) : Reverse(inputString));

            Console.ReadKey();
        }

        /// <summary>
        /// Возвращает строку с переставленными задом наперёд словами
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string Reverse(string text)
        {
            string[] textSplitted = SplitText(text);
            //запоминаем кол-во слов
            int wordsCount = textSplitted.Length;
            //eсли text - одно слово или пусто, сразу вернем его
            if (wordsCount <= 1)
            {
                return text;
            }
            //опустошаем аргумент
            text = "";
            //делаем первое слово с маленькой буквы, а последнее - с большой
            string firstWord = textSplitted[wordsCount - 1];
            string lastWord = textSplitted[0];
            if (!Char.IsUpper(firstWord[0]))
            {
                text = firstWord.Substring(0, 1).ToUpper() + firstWord.Substring(1, firstWord.Length - 1) + " ";
            }
            else
            {
                text = firstWord + " ";
            }
            if (!Char.IsLower(lastWord[0]))
            {
                lastWord = lastWord.Substring(0, 1).ToLower() + lastWord.Substring(1, lastWord.Length - 1);
            }
            for (int i = wordsCount - 2; i > 0; i--)
            {
                text += textSplitted[i] + " ";
            }

            return text += lastWord;
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
    }
}

