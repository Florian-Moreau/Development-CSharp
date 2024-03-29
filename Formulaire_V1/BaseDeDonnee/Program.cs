﻿/*
 * Crée par SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/17/2018
 */
using System;
using System.Windows.Forms;

namespace BaseDeDonnees
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
