using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Enumi
{
    public enum FrekvencijaKapitalizacijeKamate
    {
        [Description("Dnevna")]
        Dnevno = 365,
        [Description("Mesečna")]
        Mesecno = 12,
        [Description("Kvartalna")]
        Kvartalno = 4,
        [Description("Polugodišnja")]
        Polugodisnje = 2,
        [Description("Godišnja")]
        Godisnje = 1
    }
}
