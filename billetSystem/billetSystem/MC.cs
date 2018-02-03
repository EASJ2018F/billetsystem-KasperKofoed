using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billetSystem
{
    public class MC : Køretøj
    {
        public override int KøretøjsPrisen()
        {
            return KøretøjsPris = 125;
        }

        public override int Pris()
        {
            if (Brobizz == true)
            {
                return KøretøjsPris - (KøretøjsPris * 5 / 100);
            }

            else
            {
                return KøretøjsPris;
            }
        }

        public override string KøretøjsBro()
            {
                return "MC";
            }
        }
    }


