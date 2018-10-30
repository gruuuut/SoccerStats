using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SoccerStats
{
    public partial class Dashboard : Form
	{
        List<Session> sessions;


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
		}

        private void btnGenererTopJoueurs_Click(object sender, EventArgs e)
        {
            lvTopJoueurs.Items.Clear();
            LoadingUtil loadingUtil = new LoadingUtil();
            List<Session> sessions = loadingUtil.LoadDataFromSource();

            IOrderedEnumerable<Tuple<Joueur, int>> joueurs = Utils.GetAllJoueurs(sessions).OrderByDescending(x => x.Item2);

            foreach (Tuple<Joueur, int> joueur in joueurs)
            {
                lvTopJoueurs.Items.Add(joueur.Item1.Nom + "(" + joueur.Item2.ToString() + ")");
            }
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
    }
}
