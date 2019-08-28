namespace SoccerStats
{
	partial class Dashboard
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblNbSessionsTitre = new System.Windows.Forms.Label();
            this.lblNbSessions = new System.Windows.Forms.Label();
            this.lblTopJoueurs = new System.Windows.Forms.Label();
            this.lblTopJoueursTitre = new System.Windows.Forms.Label();
            this.lvTopJoueurs = new System.Windows.Forms.ListView();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnGenererTopJoueurs = new System.Windows.Forms.Button();
            this.btnGenererJoueursCommuns = new System.Windows.Forms.Button();
            this.cbAnnee = new System.Windows.Forms.ComboBox();
            this.btnSessionsConsecutives = new System.Windows.Forms.Button();
            this.lblDerniereSession = new System.Windows.Forms.Label();
            this.lblDerniereSessionTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNbSessionsTitre
            // 
            this.lblNbSessionsTitre.AutoSize = true;
            this.lblNbSessionsTitre.Location = new System.Drawing.Point(32, 21);
            this.lblNbSessionsTitre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNbSessionsTitre.Name = "lblNbSessionsTitre";
            this.lblNbSessionsTitre.Size = new System.Drawing.Size(169, 32);
            this.lblNbSessionsTitre.TabIndex = 0;
            this.lblNbSessionsTitre.Text = "Nb sessions";
            // 
            // lblNbSessions
            // 
            this.lblNbSessions.AutoSize = true;
            this.lblNbSessions.Location = new System.Drawing.Point(219, 21);
            this.lblNbSessions.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNbSessions.Name = "lblNbSessions";
            this.lblNbSessions.Size = new System.Drawing.Size(197, 32);
            this.lblNbSessions.TabIndex = 1;
            this.lblNbSessions.Text = "lblNbSessions";
            // 
            // lblTopJoueurs
            // 
            this.lblTopJoueurs.AutoSize = true;
            this.lblTopJoueurs.Location = new System.Drawing.Point(219, 81);
            this.lblTopJoueurs.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTopJoueurs.Name = "lblTopJoueurs";
            this.lblTopJoueurs.Size = new System.Drawing.Size(252, 32);
            this.lblTopJoueurs.TabIndex = 3;
            this.lblTopJoueurs.Text = "lblTopJoueursTitre";
            // 
            // lblTopJoueursTitre
            // 
            this.lblTopJoueursTitre.AutoSize = true;
            this.lblTopJoueursTitre.Location = new System.Drawing.Point(32, 81);
            this.lblTopJoueursTitre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTopJoueursTitre.Name = "lblTopJoueursTitre";
            this.lblTopJoueursTitre.Size = new System.Drawing.Size(165, 32);
            this.lblTopJoueursTitre.TabIndex = 2;
            this.lblTopJoueursTitre.Text = "Top joueurs";
            // 
            // lvTopJoueurs
            // 
            this.lvTopJoueurs.Location = new System.Drawing.Point(32, 119);
            this.lvTopJoueurs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lvTopJoueurs.Name = "lvTopJoueurs";
            this.lvTopJoueurs.Size = new System.Drawing.Size(1428, 920);
            this.lvTopJoueurs.TabIndex = 4;
            this.lvTopJoueurs.UseCompatibleStateImageBehavior = false;
            this.lvTopJoueurs.View = System.Windows.Forms.View.List;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(1763, 21);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(112, 32);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version";
            // 
            // btnGenererTopJoueurs
            // 
            this.btnGenererTopJoueurs.Location = new System.Drawing.Point(1765, 117);
            this.btnGenererTopJoueurs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGenererTopJoueurs.Name = "btnGenererTopJoueurs";
            this.btnGenererTopJoueurs.Size = new System.Drawing.Size(245, 50);
            this.btnGenererTopJoueurs.TabIndex = 6;
            this.btnGenererTopJoueurs.Text = "Top joueurs";
            this.btnGenererTopJoueurs.UseVisualStyleBackColor = true;
            this.btnGenererTopJoueurs.Click += new System.EventHandler(this.btnGenererTopJoueurs_Click);
            // 
            // btnGenererJoueursCommuns
            // 
            this.btnGenererJoueursCommuns.Location = new System.Drawing.Point(1765, 217);
            this.btnGenererJoueursCommuns.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGenererJoueursCommuns.Name = "btnGenererJoueursCommuns";
            this.btnGenererJoueursCommuns.Size = new System.Drawing.Size(245, 81);
            this.btnGenererJoueursCommuns.TabIndex = 7;
            this.btnGenererJoueursCommuns.Text = "Joueurs communs";
            this.btnGenererJoueursCommuns.UseVisualStyleBackColor = true;
            this.btnGenererJoueursCommuns.Click += new System.EventHandler(this.btnGenererJoueursCommuns_Click);
            // 
            // cbAnnee
            // 
            this.cbAnnee.FormattingEnabled = true;
            this.cbAnnee.Location = new System.Drawing.Point(485, 62);
            this.cbAnnee.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbAnnee.Name = "cbAnnee";
            this.cbAnnee.Size = new System.Drawing.Size(172, 39);
            this.cbAnnee.TabIndex = 8;
            this.cbAnnee.Visible = false;
            this.cbAnnee.SelectedIndexChanged += new System.EventHandler(this.cbAnnee_SelectedIndexChanged);
            // 
            // btnSessionsConsecutives
            // 
            this.btnSessionsConsecutives.Location = new System.Drawing.Point(1765, 334);
            this.btnSessionsConsecutives.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSessionsConsecutives.Name = "btnSessionsConsecutives";
            this.btnSessionsConsecutives.Size = new System.Drawing.Size(243, 86);
            this.btnSessionsConsecutives.TabIndex = 9;
            this.btnSessionsConsecutives.Text = "Sessions consécutives";
            this.btnSessionsConsecutives.UseVisualStyleBackColor = true;
            this.btnSessionsConsecutives.Click += new System.EventHandler(this.btnSessionsConsecutives_Click);
            // 
            // lblDerniereSession
            // 
            this.lblDerniereSession.AutoSize = true;
            this.lblDerniereSession.Location = new System.Drawing.Point(783, 21);
            this.lblDerniereSession.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDerniereSession.Name = "lblDerniereSession";
            this.lblDerniereSession.Size = new System.Drawing.Size(256, 32);
            this.lblDerniereSession.TabIndex = 11;
            this.lblDerniereSession.Text = "lblDerniereSession";
            // 
            // lblDerniereSessionTitre
            // 
            this.lblDerniereSessionTitre.AutoSize = true;
            this.lblDerniereSessionTitre.Location = new System.Drawing.Point(488, 21);
            this.lblDerniereSessionTitre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDerniereSessionTitre.Name = "lblDerniereSessionTitre";
            this.lblDerniereSessionTitre.Size = new System.Drawing.Size(228, 32);
            this.lblDerniereSessionTitre.TabIndex = 10;
            this.lblDerniereSessionTitre.Text = "Dernière session";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.lblDerniereSession);
            this.Controls.Add(this.lblDerniereSessionTitre);
            this.Controls.Add(this.btnSessionsConsecutives);
            this.Controls.Add(this.cbAnnee);
            this.Controls.Add(this.btnGenererJoueursCommuns);
            this.Controls.Add(this.btnGenererTopJoueurs);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lvTopJoueurs);
            this.Controls.Add(this.lblTopJoueurs);
            this.Controls.Add(this.lblTopJoueursTitre);
            this.Controls.Add(this.lblNbSessions);
            this.Controls.Add(this.lblNbSessionsTitre);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Dashboard";
            this.Text = "Tableau de bord";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNbSessionsTitre;
		private System.Windows.Forms.Label lblNbSessions;
		private System.Windows.Forms.Label lblTopJoueurs;
		private System.Windows.Forms.Label lblTopJoueursTitre;
		private System.Windows.Forms.ListView lvTopJoueurs;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnGenererTopJoueurs;
        private System.Windows.Forms.Button btnGenererJoueursCommuns;
        private System.Windows.Forms.ComboBox cbAnnee;
        private System.Windows.Forms.Button btnSessionsConsecutives;
        private System.Windows.Forms.Label lblDerniereSession;
        private System.Windows.Forms.Label lblDerniereSessionTitre;
    }
}

