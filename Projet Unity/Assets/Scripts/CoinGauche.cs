using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class CoinGauche : MonoBehaviour
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
		NavigateurScenes.ChargerScenePrecedente ();
		//+charger scene precedente
	}
}

