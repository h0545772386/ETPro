using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETPro
{
    public class Status
    {
        public string StatusNameEng { get; set; }
        public string StatusNameHeb { get; set; }
    }

    public class Statuses : List<Status>
    {
        public Statuses()
        {
            this.Add(new Status() { StatusNameEng = "Active", StatusNameHeb = "פעיל" });
            this.Add(new Status() { StatusNameEng = "InActive", StatusNameHeb = "לא פעיל" });
        }
    }
}
