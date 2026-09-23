using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class StedniBonusPregled
    {
        public int Id { get; set; }
        public string Bonus { get; set; }
        public StedniPregled Stedni { get; set; }

        public StedniBonusPregled() { }

        public StedniBonusPregled(int id, string bonus, StedniPregled stedni)
        {
            this.Id = id;
            this.Bonus = bonus;
            this.Stedni = stedni;
        }
    }
}
