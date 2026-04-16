using ISVoVremya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.ReportLogic
{
    interface IReportCalculator
    {
        WorksReport Calculate(WorksSession session);
    }
}
