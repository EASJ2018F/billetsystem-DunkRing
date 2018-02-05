﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem
{
    public abstract class Køretøjerbaseklasse
    {
        public abstract int pris();
        public abstract string navngivelseAfKøretøj();

        

        public Køretøjerbaseklasse(string NummerPlade, DateTime dato, bool brobizz)
        {


            if (NummerPlade.Length > 7)
            { throw new ArgumentException("Nummerplade er længere end 7 cifre"); }
            Nummerplade = NummerPlade;
            Dato = dato;
            Brobizz = brobizz;
        }

        public int brobizz()
        {
         if(Brobizz==true)
            {
              return  pris() - (pris() * 5) / 100;
            }
        }

        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public bool Brobizz { get; set; }


    }
}
