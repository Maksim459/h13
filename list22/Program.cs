using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем пользовательский список
        var customList = new List<MyClass>
        {
            new MyClass(3),
            new MyClass(1),
            new MyClass(5)
        };

        // Добавляем новый элемент
        customList.Add(new MyClass(2));

        // Сортируем список по свойству IdNumber
        customList.Sort();

        // Выводим список на экран
        Console.WriteLine("Список после добавления и сортировки:");
        foreach (var item in customList)
        {
            Console.WriteLine($"IdNumber: {item.IdNumber}");
        }
    }
}

class MyClass : IComparable<MyClass>
{
    public int IdNumber { get; }

    public MyClass(int idNumber)
    {
        IdNumber = idNumber;
    }

    public int CompareTo(MyClass other)
    {
        return IdNumber.CompareTo(other.IdNumber);
    }
}
