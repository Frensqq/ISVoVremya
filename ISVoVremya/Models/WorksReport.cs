using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.Models;

public class WorksReport
{
    public int id { get; set; }
    public string employeeId { get; set; }
    public DateOnly date { get; set; }
    public double hoursWorked { get; set; }
    public double overtimeHours { get; set; }
    public int lateMinutes { get; set; }
    public string status { get; set; }

    public WorksReport(int id, string employeeId, DateOnly date, double hoursWorked, double overtimeHours, int lateMinutes, string status)
    {
        this.id = id;
        this.employeeId = employeeId;
        this.date = date;
        this.hoursWorked = hoursWorked;
        this.overtimeHours = overtimeHours;
        this.lateMinutes = lateMinutes;
        this.status = status;
    }
}
