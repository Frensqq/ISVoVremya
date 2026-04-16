using ISVoVremya.Formatters;
using ISVoVremya.Models;
using ISVoVremya.ReportLogic;
using ISVoVremya.SaveReports;

public class ReportGenerator
{
    private readonly IReportCalculator _calculator;
    private readonly IReportFormatter _formatter;
    private readonly IReportSave _saver;

    public ReportGenerator(
        IReportCalculator calculator,
        IReportFormatter formatter,
        IReportSave saver)
    {
        _calculator = calculator;
        _formatter = formatter;
        _saver = saver;
    }

    // Перезапись файла
    public void GenerateAndSave(WorksSession data, string filePath)
    {
        WorksReport report = _calculator.Calculate(data);
        string formattedData = _formatter.Format(report);
        _saver.SaveStringToFile(formattedData, filePath);

        Console.WriteLine($"Отчёт сохранён (перезапись): {filePath}");
    }

    //  Дозапись в файл
    public void GenerateAndAppend(WorksSession data, string filePath)
    {
        WorksReport report = _calculator.Calculate(data);
        string formattedData = _formatter.Format(report);
        _saver.AppendStringToFile(formattedData, filePath);

        Console.WriteLine($"Отчёт добавлен в файл: {filePath}");
    }
}