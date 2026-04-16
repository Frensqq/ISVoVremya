using ISVoVremya.Models;
using ISVoVremya.ReportLogic;
using ISVoVremya.Formatters;
using ISVoVremya.SaveReports;

namespace ISVoVremya;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ИС «ВоВремя» — Генерация отчёта о рабочем времени ===\n");

        var session = new WorksSession(
            id: 1,                          // ID сессии
            employeeId: 101,                // ID сотрудника
            date: new DateOnly(2024, 1, 15), // Дата
            startWork: new TimeSpan(9,15, 0),   // Фактический приход (опоздал на 20 мин)
            endWork: new TimeSpan(19, 30, 0),    // Фактический уход (переработка 1.5 ч)
            breaks: 1.0,                    // Перерыв 1 час
            startWorkPlaned: new TimeSpan(9, 0, 0),  // Плановое начало
            endWorkPlaned: new TimeSpan(17, 0, 0)    // Плановое окончание
        );

        IReportFormatter formatter = new JsonFormatter();  

        IReportCalculator calculator = new ReportCalculator();
        IReportSave saver = new ReportSave();

        ReportGenerator generator = new ReportGenerator(calculator, formatter, saver);

        string filePath = "report.json"; 

        generator.GenerateAndSave(session, filePath);


        Console.WriteLine("\n--- Содержимое файла ---");
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}