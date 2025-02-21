using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaKonzol
{
    internal class Fajta
    {
        public int FajtaID { get; set; }
        public string FajtaNev { get; set; }

        public Fajta(int fajtaID, string fajtaNev)
        {
            FajtaID = fajtaID;
            FajtaNev = fajtaNev;
        }
    }
}
