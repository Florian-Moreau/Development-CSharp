/*
 * Programme : Nombre mystère
 * Crée sur SharpDevelop.
 * Utilisateur: Florian Moreau
 * Date: 15/08/2018
 */
using System;

namespace Nombre_Mystère
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Initialisation des variables
			string nom = "";
			int nombre;
			int compteur = 0;;
			int random;// Nombre choisi au hasard
			Random alea = new Random();
			random = alea.Next(0, 100);
			
			//Début du dialogue
			Console.WriteLine("Bonjour, qui es tu ?\n");
			
			nom = Console.ReadLine();
			
			Console.WriteLine("Enchanté "+nom+" !\nBienvenue dans le programme de test du logiciel SharpDevelop version 5.1.\n\n");
			
			//Début du jeu du nombre mystère
			Console.Clear();
			Console.WriteLine("Jouons au jeu du nombre mystère "+nom+" \n\n");
			compteur++;
			Console.WriteLine("Manche "+compteur+"\n\n");
			Console.WriteLine("Saisir un nombre entre 0 et 100 : \n");
			nombre = Convert.ToInt32(Console.ReadLine()); //Il faut convertir Console.Readline en int avec la commande Convert.ToInt32
			while (nombre != random)
			{
				compteur++;
				if (nombre < random)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Le nombre est plus grand que "+nombre+"\n\n");
				}
				if (nombre >random)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Le nombre est plus petit que "+nombre+"\n\n");
				}
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Manche "+compteur+"\n\n");
				Console.WriteLine("Saisir un nombre entre 0 et 100 : \n");
				nombre = Convert.ToInt32(Console.ReadLine()); //Il faut convertir Console.Readline en int avec la commande Convert.ToInt32
			}
			
			if (compteur==1)
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Victoire en "+compteur+" coup !\n\n Tu as un talent monstrueux "+nom+" !");
			}
			else
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Victoire ! Tu as gagné en "+compteur+" manches "+nom+" !");
			}
			
			Console.ReadKey(); //Fait une pause du programme. Appuyer sur n'importe quelle touche pour continuer.
		}
	}
}