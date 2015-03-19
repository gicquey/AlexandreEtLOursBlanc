using UnityEngine;
using AssemblyCSharp;
using System.Collections;

public class Jeu5BonOurs : MonoBehaviour
{
	public GameObject suivant;
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
		NavigateurScenes.ChargerSceneSuivante();
		Debug.Log ("GAGNE !");
	}

	void OnClicMauvaisOurs()
	{
		if (suivant == null) {
			NavigateurScenes.ChargerSceneSuivante();
			Debug.Log ("PERDU !");
		} 
		else 
		{
			suivant.SetActive(true);
			gameObject.SetActive(false);
		}
	}
}

