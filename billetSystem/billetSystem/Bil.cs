﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billetSystem
{
    public class Bil : Køretøjer
    {
        public override int KøretøjsPris { get; set; }
        public override string Nummerplade { get; set; }
        public override DayOfWeek Dato { get; set; }
        public override bool BrobizzBrugt { get; set; }


        public override string KøretøjsType()
        {
            if (Øresundsbroen)
            {
                return "Øresund Bil";
            }

            return "Bil";
        }

        public override bool Øresundsbroen { get; set; }

        public override int NummerPladeBegrænsing()
        {
            if (Nummerplade.Length > 8)
            {
                throw new ArgumentException("Ops din nummerplade indeholder mere end 7 cifre");
            }

            return Nummerplade.Length;
        }

        public int WeekendRabat()
        {
            int mellemRegning = 0;
            if (!Øresundsbroen)
            {
                KøretøjsPris = 240;
            }

            if (Dato == DayOfWeek.Saturday || Dato == DayOfWeek.Sunday)
            {

                if (!BrobizzBrugt)
                {
                    return KøretøjsPris - (20 * KøretøjsPris / 100);
                }

                if (BrobizzBrugt && !Øresundsbroen)
                {
                    mellemRegning = KøretøjsPris - (20 * KøretøjsPris / 100);
                    KøretøjsPris = mellemRegning - (5 * mellemRegning / 100);
                    return KøretøjsPris;
                }
            }


            return KøretøjsPris;
        }

        public Bil()
        {
            Dato = DateTime.Now.DayOfWeek;
        }

    }
}