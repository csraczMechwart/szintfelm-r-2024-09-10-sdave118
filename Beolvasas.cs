using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class FociAdatok
    {
        public FociAdatok(int fordulo, int hazaiGolok, int vendegGolok, int elsoFelidoGolok, int marsodikFelidoGolok, string hazaiCsapatNev, string vendegCSapatNev)
        {
            Fordulo = fordulo;
            HazaiGolok = hazaiGolok;
            VendegGolok = vendegGolok;
            ElsoFelidoGolok = elsoFelidoGolok;
            MarsodikFelidoGolok = marsodikFelidoGolok;
            HazaiCsapatNev = hazaiCsapatNev;
            VendegCSapatNev = vendegCSapatNev;
        }

        public int Fordulo {  get; set; } 
        public int HazaiGolok { get; set; }
        public int VendegGolok { get; set; }
        public int ElsoFelidoGolok { get; set; }
        public int MarsodikFelidoGolok { get; set; }
        public string HazaiCsapatNev {  get; set; }
        public string VendegCSapatNev { get; set; }




    }
}
