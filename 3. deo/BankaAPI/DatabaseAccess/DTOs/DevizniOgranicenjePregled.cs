using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class DevizniOgranicenjePregled
    {
        public int Id { get; set; }
        public string Ogranicenje { get; set; }
        public DevizniPregled Devizni { get; set; }

        public DevizniOgranicenjePregled() { }

        public DevizniOgranicenjePregled(int id, string ogranicenje, DevizniPregled devizni)
        {
            this.Id = id;
            this.Ogranicenje = ogranicenje;
            this.Devizni = devizni;
        }
    }
}
