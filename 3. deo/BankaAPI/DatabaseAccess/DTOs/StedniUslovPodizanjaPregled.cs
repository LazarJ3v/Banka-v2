using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class StedniUslovPodizanjaPregled
    {
        public int Id { get; set; }
        public string UslovPodizanja { get; set; }
        [JsonIgnore]
        public StedniPregled Stedni { get; set; }

        public StedniUslovPodizanjaPregled() { }

        public StedniUslovPodizanjaPregled(int id, string uslovPodizanja, StedniPregled stedni)
        {
            this.Id = id;
            this.UslovPodizanja = uslovPodizanja;
            this.Stedni = stedni;
        }
    }
}
