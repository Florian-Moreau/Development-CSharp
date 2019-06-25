/*
 * Calculatrice graphique C-Sharp
 * Crée par SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 15/08/2018
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculatrice
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void b_Add(object sender, EventArgs e) //Si on clic sur le bouton nommé b_Add alors il se passe cela
		{
			float res = OperationCalcul.Addition(float.Parse(t_nombreA.Text),float.Parse(t_nombreB.Text)); //Res prend la valeur de se que retourne l'objet OperationCalcul.Addition avec le nombre A et B qui son traduit de chaine de caractère a un Float
			t_resultat.Text = Convert.ToString(res); // on retraduit res en chaine de caractère String pour l'afficher dans la box nommé t_resultat
		}
		void b_Sub(object sender, EventArgs e)
		{
			float res = OperationCalcul.Soustraction(float.Parse(t_nombreA.Text),float.Parse(t_nombreB.Text));
			t_resultat.Text = Convert.ToString(res);
		}
		void b_Mult(object sender, EventArgs e)
		{
			float res = OperationCalcul.Multiplication(float.Parse(t_nombreA.Text),float.Parse(t_nombreB.Text));
			t_resultat.Text = Convert.ToString(res);
		}
		void b_Div(object sender, EventArgs e)
		{
			float res = OperationCalcul.Division(float.Parse(t_nombreA.Text),float.Parse(t_nombreB.Text));
			t_resultat.Text = Convert.ToString(res);
		}
		void b_Pour(object sender, EventArgs e)
		{
			float res = OperationCalcul.Pourcentage(float.Parse(t_nombreA.Text),float.Parse(t_nombreB.Text));
			t_resultat.Text = Convert.ToString(res);
		}
	}
}
