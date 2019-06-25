/*
 * Communiquer avec une base de données en c-Sharp
 * Crée sur SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/17/2018
 * Besoin de MySql Connector installer sur la machine : https://dev.mysql.com/downloads/connector/net/6.7.html
 * Nécessite d'ajouter la référence MySql.Data
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data; //Utilisation de mysql
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
		String sexe = "Inconnu";
		
		void Button1Click(object sender, EventArgs e)
		{
			if (button1.Text == "Se Connecter") //Si il y a écrit Se Connecter dans le bouton
			{
				cn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=base;UID=root;PWD=root;SslMode=none;"); //Création de la connexion à la base de données
				try
				{
					if(cn.State == ConnectionState.Closed) { cn.Open(); } // Tentative de connexion à la base
					button1.Text = "Se Déconnecter"; // change le message du bouton
					MessageBox.Show("Vous êtes désormais connecté !");
					l_Statut.ForeColor = Color.Green;
					l_Statut.Text = "Vous êtes connecté";
					connexion = true; // la variable booléenne indique la connexion
					b_refresh.Enabled = true ; //Debloque le bouton de rafraichissement
					
					MySqlCommand sql = new MySqlCommand("SELECt MAX(ID) FROM visiteurs", cn); //Commande servant a trouver l'id le plus grand
					string res = Convert.ToString(sql.ExecuteScalar()); // Converti la commande en string tout en l'executant
					l_inscris.Text = res; //Retranscrit le resultat de la commande traduite en string
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
				connexion = false; //etat de connexion
				b_refresh.Enabled = false ; //Bloque le bouton de rafraichissement
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "") //Si nom n'est pas entré alors label d'alerte rouge s'affiche
			{
				l_prenom.Text = "Entrez votre prénom.";
				l_prenom.ForeColor = Color.Red;
			}
			else if (t_nom.Text == "")
			{
				l_nom.Text = "Entrez votre nom de famille.";
				l_nom.ForeColor = Color.Red;
			}
			else if (t_ville.Text == "")
			{
				l_ville.Text = "Entrez le nom de votre ville.";
				l_ville.ForeColor = Color.Red;
			}
			else if (t_code.Text == "")
			{
				l_code.Text = "Entrez votre code postal.";
				l_code.ForeColor = Color.Red;
			}
			else if (t_mail.Text == "")
			{
				l_mail.Text = "Entrez votre email.";
				l_mail.ForeColor = Color.Red;
			}
			else if (t_section.Text == "")
			{
				l_section.Text = "Entrez votre section actuelle.";
				l_section.ForeColor = Color.Red;
			}
			else if (t_etablissement.Text == "")
			{
				l_etablissement.Text = "Entrez votre établissement actuel";
				l_etablissement.ForeColor = Color.Red;
			}
			else
			{
				//On retire toutes les erreurs indiqué dans les labels.
				l_prenom.Text = "";
				l_nom.Text = "";
				l_naissance.Text = "";
				l_code.Text = "";
				l_mail.Text = "";
				l_section.Text = "";
				l_etablissement.Text = "";
				
				if (connexion) //Si on est connecté
				{
					MySqlCommand cmd = new MySqlCommand("INSERT INTO Visiteurs(Prenom, Nom, Sexe, Naissance, Ville, Code, Email, Section, Etablissement, Commentaire) VALUES(@Prenom, @Nom, @Sexe, @Naissance, @Ville, @Code, @Email, @Section, @Etablissement, @Commentaire)", cn); //Envoi de la commande situé entre guillemets
					cmd.Parameters.AddWithValue("@Prenom", textBox1.Text); // Transforme @Prenom en la valeur du nom entré
					cmd.Parameters.AddWithValue("@Nom", t_nom.Text);
					cmd.Parameters.AddWithValue("@Sexe", sexe);
					cmd.Parameters.AddWithValue("@Naissance", t_date.Text);
					cmd.Parameters.AddWithValue("@Ville", t_ville.Text);
					cmd.Parameters.AddWithValue("@Code", int.Parse(t_code.Text)); // Transforme @Code en la valeur du code postal entrer qui est lui même converti en entier
					cmd.Parameters.AddWithValue("@Email", t_mail.Text);
					cmd.Parameters.AddWithValue("@Section", t_section.Text);
					cmd.Parameters.AddWithValue("@Etablissement", t_etablissement.Text);
					cmd.Parameters.AddWithValue("@Commentaire", t_commentaire.Text);
					cmd.ExecuteNonQuery(); //Execution de la commande
					cmd.Parameters.Clear(); // Nettoie les paramètre créé
					MessageBox.Show("Vos données ont été ajouté dans notre base de données. Nous vous remercions de vous être enregistré. \n Programme créé par Florian Moreau");
					
					MySqlCommand sql = new MySqlCommand("SELECt MAX(ID) FROM visiteurs", cn); //Commande servant a trouver l'id le plus grand
					string res = Convert.ToString(sql.ExecuteScalar()); // Converti la commande en string tout en l'executant
					l_inscris.Text = res; //Retranscrit le resultat de la commande traduite en string
				}
				else // Si on est pas connecté
				{
					MessageBox.Show("Vous n'êtes pas connecté à la base de données");
				}
			}
		}
		void rb_male(object sender, EventArgs e)//Evenement si bouton radio M est coché
		{
			sexe = "Homme";
		}
		void rb_female(object sender, EventArgs e)//Evenement si bouton radio F est coché
		{
			sexe = "Femme";
		}
		void t_codeP(object sender, EventArgs e) //Test si le code postal est bien un entier
		{
			try //Essaie de voir si t_code est un entier
			{
				int.Parse(t_code.Text);
				l_code.Text = "";
			}
			catch //Si s'en est pas un
			{
				l_code.Text = "Code postal invalide.";
				l_code.ForeColor = Color.Red;
			}
		}
		
		void B_refreshClick(object sender, EventArgs e)
		{
			MySqlCommand sql = new MySqlCommand("SELECt MAX(ID) FROM visiteurs", cn); //Commande servant a trouver l'id le plus grand
			string res = Convert.ToString(sql.ExecuteScalar()); // Converti la commande en string tout en l'executant
			l_inscris.Text = res; //Retranscrit le resultat de la commande traduite en string
		}
		void B_finClick(object sender, EventArgs e) //Bouton quitter
		{
			DialogResult retour = MessageBox.Show("Etes-vous sur de vouloir quitter l'application ?", "Attention !", MessageBoxButtons.YesNo); //Création d'une boite de dialogue a choix multiple
			if (retour == DialogResult.Yes)
			{
				Application.Exit(); //Fermeture de l'application
			}
		}
	}
}