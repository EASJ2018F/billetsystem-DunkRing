using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem
{
    public class MC : Køretøjerbaseklasse
    {

        public MC(string NummerPlade, DateTime dato) : base(NummerPlade, dato)
        {

        }

        public override int pris()
        {
            return 125;
        }

        public override string navngivelseAfKøretøj()
        {
            return "MoterCykel";
        }
    }
}
