using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETPro
{
    public class Commu
    {
        public string CommuNameEng { get; set; }
        public string CommuNameHeb { get; set; }
    }

    public class Commus : List<Commu>
    {
        public Commus()
        {
            this.Add(new Commu() { CommuNameEng = "Mobile", CommuNameHeb = "נייד" });
            this.Add(new Commu() { CommuNameEng = "Phone", CommuNameHeb = "טלפון" });
            this.Add(new Commu() { CommuNameEng = "Email", CommuNameHeb = "דוא''ל" });
            this.Add(new Commu() { CommuNameEng = "Fax", CommuNameHeb = "פקס" });
        }
    }
}
