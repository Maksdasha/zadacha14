using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            string string_input, word_founded = "";
            string[] words, words_copy;
            float count = 0;
            string_input = Console.ReadLine();
            string_input = string_input.ToLower(); //Меняем все заглавные буквы на строчные.
            // Делим строку на слова. Разделители - знаки препинания и пробелы.
            words = string_input.Split(new string[] { " ", ", ", ". ", " - " }, System.StringSplitOptions.RemoveEmptyEntries);
            words_copy = words; //Создаем копию массива слов.
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i == j) //Пропускаем одни и те же слова.
                    {
                        continue;
                    }
                    else
                    {
                        if (String.Equals(words[i], words_copy[j])) //Проверяем слова на совпадения.
                        {
                            count++;
                            word_founded = words[i];
                        }
                    }
                }

            }
            count /= 2;
            Console.WriteLine(count.ToString());
            if (count == 1f)
            {
                Console.WriteLine("Одинаковые слова: {0}", word_founded);
            }
            if (count == 0f)
            {
                Console.WriteLine("Одинаковых слов нет.");
            }
            if (count > 1f)
            {
                Console.WriteLine("Одинаковых слов: {0}", count);
            }
            Console.ReadKey();
        }
    }
}