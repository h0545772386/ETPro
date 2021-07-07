using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETPro.Classes
{
    public class RPriority:IComparable<RPriority>
    {
        public int Id { get; set; }
        public string WorthyNameEng { get; set; }
        public string WorthyNameHeb { get; set; }
        public int CompareTo(RPriority other)
        {
            return Id - other.Id;
        }
    }

    public class RPriorities : List<RPriority>
    {
        public RPriorities()
        {
            this.Add(new RPriority() { Id = 0, WorthyNameEng = "Low", WorthyNameHeb = "נמוכה" });
            this.Add(new RPriority() { Id = 1, WorthyNameEng = "Medium", WorthyNameHeb = "בינוני" });
            this.Add(new RPriority() { Id = 2, WorthyNameEng = "High", WorthyNameHeb = "גבוהה" });
            Sort();
        }
    }
}
