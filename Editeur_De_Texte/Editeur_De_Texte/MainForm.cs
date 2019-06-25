/*
 * Crée par SharpDevelop.
 * Utilisateur: flori
 * Date: 22/08/2018
 * Heure: 21:21
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Editeur_De_Texte
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		OpenFileDialog ofd = new OpenFileDialog(); // Création un nouveau fichier
		
		void Ts_ouvrirClick(object sender, EventArgs e)
		{
			ofd.Filter = "Texte | *.txt"; //Recherche orienter sur les fichier texte
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				t_principal.Text = File.ReadAllText(ofd.FileName);
			}
		}
		void Ts_sauvegarderClick(object sender, EventArgs e)
		{
			try
			{
				File.WriteAllText(ofd.FileName, t_principal.Text);
				MessageBox.Show("Votre fichier est sauvegardé !");
			}
			catch
			{
				MessageBox.Show("Vous devez d'abord ouvrir un fichier texte.");
			}
		}
		void Ts_nettoyageClick(object sender, EventArgs e)
		{
			t_principal.Text = String.Empty;
		}
	}
}
