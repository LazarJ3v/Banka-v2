using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Enumi
{
    enum KorisnikStatus
    {
        [Description("AKTIVAN")]
        Aktivan,
        [Description("NEAKTIVAN")]
        Neaktivan
    }
}
