using System;
using System.Windows.Forms;

namespace SoccerStats
{
    static class Program
	{
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main()
		{			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Dashboard dashboard = new Dashboard();
			dashboard.LoadData();
			Application.Run(dashboard);
		}        
	}
}
