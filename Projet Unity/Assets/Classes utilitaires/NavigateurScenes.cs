//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34209
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using UnityEngine;
namespace AssemblyCSharp
{
	public static class NavigateurScenes
	{
		private static List<String> scenesOrdonnees;
		private static int indexCourant;

		static NavigateurScenes ()
		{
			indexCourant = 0;
			scenesOrdonnees = new List<String>();
			scenesOrdonnees.Add("Jeu 1");
			scenesOrdonnees.Add("Jeu 2");
			scenesOrdonnees.Add("Jeu 3");
			scenesOrdonnees.Add("Jeu 4");
			scenesOrdonnees.Add("Jeu 5");
			scenesOrdonnees.Add("Jeu 6");
			scenesOrdonnees.Add("Jeu 7");
			scenesOrdonnees.Add("Scene fin");
		}

		public static void ChargerSceneSuivante()
		{
			Controleur.ViderPile ();
			if (indexCourant < scenesOrdonnees.Count - 1) 
			{
				indexCourant++;
				Application.LoadLevel (scenesOrdonnees [indexCourant]);
			}
		}

		public static void ChargerScenePrecedente()
		{
			Controleur.ViderPile ();
			if (indexCourant > 0) 
			{
				indexCourant--;
				Application.LoadLevel (scenesOrdonnees [indexCourant]);
			}
		}

		public static void TerminerJeu()
		{
			indexCourant = scenesOrdonnees.Count - 1;
			Controleur.ViderPile ();
			Application.LoadLevel (scenesOrdonnees [indexCourant]);
		}
	}
}

