using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.SaveReports
{
    public class ReportSave: IReportSave
    {
        public void SaveStringToFile(string formatterDate, string filePath) { 

            File.WriteAllTextAsync( filePath, formatterDate, Encoding.UTF8);

        }

        public void AppendStringToFile(string content, string filePath)
        {
            // Добавляем перенос строки
            if (File.Exists(filePath) && !string.IsNullOrEmpty(File.ReadAllText(filePath)))
            {
                content = Environment.NewLine + content;
            }

            File.AppendAllText(filePath, content, Encoding.UTF8);
        }
    }
}
