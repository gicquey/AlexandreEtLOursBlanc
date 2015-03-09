using UnityEngine;
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
		//TRALALA c'est la fiesta ! (transition + message victoire)
		Debug.Log ("GAGNE !");
	}

	void OnClicMauvaisOurs()
	{
		if (suivant == null) {
			//PERDU ! (transition + message d'insultes + humiliation publique + honte au joueur sur 3 générations)
			Debug.Log ("PERDU !");
		} 
		else 
		{
			suivant.SetActive(true);
			gameObject.SetActive(false);
		}
	}
}

