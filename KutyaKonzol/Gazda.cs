using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaKonzol
{
    public class Gazda
    {
        public int GazdaID { get; set; }
        public string GazdaNev { get; set; }
        public string GazdaTel { get; set; }

        public Gazda(int gazdaID, string gazdaNev, string gazdaTel)
        {
            GazdaID = gazdaID;
            GazdaNev = gazdaNev;
            GazdaTel = gazdaTel;
        }
    }
}
