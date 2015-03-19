using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class JeuxDeTransformationElementBase : MonoBehaviour
{
	public GameObject elementTransforme;
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
		Controleur.EmpilerExecuter(new CommandeTransformation(gameObject,elementTransforme,scorer));
	}
}

