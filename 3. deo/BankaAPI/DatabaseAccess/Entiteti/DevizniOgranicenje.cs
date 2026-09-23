using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class DevizniOgranicenje
    {
        public virtual int Id { get; set; }
        public virtual string Ogranicenje { get; set; }

        public virtual Devizni PripadaDeviznom { get; set; }

        public DevizniOgranicenje()
        {

        }
    }
}
