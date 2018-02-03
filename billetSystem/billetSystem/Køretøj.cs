using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billetSystem
{
    public abstract class Køretøj
    {

        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        public bool Brobizz { get; set; }
        public int KøretøjsPris { get; set; }


        public abstract int Pris();
        public abstract string KøretøjsBro();
        public abstract int KøretøjsPrisen();
       


        public int NummerpladeBegrænser()
        {
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Arhh hva? prøv igen");
                
            }
            return Nummerplade.Length;
        }



    }
}
