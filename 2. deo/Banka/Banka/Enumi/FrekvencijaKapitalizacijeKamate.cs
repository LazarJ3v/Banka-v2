using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Enumi
{
    public enum FrekvencijaKapitalizacijeKamate
    {
        [Description("Dnevno")]
        Dnevno = 365,
        [Description("Mesečno")]
        Mesecno = 12,
        [Description("Kvartalno")]
        Kvartalno = 4,
        [Description("Polugodišnje")]
        Polugodisnje = 2,
        [Description("Godišnje")]
        Godisnje = 1
    }
}
