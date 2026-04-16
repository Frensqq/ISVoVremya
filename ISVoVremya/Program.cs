using ISVoVremya.Models;
using ISVoVremya.ReportLogic;
using ISVoVremya.Formatters;
using ISVoVremya.SaveReports;

namespace ISVoVremya;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ИС «ВоВремя» — Генерация отчётов\n");

        IReportCalculator calculator = new ReportCalculator();
        IReportSave saver = new ReportSave();

        // Выбор формата отчёта
        Console.WriteLine("Выберите формат отчёта:");
        Console.WriteLine("1 - JSON");
        Console.WriteLine("2 - YAML");
        Console.WriteLine("3 - CSV");
        Console.Write("Ваш выбор (1-3): ");

        string? choice = Console.ReadLine();

        IReportFormatter formatter;
        string extension;

        switch (choice)
        {
            case "2":
                formatter = new YamlFormatter();
                extension = ".yaml";
                break;
            case "3":
                formatter = new CsvFormatter();
                extension = ".csv";
                break;
            default:
                formatter = new JsonFormatter();
                extension = ".json";
                break;
        }

        Console.WriteLine($"\nВыбран формат: {extension.ToUpper().Replace(".", "")}\n");

        
        ReportGenerator generator = new ReportGenerator(calculator, formatter, saver);

        //Тестовые данные
        var session = new WorksSession(
            1, 101, new DateOnly(2024, 1, 15),
            new TimeSpan(9, 20, 0),  
            new TimeSpan(19, 30, 0),  
            1.0,                      
            new TimeSpan(9, 0, 0),   
            new TimeSpan(18, 0, 0)    
        );

        //Ввод пути для сохранения файла
        Console.Write("Введите путь для сохранения отчёта (без расширения): ");
        string? filePathWithoutExt = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filePathWithoutExt))
        {
            filePathWithoutExt = "report";
            Console.WriteLine($"Путь не указан, используем: {filePathWithoutExt}");
        }

        string filePath = filePathWithoutExt + extension;

        // Сохранение отчёта
        generator.GenerateAndSave(session, filePath);

        Console.WriteLine($"\nСодержимое {filePath}");
        if (File.Exists(filePath))
        {
            Console.WriteLine(File.ReadAllText(filePath));
        }
        else
        {
            Console.WriteLine("Файл не найден!");
        }

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}