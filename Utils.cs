using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{
	public static class Utils
	{
		public static List<Tuple<Joueur, int>> GetAllJoueurs(List<Session> sessions)
		{
			List<Tuple<Joueur, int>> result = new List<Tuple<Joueur, int>>();
			foreach (Session session in sessions)
			{
				foreach (Joueur joueur in session.Joueurs)
				{
					if (!result.Exists(x => x.Item1.Nom == joueur.Nom))
					{
						result.Add(new Tuple<Joueur, int>(joueur, 1));
					}
					else
					{
						Tuple<Joueur, int> tuple = result.Find(x => x.Item1.Nom == joueur.Nom);
						var nom = tuple.Item1;
						var nbOccurence = tuple.Item2 + 1;

						result.Remove(tuple);
						result.Add(new Tuple<Joueur, int>(nom, nbOccurence));
					}
				}
			}
			return result;
		}

        /// <summary>
        /// Génération du csv d'éléments commun
        /// </summary>
        /// <param name="listeSessions"></param>
		public static string GetElementsCommun(List<List<string>> listeSessions)
		{			
			int nbSessions = listeSessions.Count;
			int nbCouples = (nbSessions) * (nbSessions - 1) / 2;
			
			string[] couples = new string[nbCouples];
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            string fullGeneratedPathFile = Path.Combine(solutionPath, string.Format("Result{0}.csv", SuffixNow()));
            StreamWriter file = new StreamWriter(fullGeneratedPathFile);

            int i = 1;
			int j = 2;
			int compteur = 0;
			int nbCommun = 0;

			while (i <= j && j <= nbSessions)
			{
				nbCommun = GetNbCommun(listeSessions[i - 1], listeSessions[j - 1]);

				string ligneCsv = string.Concat(listeSessions[i - 1][0], ",", listeSessions[j - 1][0], ",", nbCommun);
				couples[compteur] = ligneCsv;
				file.WriteLine(ligneCsv);
				file.Flush();

				j++;
				if (j > nbSessions)
				{
					i++;
					j = i + 1;
				}
				compteur++;
			}

            return fullGeneratedPathFile;
        }

		private static string SuffixNow()
		{
			return string.Concat(DateTime.Now.Year,
								ToTwoDigits(DateTime.Now.Month),
								ToTwoDigits(DateTime.Now.Day),
								"_",
								ToTwoDigits(DateTime.Now.Hour),
								ToTwoDigits(DateTime.Now.Minute),
								ToTwoDigits(DateTime.Now.Second));
		}

		/// <summary>
		/// Rajoute un zéro devant un chiffre
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		private static string ToTwoDigits(int i)
		{
			string result = i.ToString();
			if (i >= 0 && i < 10)
			{
				result = string.Concat("0", result);
			}
			return result;
		}

		private static int GetNbCommun(List<string> str1, List<string> str2)
		{
			int result = 0;

			foreach (string s in str1)
			{
				if (str2.Contains(s))
				{
					result++;
				}
			}

			return result;
		}
	}
}
