using ISVoVremya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.SaveReports
{
    public interface IReportSave
    {
        void SaveStringToFile(string formatterData, string filePath);

        void AppendStringToFile(string formatterData, string filePath);
    }
}
