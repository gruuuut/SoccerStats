using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{
    public class JoueurSessionParticipation
    {
        public string Nom { get; set; }

        public List<SessionParticipation> sessions { get; set; }
    }
}
