using UnityEngine;
using System.Collections;

public class ChildCollider : MonoBehaviour
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
		transform.parent.gameObject.SendMessage("OnMouseUp");
	}
}

