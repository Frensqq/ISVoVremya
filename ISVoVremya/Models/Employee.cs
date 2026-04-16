using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVoVremya.Models;

public class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public string secondname { get; set; }
    public int age { get; set; }
    public string post { get; set; }

    public Employee(int id, string name, string secondname, int age, string post)
    {
        this.id = id;
        this.name = name;
        this.secondname = secondname;
        this.age = age;
        this.post = post;
    }
}
