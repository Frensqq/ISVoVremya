using ISVoVremya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.Formatters;
public class CsvFormatter : IReportFormatter
{
    public string Format(WorksReport report)
    {
        // Разделитель ; (для csv)
        return $"{report.id};{report.employeeId};{report.date};" +
               $"{report.hoursWorked};{report.overtimeHours};" +
               $"{report.lateMinutes};{report.status}";
    }
}
