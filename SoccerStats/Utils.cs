using System;
using System.Collections.Generic;
using System.IO;
using SoccerStats.Models;

namespace SoccerStats
{
	public static class Utils
	{
        public static List<JoueurSessionModel> GetAllJoueurs(List<Session> sessions)
        {
            List<JoueurSessionModel> result = new List<JoueurSessionModel>();
            foreach (Session session in sessions)
            {
                foreach (Joueur joueur in session.Joueurs)
                {
                    if (!result.Exists(x => x.Nom == joueur.Nom))
                    {
                        result.Add(new JoueurSessionModel(){
                                        Nom = joueur.Nom,
                                        NbSessions = 1,
                                        NbSessions2016 = session.Date.Contains("2016") ? 1 : 0,
                                        NbSessions2017 = session.Date.Contains("2017") ? 1 : 0,
                                        NbSessions2018 = session.Date.Contains("2018") ? 1 : 0,
										NbSessions2019 = session.Date.Contains("2019") ? 1 : 0,
                                        NbSessions2020 = session.Date.Contains("2020") ? 1 : 0
                        });
                    }
                    else
                    {
                        JoueurSessionModel joueurSessionModel = result.Find(x => x.Nom == joueur.Nom);
                        joueurSessionModel.NbSessions += 1;
                        joueurSessionModel.NbSessions2016 += session.Date.Contains("2016") ? 1 : 0;
                        joueurSessionModel.NbSessions2017 += session.Date.Contains("2017") ? 1 : 0;
                        joueurSessionModel.NbSessions2018 += session.Date.Contains("2018") ? 1 : 0;
						joueurSessionModel.NbSessions2019 += session.Date.Contains("2019") ? 1 : 0;
                        joueurSessionModel.NbSessions2020 += session.Date.Contains("2020") ? 1 : 0;

                        result.Remove(joueurSessionModel);
                        result.Add(joueurSessionModel);
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
