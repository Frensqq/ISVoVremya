using ISVoVremya.Models;
using YamlDotNet.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ISVoVremya.Formatters;
public class YamlFormatter : IReportFormatter
{
    public string Format(WorksReport report)
    {
        var serializer = new SerializerBuilder().Build();
        return serializer.Serialize(report);
    }
}