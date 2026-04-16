using ISVoVremya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.ReportLogic;


public class ReportCalculator: IReportCalculator
{
    public WorksReport Calculate(WorksSession rawData)
    {
        WorksReport worksReport = new WorksReport(
            0,0,DateOnly.FromDateTime(DateTime.Now),2,2,4,"Complete"
            );

        return worksReport;
    }
}
