/*
 * Crée par SharpDevelop.
 * Utilisateur: flori
 * Date: 15/08/2018
 * Heure: 22:56
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace Voiture_ASCII
{
	class Program
	{
		private static void Main(string[] args)
{
    int i = 0;
	int j = 0;
	int largeur = 21;
	int hauteur = 4;
	Console.WriteLine(@"      .--------.");
	Console.WriteLine(@" ____/_____|___ \___");
	Console.WriteLine(@"O    _   - |   _   ,*");
	Console.WriteLine(@" '--(_)-------(_)--'");
	while (true)
	{
		ConsoleKeyInfo info = Console.ReadKey(true);
		switch (info.Key)
		{
			case ConsoleKey.LeftArrow:
				if( i > 0 )
				{
					Console.MoveBufferArea(i, j, largeur, hauteur, i - 1, j);
					i--;
				}
				break;						 
			case ConsoleKey.RightArrow:
			    if (i < Console.WindowWidth - largeur)
			    {
				    Console.MoveBufferArea(i, j, largeur, hauteur, i + 1, j);
				    i++;						 
			    }
				break;						 
			case ConsoleKey.UpArrow:
				if( j > 0 )
				{
					Console.MoveBufferArea(i, j, largeur, hauteur, i, j - 1);
					j--;
				}
				break;						 
			case ConsoleKey.DownArrow:
				Console.MoveBufferArea(i, j, largeur, hauteur, i, j + 1);
				j++;
				break;
		}
		if (info.Key == ConsoleKey.Q)
			break;
	}
}
	}
}