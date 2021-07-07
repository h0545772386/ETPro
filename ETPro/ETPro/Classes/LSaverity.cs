using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETPro.Classes
{
    public class LSaverity:IComparable<LSaverity>
    {
        public int Id { get; set; }
        public string WorthyNameEng { get; set; }
        public string WorthyNameHeb { get; set; }

        public int CompareTo(LSaverity other)
        {
            return Id - other.Id;
        }
    }

    public class LSaverities : List<LSaverity>
    {
        public LSaverities()
        {
            this.Add(new LSaverity() { Id = 1, WorthyNameEng = "Low", WorthyNameHeb = "נמוכה" });
            this.Add(new LSaverity() { Id = 2, WorthyNameEng = "Medium", WorthyNameHeb = "בינוני" });
            this.Add(new LSaverity() { Id = 3, WorthyNameEng = "High", WorthyNameHeb = "גבוהה" });
            Sort();
        }
    }
}
