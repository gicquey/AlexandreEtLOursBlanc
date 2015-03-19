using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class Scorer : MonoBehaviour
{
	public int scoreMax=10;
	private int score;
	// Use this for initialization
	void Start ()
	{
		score = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnScorePlus()
	{
		score++;
		if (score == scoreMax) 
		{
			NavigateurScenes.ChargerSceneSuivante();
			Debug.Log ("GAGNE !");
			//Ajouter transision scene suivante.
		}
	}

	void OnScoreMoins()
	{
		score--;
	}

}

