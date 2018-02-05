using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billetSystem
{
    public abstract class Køretøjer
    {
        public bool Øresundsbroen { get; set; }
        public bool BrobizzBrugt { get; set; }
        public int KøretøjsPris { get; set; }
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }


        public abstract int NummerPladeBegrænsing();
        public abstract string KøretøjsType();


        public int Pris()
        {
            int køretøjsPris = 0;
            if (KøretøjsType() == "MC")
            {
                køretøjsPris = 125;
            }

            if (KøretøjsType() == "Bil")
            {
                køretøjsPris = 240;
            }

            if (KøretøjsType() == "Øresund MC")
            {
                køretøjsPris = 210;
            }

            if (KøretøjsType() == "Øresund Bil")
            {
                køretøjsPris = 410;
            }

            if (Øresundsbroen && BrobizzBrugt)
            {
                if (KøretøjsType() == "Øresund MC")
                {
                    return 73;
                }

                if (KøretøjsType() == "Øresund Bil")
                {
                    return 161;
                }
            }


            if (BrobizzBrugt)
            {
                return køretøjsPris - (køretøjsPris * 5 / 100);
            }
            return køretøjsPris;
        }






    }
}