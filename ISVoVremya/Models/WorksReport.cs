using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.Models;

public class WorksReport
{
    public string Id { get; set; }
    public string EmployeeId { get; set; }
    public DateOnly date { get; set; }
    public TimeOnly startWork { get; set; }
    public TimeOnly endWork { get; set; }
    public double breaks { get; set; }
    public TimeOnly startWorkPlaned { get; set; }
    public TimeOnly endWorkPlaned { get; set; }
}
