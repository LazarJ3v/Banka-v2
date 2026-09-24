using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Enumi
{
    public enum StatusTransakcije
    {
        [Description("Na čekanju")]
        NaCekanju,
        [Description("Izvršena")]
        Izvrsena,
        [Description("Neuspešna")]
        Neuspesna,
        [Description("Otkazana")]
        Otkazana,
        [Description("Stornirana")]
        Stornirana
    }
}
