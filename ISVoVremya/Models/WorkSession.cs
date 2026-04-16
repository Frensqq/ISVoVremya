using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.Models;

public class WorksSession
{
    public int Id { get; set; }
    public int employeeId { get; set; }
    public DateOnly date { get; set; }
    public TimeSpan startWork { get; set; }
    public TimeSpan endWork { get; set; }
    public double breaks { get; set; }
    public TimeSpan startWorkPlaned { get; set; }
    public TimeSpan endWorkPlaned { get; set; }

    public WorksSession(int id, int employeeId, DateOnly date, TimeSpan startWork, TimeSpan endWork, double breaks, TimeSpan startWorkPlaned, TimeSpan endWorkPlaned)
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
