using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class Jeu1Cliquables : MonoBehaviour
{
	public GameObject afficheur;
	public GameObject scorer;
	public GameObject jumeau;
	public GameObject etiquette;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseUp()
	{
		Controleur.EmpilerExecuter(new CommandeJeu1(afficheur,gameObject,jumeau,etiquette,scorer));
	}
}

