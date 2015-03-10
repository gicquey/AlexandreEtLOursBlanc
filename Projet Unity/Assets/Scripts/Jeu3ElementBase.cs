using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class Jeu3ElementBase : MonoBehaviour
{
	public GameObject elementSimplifie;
	public GameObject scorer;
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
		Controleur.EmpilerExecuter(new CommandeTransformation(gameObject,elementSimplifie,scorer));
	}
}

