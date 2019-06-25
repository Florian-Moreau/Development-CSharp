/*
 * Crée par SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/16/2018
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
	public partial class MainForm : Form
	{
		//Déclaration des variables
		//Les vitesses
		int playerSpeed = 7;
		int ballSpeed;
		
		//Localisation de la balle
		int bVelX = 3;
		int bVelY = 3;
		
		//Localisation des joueurs
		int p1Vel;
		int p2Vel;
		
		//Score des joueurs
		int p1ScoreInt;
		int p2ScoreInt;
		
		//Temps de pause
		bool pause = false;
		
		public MainForm()
		{
			InitializeComponent();
		}
		void Timer1Tick(object sender, EventArgs e) //Forme : Timer1
		{
			if (!pause) //Pas de pause alors..
			{
				ball.Location = new Point(ball.Location.X + bVelX, ball.Location.Y + bVelY); //Balle se déplace
				player1.Location = new Point (player1.Location.X + p1Vel, player1.Location.Y); // Joueur 1 se déplace
				player2.Location = new Point (player2.Location.X + p2Vel, player2.Location.Y); // Joueur 2 se déplace
			}
			
			if (ball.Location.Y < 0) // si la balle sort côté joueur 2
			{
				p1ScoreInt++; //Score joueur 1 est incrémenté de 1
				ball.Location = new Point(this.Width / 2, this.Height / 2); //Balle retour au milieu
			}
			if (ball.Location.Y > this.Height) // Si la balle sort côté joueur 1
			{
				p2ScoreInt++; //Score joueur 2 est incrémenté de 1
				ball.Location = new Point(this.Width / 2, this.Height / 2); // Balle retour au milieu
			}
			
			if (ball.Location.X > player1.Location.X && ball.Location.X + ball.Width < player1.Location.X + player1.Width && ball.Location.Y + ball.Height > player1.Location.Y) //Si la balle touche le joueur 1
			{
				bVelY *= -1;
			}
			if (ball.Location.X > player2.Location.X && ball.Location.X + ball.Width < player2.Location.X + player2.Width && ball.Location.Y < player2.Location.Y + player2.Height) //Si la balle touche le joueur 2
			{
				bVelY *= -1;
			}
			
			if (ball.Location.X < 0) // Si la balle touche le côté
			{
				bVelX *= -1; // Balle retour au milieu
			}
			if (ball.Location.X + ball.Width > this.Width) // Si la balle touche l'autre côté
			{
				bVelX *= -1; // Balle retour au milieu
			}
			
			p1Score.Text = p1ScoreInt.ToString(); //Ecrit le score de joueur 1 dans le label correspondant
			p2Score.Text = p2ScoreInt.ToString(); //Ecrit le score de joueur 2 dans le label correspondant
			
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right) //Si flèche de droite est appuyé
			{
				p1Vel = playerSpeed;
			}
			else if (e.KeyCode == Keys.Left) //Si flèche de gauche est appuyé
			{
				p1Vel = -playerSpeed;
			}
			else if (e.KeyCode == Keys.D) //Si touche D est appuyé
			{
				p2Vel = playerSpeed;
			}
			else if (e.KeyCode == Keys.Q) //Si touche Q est appuyé
			{
				p2Vel = -playerSpeed;
			}
			else if (e.KeyCode == Keys.P) //Si touche P est appuyé
			{
				if (!pause) //Si jeu non en pause
				{
					pause = true;
				}
				else if (pause) //Si jeu en pause
				{
					pause = false;
				}
			}
		}
		void MainFormKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right) //Si flèche de droite est appuyé
			{
				p1Vel = 0;
			}
			else if (e.KeyCode == Keys.Left) //Si flèche de gauche est appuyé
			{
				p1Vel = 0;
			}
			else if (e.KeyCode == Keys.D) //Si touche D est appuyé
			{
				p2Vel = 0;
			}
			else if (e.KeyCode == Keys.Q) //Si touche Q est appuyé
			{
				p2Vel = 0;
			}
		}
	}
}
