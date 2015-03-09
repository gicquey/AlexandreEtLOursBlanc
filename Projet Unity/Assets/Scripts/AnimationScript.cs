using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour {

	private Animator animator;

	void Awake()
	{	
		// Get the animator
		animator = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		animator.SetBool("MouseOver", true);
	}

	void OnMouseExit(){
		animator.SetBool("MouseOver", false);
	}
}
