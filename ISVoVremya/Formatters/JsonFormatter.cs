using ISVoVremya.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ISVoVremya.Formatters;
public class JsonFormatter : IReportFormatter
{
    public string Format(WorksReport report)
    {
        return JsonConvert.SerializeObject(report);
    }
}
