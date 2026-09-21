using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Enumi
{
    public enum StatusKredita
    {
        [Description("Aktivan")] Aktivan,
        [Description("Otplaćen")] Otplacen,
        [Description("U kašnjenju")] UKasnjenju,
        [Description("Raskinut")] Raskinut
    }
}
