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
            this.SuspendLayout();
            // 
            // lblNbSessionsTitre
            // 
            this.lblNbSessionsTitre.AutoSize = true;
            this.lblNbSessionsTitre.Location = new System.Drawing.Point(12, 9);
            this.lblNbSessionsTitre.Name = "lblNbSessionsTitre";
            this.lblNbSessionsTitre.Size = new System.Drawing.Size(64, 13);
            this.lblNbSessionsTitre.TabIndex = 0;
            this.lblNbSessionsTitre.Text = "Nb sessions";
            // 
            // lblNbSessions
            // 
            this.lblNbSessions.AutoSize = true;
            this.lblNbSessions.Location = new System.Drawing.Point(82, 9);
            this.lblNbSessions.Name = "lblNbSessions";
            this.lblNbSessions.Size = new System.Drawing.Size(73, 13);
            this.lblNbSessions.TabIndex = 1;
            this.lblNbSessions.Text = "lblNbSessions";
            // 
            // lblTopJoueurs
            // 
            this.lblTopJoueurs.AutoSize = true;
            this.lblTopJoueurs.Location = new System.Drawing.Point(82, 34);
            this.lblTopJoueurs.Name = "lblTopJoueurs";
            this.lblTopJoueurs.Size = new System.Drawing.Size(94, 13);
            this.lblTopJoueurs.TabIndex = 3;
            this.lblTopJoueurs.Text = "lblTopJoueursTitre";
            // 
            // lblTopJoueursTitre
            // 
            this.lblTopJoueursTitre.AutoSize = true;
            this.lblTopJoueursTitre.Location = new System.Drawing.Point(12, 34);
            this.lblTopJoueursTitre.Name = "lblTopJoueursTitre";
            this.lblTopJoueursTitre.Size = new System.Drawing.Size(63, 13);
            this.lblTopJoueursTitre.TabIndex = 2;
            this.lblTopJoueursTitre.Text = "Top joueurs";
            // 
            // lvTopJoueurs
            // 
            this.lvTopJoueurs.Location = new System.Drawing.Point(12, 50);
            this.lvTopJoueurs.Name = "lvTopJoueurs";
            this.lvTopJoueurs.Size = new System.Drawing.Size(538, 388);
            this.lvTopJoueurs.TabIndex = 4;
            this.lvTopJoueurs.UseCompatibleStateImageBehavior = false;
            this.lvTopJoueurs.View = System.Windows.Forms.View.List;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(661, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version";
            // 
            // btnGenererTopJoueurs
            // 
            this.btnGenererTopJoueurs.Location = new System.Drawing.Point(662, 49);
            this.btnGenererTopJoueurs.Name = "btnGenererTopJoueurs";
            this.btnGenererTopJoueurs.Size = new System.Drawing.Size(92, 21);
            this.btnGenererTopJoueurs.TabIndex = 6;
            this.btnGenererTopJoueurs.Text = "Top joueurs";
            this.btnGenererTopJoueurs.UseVisualStyleBackColor = true;
            this.btnGenererTopJoueurs.Click += new System.EventHandler(this.btnGenererTopJoueurs_Click);
            // 
            // btnGenererJoueursCommuns
            // 
            this.btnGenererJoueursCommuns.Location = new System.Drawing.Point(662, 91);
            this.btnGenererJoueursCommuns.Name = "btnGenererJoueursCommuns";
            this.btnGenererJoueursCommuns.Size = new System.Drawing.Size(92, 34);
            this.btnGenererJoueursCommuns.TabIndex = 7;
            this.btnGenererJoueursCommuns.Text = "Joueurs communs";
            this.btnGenererJoueursCommuns.UseVisualStyleBackColor = true;
            this.btnGenererJoueursCommuns.Click += new System.EventHandler(this.btnGenererJoueursCommuns_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenererJoueursCommuns);
            this.Controls.Add(this.btnGenererTopJoueurs);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lvTopJoueurs);
            this.Controls.Add(this.lblTopJoueurs);
            this.Controls.Add(this.lblTopJoueursTitre);
            this.Controls.Add(this.lblNbSessions);
            this.Controls.Add(this.lblNbSessionsTitre);
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
    }
}

