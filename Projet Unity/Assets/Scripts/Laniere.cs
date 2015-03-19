using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class Laniere : MonoBehaviour
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
		NavigateurScenes.TerminerJeu ();
		//+Charger scene suivante
	}
}