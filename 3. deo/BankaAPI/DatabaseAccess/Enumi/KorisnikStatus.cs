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
        [Description("Aktivan")]
        Aktivan,
        [Description("Neaktivan")]
        Neaktivan
    }
}
