using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava1
{
    class Ika
    {
        public void laskeika(int nvuosi,int nkk, int svuosi, int skk, out int ikavuosi, out int ikakk)
        {
            int ikakuukausina = (12-skk)+ 12*(nvuosi-svuosi)+nkk;
            ikavuosi= ikakuukausina/12;
            ikakk = ikakuukausina%12;

        }

    }
}
