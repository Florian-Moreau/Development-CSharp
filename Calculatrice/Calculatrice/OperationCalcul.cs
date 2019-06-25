/*
 * Crée par SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/15/2018
 */
using System;

namespace Calculatrice
{
	/// <summary>
	/// Description of OperationCalcul.
	/// </summary>
	public static class OperationCalcul //on crée une classe statique nommé OperationCalcul
	{
		public static float Addition(float nombreA, float nombreB) //Voici un objet qui prend les valeur de NombreA et nombreB et les additionnes puis les renvois
		{
			return nombreA + nombreB;
		}
		public static float Soustraction(float nombreA, float nombreB)
		{
			return nombreA - nombreB;
		}
		public static float Multiplication(float nombreA, float nombreB)
		{
			return nombreA * nombreB;
		}
		public static float Division(float nombreA, float nombreB)
		{
			return nombreA / nombreB;
		}
		public static float Pourcentage(float nombreA, float nombreB)
		{
			return (nombreA * 100) / nombreB; //formule d'un pourcentage de A par rapport à B.
		}
	}
}
