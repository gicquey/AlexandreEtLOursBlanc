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

namespace AssemblyCSharp
{
	public static class Controleur
	{
		private static Stack<Commande> pileCommandes;

		static Controleur ()
		{
			pileCommandes = new Stack<Commande> ();
		}

		public static void EmpilerExecuter(Commande c)
		{
			pileCommandes.Push (c);
			c.Executer ();
		}

		public static void Annuler()
		{
			try
			{
				Commande c = pileCommandes.Pop();
				c.Annuler();
			}
			catch
			{
				//Normalement simplement parce que la pile est vide
			}
		}

		public static void ViderPile()
		{
			pileCommandes.Clear ();
		}
	}
}

