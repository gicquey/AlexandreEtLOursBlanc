//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34209
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
namespace AssemblyCSharp
{
	public class CommandeJeu1 : Commande
	{
		private GameObject afficheur;
		private GameObject objet1;
		private GameObject objet2;
		private GameObject etiquette;
		private GameObject scorer;
		
		public CommandeJeu1 (GameObject pAfficheur, GameObject pObjet1, GameObject pObjet2, GameObject pEtiquette, GameObject pScorer)
		{
			afficheur = pAfficheur;
			objet1 = pObjet1;
			objet2 = pObjet2;
			etiquette = pEtiquette;
			scorer = pScorer;
		}
		
		public void Executer()
		{
			if (objet1 != null) 
			{
				objet1.SetActive(false);
			}
			if (objet2 != null) 
			{
				objet2.SetActive(false);
			}
			afficheur.GetComponent<Afficheur> ().Afficher (etiquette);
			scorer.SendMessage ("OnScorePlus");
		}
		
		public void Annuler()
		{
			if (objet1 != null) 
			{
				objet1.SetActive(true);
			}
			if (objet2 != null) 
			{
				objet2.SetActive(true);
			}
			afficheur.GetComponent<Afficheur> ().Cacher (etiquette);
			scorer.SendMessage ("OnScoreMoins");
		}
	}
}