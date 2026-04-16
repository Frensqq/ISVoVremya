using ISVoVremya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.ReportLogic;


public class ReportCalculator: IReportCalculator
{
    public WorksReport Calculate(WorksSession data)
    {
        //расчет отработанногшо времени
        double hoursWorked = data.endWork.TotalHours - data.startWork.TotalHours - data.breaks;

        //расчет переработки
        double overtimeHours = 0;

        if (data.endWork > data.endWorkPlaned && data.startWork <= data.startWorkPlaned)
        {
            overtimeHours = (data.endWork.TotalHours - data.endWorkPlaned.TotalHours);
        }
        if (data.startWork < data.startWorkPlaned && data.endWork >= data.endWorkPlaned)
        {
            overtimeHours += (data.startWorkPlaned.TotalHours - data.startWork.TotalHours);
        }


        //Расчет опаздания
        double lateMinutes = 0;
        if (data.startWork > data.startWorkPlaned)
        {
            lateMinutes = data.startWork.TotalMinutes - data.startWorkPlaned.TotalMinutes;
        }

        //Определение статуса
        string status = "Completed";
        if (data.startWork == TimeSpan.Zero && data.endWork == TimeSpan.Zero)
            status = "NotStarted";
        else if (data.endWork == TimeSpan.Zero)
            status = "InProgress";

        return new WorksReport(
            data.Id, data.employeeId,data.date,
            hoursWorked, overtimeHours, lateMinutes, 
            status
        );
    }
}
