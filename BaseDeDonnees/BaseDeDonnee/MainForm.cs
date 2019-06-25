/*
 * Communiquer avec une base de données en c-Sharp
 * Crée sur SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/17/2018
 * Besoin de MySql Connector installer sur la machine : https://dev.mysql.com/downloads/connector/net/6.7.html
 * Pour l'exemple, on se connecte sur une base créee au préalable en local
 * Nécessite d'ajouter la référence MySql.Data
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient; // Utilisation de MySql

namespace BaseDeDonnees
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		MySqlConnection cn; // Variable de connexion
		bool connexion = false; // Vérification booléen de la connexion
		
		void Button1Click(object sender, EventArgs e)
		{
			if (button1.Text == "Se Connecter") //Si il y a écrit Se Connecter dans le bouton
			{
				String server = t_server.Text;
				String basedonnee = t_base.Text;
				String user = t_user.Text;
				String pass = t_pass.Text;
				cn = new MySqlConnection("SERVER="+server+";DATABASE="+basedonnee+";UID="+user+";PWD="+pass+";SslMode=none;"); //Création de la connexion à la base de données
				try
				{
					if(cn.State == ConnectionState.Closed) { cn.Open(); } // Tentative de connexion à la base
					button1.Text = "Se Déconnecter"; // change le message du bouton
					MessageBox.Show("Vous êtes désormais connecté !");
					l_Statut.ForeColor = Color.Green;
					l_Statut.Text = "Vous êtes connecté";
					g_command.Enabled = true; //Déverrouille le groupe de commande
					connexion = true; // la variable booléenne indique la connexion
				}
				catch (Exception ex) { MessageBox.Show(ex.Message); } //Afficher message d'erreur s'il y en a un
			}
			else 
			{
				cn.Close(); // déconnexion
				button1.Text = "Se Connecter";
				MessageBox.Show("Vous êtes désormais déconnecté !");
				l_Statut.Text = "Vous êtes déconnecté";
				l_Statut.ForeColor = Color.Red;
				g_command.Enabled = false; //Verrouille le groupe de commande
				connexion = false;
			}
		}
		void b_envoi(object sender, EventArgs e)
		{
			String table = t_table.Text;
			String colonne = t_colonne.Text;
			try //on essaie d'envoyer la requête
			{
			MySqlCommand sql = new MySqlCommand("SELECt "+colonne+" FROM "+table, cn); //Commande servant a trouver l'id le plus grand
			String res = Convert.ToString(sql.ExecuteScalar());
			MessageBox.Show(res);
			}
			catch (Exception ex) //Si sa marche pas, on indique que cela ne fonctionne pas ainsi que l'erreur
			{
				MessageBox.Show("Table invalide !");
				MessageBox.Show(ex.Message);
			}
		}
	}
}