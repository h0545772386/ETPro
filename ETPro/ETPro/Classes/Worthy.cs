using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETPro
{
    public class Worthy
    {
        public string WorthyNameEng { get; set; }
        public string WorthyNameHeb { get; set; }
    }

    public class Wortheis : List<Worthy>
    {
        public Wortheis()
        {
            this.Add(new Worthy() { WorthyNameEng = "E", WorthyNameHeb = "דירוג 5" });
            this.Add(new Worthy() { WorthyNameEng = "D", WorthyNameHeb = "דירוג 4" });
            this.Add(new Worthy() { WorthyNameEng = "C", WorthyNameHeb = "דירוג 3" });
            this.Add(new Worthy() { WorthyNameEng = "B", WorthyNameHeb = "דירוג 2" });
            this.Add(new Worthy() { WorthyNameEng = "A", WorthyNameHeb = "דירוג 1" });
        }
    }
}
