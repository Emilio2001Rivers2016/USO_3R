using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorMovement : MonoBehaviour {

	private Animator animator;
	
	public int TRASH_POS;


	// Start is called before the first frame update
	void Start() {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update() {
		makeTransition();
	}

	private void makeTransition() {
		animator.SetInteger("FUTURE", TRASH_POS);
	}

	

}





