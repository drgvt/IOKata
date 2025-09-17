global using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите путь к файлу:");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файла здесь нет/ Создаю новый");
            File.WriteAllText(filePath, ""); // создаем пустой файл
        }

        Console.WriteLine("\n=== Содержимое файла ===\"");
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);

        Console.WriteLine("\n=== Запишем инфу ===\"");
        File.WriteAllText(filePath, "Запись произведена!");

        Console.WriteLine("\n=== Новая инфа ===\"");
        content = File.ReadAllText(filePath);
        Console.WriteLine(content);




    }
}

