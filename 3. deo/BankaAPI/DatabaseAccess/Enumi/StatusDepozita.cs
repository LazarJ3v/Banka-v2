using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Enumi
{
    public enum StatusDepozita
    {
        [Description("Aktivan")] Aktivan,
        [Description("Istekao")] Istekao,
        [Description("Raskinut")] Raskinut
    }
}
