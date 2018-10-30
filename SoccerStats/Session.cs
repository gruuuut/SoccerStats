using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{
	public class Session
	{
		public string Date { get; set; }
		public string Lieu { get; set; }
		public List<Joueur> Joueurs { get; set; }
	}
}
