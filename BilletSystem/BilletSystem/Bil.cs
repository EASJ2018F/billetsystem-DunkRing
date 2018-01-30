using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem
{
    public class Bil
    {
        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

    }
}
