using System.Collections.Generic;
using System.IO;

namespace SoccerStats
{
    public class LoadingUtil
	{
		public List<Session> LoadDataFromSource()
		{
			List<Session> result = new List<Session>();
            // Récupération de toutes les lignes de Source.txt
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

            string[] lines = File.ReadAllLines(Path.Combine(solutionPath, "Source.txt"));

            int idSession = 1;

            foreach (string line in lines)
			{
				int postab1 = line.IndexOf("\t");
				int postab2 = line.IndexOf("\t", postab1 + 1);

				string dateSession = line.Substring(0, postab1);
				string lieuSession = line.Substring(postab1 + 1, postab2 - postab1 - 1);
				string nomJoueur = line.Substring(postab2 + 1);

				if (!result.Exists(x => x.Date == dateSession))
				{
					Session nouvelleSession = new Session();
					nouvelleSession.Date = dateSession;
					nouvelleSession.Lieu = lieuSession;
                    nouvelleSession.IdSession = idSession;
					result.Add(nouvelleSession);

                    idSession++;
				}

				Session sessionCourante = result.Find(x => x.Date == dateSession);
				if (sessionCourante != null)
				{
					Joueur nouveauJoueur = new Joueur();
					nouveauJoueur.Nom = nomJoueur;

					if (sessionCourante.Joueurs == null)
					{
						sessionCourante.Joueurs = new List<Joueur>();
					}
					sessionCourante.Joueurs.Add(nouveauJoueur);
				}

			}

			return result;
		}

		public List<List<string>> LoadDataFromSourceV2()
		{
			List<List<string>> result = new List<List<string>>();
            // Récupération de toutes les lignes de Source.txt
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

            string[] lines = File.ReadAllLines(Path.Combine(solutionPath, "Source.txt"));

            string dateSessionSave = "";

			foreach (string line in lines)
			{
				int postab1 = line.IndexOf("\t");
				int postab2 = line.IndexOf("\t", postab1 + 1);

				string dateSession = line.Substring(0, postab1);
				string lieuSession = line.Substring(postab1 + 1, postab2 - postab1 - 1);
				string nomJoueur = line.Substring(postab2 + 1);

				if (dateSessionSave == "" || dateSession != dateSessionSave)
				{
					dateSessionSave = dateSession;
					List<string> nouvelleSession = new List<string>() { dateSession };
					result.Add(nouvelleSession);
				}

				result.Find(x => x[0] == dateSession).Add(nomJoueur);
			}

			return result;
		}
	}
}
