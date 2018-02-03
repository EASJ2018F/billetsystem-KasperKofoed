using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billetSystem
{
    public class MC : Køretøj
    {
            public string Nummerplade { get; set; }
            public DateTime Dato { get; set; }

            public override int Pris()
            {
                return 125;
            }

            public override string KøretøjsBro()
            {
                return "MC";
            }
        }
    }


