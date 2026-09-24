using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Enumi
{
    public enum TipRacuna
    {
        Svi,
        [Description("TEKUCI")]
        Tekuci,
        [Description("DEVIZNI")]
        Devizni,
        [Description("STEDNI")]
        Stedni,
        [Description("ZIRO")]
        Ziro,
        [Description("OSTALI")]
        Ostali
    }
}
