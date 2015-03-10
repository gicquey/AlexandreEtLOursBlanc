using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class CoinDroit : MonoBehaviour
{

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
		Controleur.ViderPile ();
		//+Charger scene suivante
	}
}

