using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class StedniUslovPodizanjaPregled
    {
        public int Id;
        public string UslovPodizanja;
        public StedniPregled Stedni;

        public StedniUslovPodizanjaPregled() { }

        public StedniUslovPodizanjaPregled(int id, string uslovPodizanja, StedniPregled stedni)
        {
            this.Id = id;
            this.UslovPodizanja = uslovPodizanja;
            this.Stedni = stedni;
        }
    }
}
