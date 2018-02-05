using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billetSystem
{
    public class MC : Køretøjer
    {
        public override string KøretøjsType()
        {
            if (Øresundsbroen)
            {
                return "Øresund MC";
            }

            return "MC";
        }

        public override int NummerPladeBegrænsing()
        {

            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade er længere end 7 cifrer");
            }

            return Nummerplade.Length;
        }
    }
}


