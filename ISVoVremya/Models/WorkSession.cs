using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.Models;

public class WorksSession
{
    public string Id { get; set; }
    public string employeeId { get; set; }
    public DateOnly date { get; set; }
    public TimeOnly startWork { get; set; }
    public TimeOnly endWork { get; set; }
    public double breaks { get; set; }
    public TimeOnly startWorkPlaned { get; set; }
    public TimeOnly endWorkPlaned { get; set; }

    public WorksSession(string id, string employeeId, DateOnly date, TimeOnly startWork, TimeOnly endWork, double breaks, TimeOnly startWorkPlaned, TimeOnly endWorkPlaned)
    {
        Id = id;
        this.employeeId = employeeId;
        this.date = date;
        this.startWork = startWork;
        this.endWork = endWork;
        this.breaks = breaks;
        this.startWorkPlaned = startWorkPlaned;
        this.endWorkPlaned = endWorkPlaned;
    }
}
