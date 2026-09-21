using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Enumi
{
    public enum TipDogadjaja
    {
        [Description("LOGIN")] Login,
        [Description("NEUSPELA_AUTENTIFIKACIJA")] NeuspelaAutentifikacija,
        [Description("PROMENA_PINA")] PromenaPina,
        [Description("BLOKADA_RAČUNA")] BlokadaRacuna,
        [Description("SUMNJIVA_TRANSAKCIJA")] SumnjivaTransakcija
    }
}
