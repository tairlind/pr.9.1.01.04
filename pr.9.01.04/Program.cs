using System;
using System.IO;

class TextCalculator
{
    static void Main()
    {
        string a1, a2, result;

        Console.WriteLine("Введите первую строку:");
        a1 = Console.ReadLine();

        Console.WriteLine("Введите вторую строку:");
        a2 = Console.ReadLine();

        result = a1 + a2;

        Console.WriteLine("Результат сцепления строк: " + result);

        LogActions(a1, a2, result);
        SaveResult(result);
    }

    static void LogActions(string a1, string a2, string result)
    {
        string logFileName = "log_" + DateTime.Today.ToString("yyyy-MM") + ".txt";

        using (StreamWriter sw = new StreamWriter(logFileName, true))
        {
            sw.WriteLine("Введенная строка 1: " + a1);
            sw.WriteLine("Введенная строка 2: " + a2);
            sw.WriteLine("Результат сцепления: " + result);
        }

        Console.WriteLine("Лог сохранен в файле: " + logFileName);
    }

    static void SaveResult(string result)
    {
        string resultFileName = "Results/result_" + DateTime.Now.ToString("yyyy-MM") + ".txt";

        using (StreamWriter sw = new StreamWriter(resultFileName))
        {
            sw.WriteLine("Результат сцепления строк: " + result);
        }

        Console.WriteLine("Результат сохранен в файле: " + resultFileName);
        Console.ReadLine();
    }
}