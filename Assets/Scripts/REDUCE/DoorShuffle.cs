using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorShuffle : MonoBehaviour {

	[SerializeField] private Image leftDoor, middleDoor, rightDoor;
	private int leftPos, middlePos, rightPos, randSelect, doorSelect;

	public static DoorShuffle instance;

	// Start is called before the first frame update
	void Start() {
		leftPos = -1;
		middlePos = 0;
		rightPos = 1;
		instance = this;
	}

	// Update is called once per frame
	void Update() {

	}

	public void shuffle() {
		StartCoroutine("shuffleCoroutine");
	}

	private IEnumerator shuffleCoroutine() {
		for(int i = 0; i < 10; i++) {

			doorSelect = Random.Range(-1,2);
			switch(doorSelect) {
				case -1:
					if(leftPos == -1) {
						int tmp = middlePos;
						middlePos = rightPos;
						rightPos = tmp;
					} else if(middlePos == -1) {
						int tmp = leftPos;
						leftPos = rightPos;
						rightPos = tmp;
					} else if(rightPos == -1) {
						int tmp = middlePos;
						middlePos = leftPos;
						leftPos = tmp;
					}
					break;
				case 0:
					if(leftPos == 0) {
						int tmp = middlePos;
						middlePos = rightPos;
						rightPos = tmp;
					} else if(middlePos == 0) {
						int tmp = leftPos;
						leftPos = rightPos;
						rightPos = tmp;
					} else if(rightPos == 0) {
						int tmp = middlePos;
						middlePos = leftPos;
						leftPos = tmp;
					}
					break;
				case 1:
					if(leftPos == 1) {
						int tmp = middlePos;
						middlePos = rightPos;
						rightPos = tmp;
					} else if(middlePos == 1) {
						int tmp = leftPos;
						leftPos = rightPos;
						rightPos = tmp;
					} else if(rightPos == 1) {
						int tmp = middlePos;
						middlePos = leftPos;
						leftPos = tmp;
					}
					break;
			}
			leftDoor.gameObject.GetComponent<DoorMovement>().makeTransition(leftPos);
			middleDoor.gameObject.GetComponent<DoorMovement>().makeTransition(middlePos);
			rightDoor.gameObject.GetComponent<DoorMovement>().makeTransition(rightPos);

			yield return new WaitForSeconds(0.15f);
		}
	}

}



