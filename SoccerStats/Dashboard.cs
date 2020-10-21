using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using SoccerStats.Models;

namespace SoccerStats
{
    public partial class Dashboard : Form
	{
        public Dashboard()
		{
			InitializeComponent();			
		}

		public void LoadData()
		{
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            lblVersion.Text = string.Format("Version : {0}", version.ToString());

            LoadingUtil loadingUtil = new LoadingUtil();
            List<Session> sessions = loadingUtil.LoadDataFromSource();
            lblNbSessions.Text = sessions.Count.ToString();
            lblDerniereSession.Text = sessions.Last().Date;
		}

        private void btnGenererTopJoueurs_Click(object sender, EventArgs e)
        {
            lvTopJoueurs.Items.Clear();
            LoadingUtil loadingUtil = new LoadingUtil();
            List<Session> sessions = loadingUtil.LoadDataFromSource();

            IOrderedEnumerable<JoueurSessionModel> joueurs = Utils.GetAllJoueurs(sessions).OrderByDescending(x => x.NbSessions);

            int position = 1;
            foreach (JoueurSessionModel joueur in joueurs)
            {
                lvTopJoueurs.Items.Add("N°" + position + " " + joueur.Nom + "(" + joueur.NbSessions.ToString() + ")");
                position++;
            }

            cbAnnee.Items.Clear();
            cbAnnee.Items.Add("2016");
            cbAnnee.Items.Add("2017");
            cbAnnee.Items.Add("2018");
			cbAnnee.Items.Add("2019");
            cbAnnee.Items.Add("2020");
            cbAnnee.Visible = true;
        }

        private void btnGenererJoueursCommuns_Click(object sender, EventArgs e)
        {
            // Attention : le fichier Source ne contient pas les soccers du 12/05/2016 et 18/10/2017
            // En effet pour le premier, que 9 joueurs, et pour le second, Alyo vs Eurogiciel
            LoadingUtil loadingUtil = new LoadingUtil();
            List<List<string>> sessionsV2 = loadingUtil.LoadDataFromSourceV2();

            string generatedFile = Utils.GetElementsCommun(sessionsV2);

            MessageBox.Show(string.Format("Le fichier csv a été généré avec succès. Chemin : {0}", generatedFile), "Message");
        }

        private void cbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAnnee = cbAnnee.SelectedItem.ToString();

            lvTopJoueurs.Items.Clear();
            LoadingUtil loadingUtil = new LoadingUtil();
            List<Session> sessions = loadingUtil.LoadDataFromSource();

            // Attention : ces 3 boucles sont à factoriser, l'année étant le seul élément qui varie d'un if à l'autre.
            IOrderedEnumerable<JoueurSessionModel> joueurs = Utils.GetAllJoueurs(sessions).OrderByDescending(x => x.NbSessions);
            if (selectedAnnee == "2016")
            {
                joueurs = Utils.GetAllJoueurs(sessions).OrderByDescending(x => x.NbSessions2016);
                int position = 1;
                foreach (JoueurSessionModel joueur in joueurs)
                {
                    lvTopJoueurs.Items.Add("N°" + position + " " + joueur.Nom + "(" + joueur.NbSessions2016.ToString() + ")");
                    position++;
                }
            }

            if (selectedAnnee == "2017")
            {
                joueurs = Utils.GetAllJoueurs(sessions).OrderByDescending(x => x.NbSessions2017);
                int position = 1;
                foreach (JoueurSessionModel joueur in joueurs)
                {
                    lvTopJoueurs.Items.Add("N°" + position + " " + joueur.Nom + "(" + joueur.NbSessions2017.ToString() + ")");
                    position++;
                }
            }

            if (selectedAnnee == "2018")
            {
                joueurs = Utils.GetAllJoueurs(sessions).OrderByDescending(x => x.NbSessions2018);
                int position = 1;
                foreach (JoueurSessionModel joueur in joueurs)
                {
                    lvTopJoueurs.Items.Add("N°" + position + " " + joueur.Nom + "(" + joueur.NbSessions2018.ToString() + ")");
                    position++;
                }
            }

			if (selectedAnnee == "2019")
			{
				joueurs = Utils.GetAllJoueurs(sessions).OrderByDescending(x => x.NbSessions2019);
				int position = 1;
				foreach (JoueurSessionModel joueur in joueurs)
				{
					lvTopJoueurs.Items.Add("N°" + position + " " + joueur.Nom + "(" + joueur.NbSessions2019.ToString() + ")");
					position++;
				}
			}

            if (selectedAnnee == "2020")
            {
                joueurs = Utils.GetAllJoueurs(sessions).OrderByDescending(x => x.NbSessions2020);
                int position = 1;
                foreach (JoueurSessionModel joueur in joueurs)
                {
                    lvTopJoueurs.Items.Add("N°" + position + " " + joueur.Nom + "(" + joueur.NbSessions2020.ToString() + ")");
                    position++;
                }
            }
        }

        private void btnSessionsConsecutives_Click(object sender, EventArgs e)
        {
            lvTopJoueurs.Items.Clear();
            LoadingUtil loadingUtil = new LoadingUtil();
            List<Session> sessions = loadingUtil.LoadDataFromSource();

            List<JoueurSessionModel> joueurs = Utils.GetAllJoueurs(sessions);
            List<SessionParticipation> sessionParticipations = new List<SessionParticipation>();
            List<JoueurSessionParticipation> joueurSessionParticipations = new List<JoueurSessionParticipation>();

            foreach (JoueurSessionModel joueur in joueurs)
            {
                SessionParticipation sessionParticipation = new SessionParticipation();
                sessionParticipations.Clear();
                sessionParticipation.NomJoueur = joueur.Nom;
                
                foreach(Session session in sessions)
                {
                    sessionParticipations.Add(new SessionParticipation() { IdSession = session.IdSession, NomJoueur = joueur.Nom, Present = session.Joueurs.Exists(x => x.Nom == joueur.Nom) });
                }

                joueurSessionParticipations.Add(new JoueurSessionParticipation() { Nom = joueur.Nom, sessions = sessionParticipations });
            }

        }
    }
}
