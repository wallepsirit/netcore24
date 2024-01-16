using lab06_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_3
{
    public class student()
    {
public string firstname { get; set; }
        public string lastname { get; set; }
        public bool gender { get; set; }
        public double avg { get; set; }

    }
    {
    }
}List<student> std = new List<student>();
std.Add(new student("nguyen", "van a", 0, 5.2));
std.Add(new"nuyen","van b",1,5.3));
std.Add(new student("nguyen", 0, 5.3));
foreach (var item in std)
    console.writeline("" + item);

