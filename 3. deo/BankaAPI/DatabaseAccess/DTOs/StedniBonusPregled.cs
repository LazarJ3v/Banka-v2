using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class StedniBonusPregled
    {
        public int Id;
        public string Bonus;
        public StedniPregled Stedni;

        public StedniBonusPregled() { }

        public StedniBonusPregled(int id, string bonus, StedniPregled stedni)
        {
            this.Id = id;
            this.Bonus = bonus;
            this.Stedni = stedni;
        }
    }
}
