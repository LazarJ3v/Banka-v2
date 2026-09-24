using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Enumi
{
    public enum TipTransakcije
    {
        [Description("UPLATA")] Uplata,
        [Description("ISPLATA")] Isplata,
        [Description("TRANSFER")] Transfer,
        [Description("PLAĆANJE_RAČUNA")] PlacanjeRacuna,
        [Description("KONVERZIJA")] Konverzija
    }
}
