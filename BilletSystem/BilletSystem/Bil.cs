﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem
{
    public class Bil : Køretøjerbaseklasse
    {
        public Bil(string NummerPlade, DateTime dato) : base(NummerPlade, dato)
        {

        }

        public override int pris()
        {
            return 240;
        }

        public override string navngivelseAfKøretøj()
        {
            return "Bil";
        }
    }
}
