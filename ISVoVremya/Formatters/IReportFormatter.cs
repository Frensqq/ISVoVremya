using ISVoVremya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.Formatters;
public interface IReportFormatter
{
    string Format(WorksReport report);
}
