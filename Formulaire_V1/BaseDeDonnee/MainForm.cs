/*
 * Communiquer avec une base de données en c-Sharp
 * Crée sur SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/17/2018
 * Besoin de MySql Connector installer sur la machine : https://dev.mysql.com/downloads/connector/net/6.7.html
 * Pour l'exemple, on se connecte sur un environnement de test conçu par : https://www.db4free.net/
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
				connexion = false;
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			if(textBox1.Text == "") //Si nom n'est pas entré
			{
				MessageBox.Show("Entrez votre prénom."); //Message dans une fenetre
			}
			else if (t_nom.Text == "")
			{
				MessageBox.Show("Entrez votre nom de famille.");
			}
			else if (t_date.Text == "") //Si age n'est pas entré
			{
				MessageBox.Show("Entrez votre date de naissance. "); // Message dans une fenêtre
			}
			else if (t_ville.Text == "")
			{
				MessageBox.Show("Entrez le nom de votre ville.");
			}
			else if (t_code.Text == "")
			{
				MessageBox.Show("Entrez votre code postal.");
			}
			else if (t_mail.Text == "")
			{
				MessageBox.Show("Entrez votre email.");
			}
			else if (t_section.Text == "")
			{
				MessageBox.Show("Entrez votre section actuelle.");
			}
			else if (t_etablissement.Text == "")
			{
				MessageBox.Show("Entrez votre établissement actuel");
			}
			else
			{
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
					MessageBox.Show("Vos données ont été ajouté dans la base de données !");
				}
				else // Si on est pas connecté
				{
					MessageBox.Show("Vous n'êtes pas connecté à la base de données");
				}
			}
		}
		void rb_male(object sender, EventArgs e)
		{
			sexe = "Homme";
		}
		void rb_female(object sender, EventArgs e)
		{
			sexe = "Femme";
		}
	}
}