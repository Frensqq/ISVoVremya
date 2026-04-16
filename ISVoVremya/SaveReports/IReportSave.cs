using ISVoVremya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.SaveReports
{
    internal interface IReportSave
    {
        void SaveStringToFile(WorksSession session);
    }
}
