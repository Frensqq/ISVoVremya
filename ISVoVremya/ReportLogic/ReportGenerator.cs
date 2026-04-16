using ISVoVremya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.ReportLogic;

using global::ISVoVremya.Formatters;
using global::ISVoVremya.SaveReports;


public class ReportGenerator
{
    private readonly IReportCalculator _calculator;
    private readonly IReportFormatter _formatter;
    private readonly IReportSave _saver;

    // Конструктор для внедрения зависимостей (DIP)
    public ReportGenerator(
        IReportCalculator calculator,
        IReportFormatter formatter,
        IReportSave saver)
    {
        _calculator = calculator;
        _formatter = formatter;
        _saver = saver;
    }

    // Основной метод: принимает сырые данные и путь к файлу
    public void GenerateAndSave(WorksSession sessionData, string filePath)
    {
        // 1. Рассчёт отчёта
        WorksReport report = _calculator.Calculate(sessionData);

        // 2. Форматирование в нужный тип
        string formattedContent = _formatter.Format(report);

        // 3. Сохранение в файл
        _saver.SaveStringToFile(formattedContent, filePath);

        // 4. Вывод в консоль (опционально, для обратной связи)
        Console.WriteLine($"Отчёт сохранён в файл: {filePath}");
        Console.WriteLine($"Сотрудник: {sessionData.employeeId}, Дата: {sessionData.date}");
        Console.WriteLine($"Отработано: {report.hoursWorked} ч., Опоздание: {report.lateMinutes} мин.");
    }
}
