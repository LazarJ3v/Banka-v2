using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Enumi
{
    public enum StatusKamate
    {
        [Description("OBRAČUNATO")] Obracunato,
        [Description("ISPLAĆENO")] Isplaceno,
        [Description("KAPITALIZOVANO")] Kapitalizovano
    }
}
