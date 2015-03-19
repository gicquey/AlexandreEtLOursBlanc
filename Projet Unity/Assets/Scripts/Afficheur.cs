using UnityEngine;
using System.Collections;

public class Afficheur : MonoBehaviour
{
	private float decalageTotal;
	public float pasDecalage = -5/11;
	// Use this for initialization
	void Start ()
	{
		decalageTotal = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Afficher(GameObject objet)
	{
		Vector3 temp = new Vector3(objet.transform.position.x,objet.transform.position.y+decalageTotal,objet.transform.position.z);
		objet.transform.position = temp;
		objet.SetActive (true);
		decalageTotal += pasDecalage;
	}

	public void Cacher(GameObject objet)
	{
		objet.SetActive (false);
		decalageTotal -= pasDecalage;
		Vector3 temp = new Vector3(objet.transform.position.x,objet.transform.position.y-decalageTotal,objet.transform.position.z);
		objet.transform.position = temp;
	}
}

