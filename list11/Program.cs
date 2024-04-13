using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем словарь с 10 записями
        Dictionary<int, string> wordDictionary = new Dictionary<int, string>
        {
            { 1, "apple" },
            { 2, "banana" },
            { 3, "cherry" },
            { 4, "date" },
            { 5, "grape" },
            { 6, "kiwi" },
            { 7, "mango" },
            { 8, "orange" },
            { 9, "pear" },
            { 10, "pineapple" }
        };

        // Получаем итератор с словами длиной более 5 символов
        var filteredWords = GetWordsGreaterThanFiveCharacters(wordDictionary);

        // Создаем массив из 3 случайных слов
        string[] randomWords = new string[3];
        int index = 0;
        foreach (var word in filteredWords)
        {
            if (index >= 3)
                break;
            randomWords[index] = word;
            index++;
        }

        // Выводим случайные слова
        Console.WriteLine("Случайные слова:");
        foreach (var word in randomWords)
        {
            Console.WriteLine(word);
        }
    }

    static IEnumerable<string> GetWordsGreaterThanFiveCharacters(Dictionary<int, string> dictionary)
    {
        foreach (var pair in dictionary)
        {
            if (pair.Value.Length > 5)
            {
                yield return pair.Value;
            }
        }
    }
}