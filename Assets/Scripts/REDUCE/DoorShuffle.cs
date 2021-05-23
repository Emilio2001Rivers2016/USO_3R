using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorShuffle : MonoBehaviour {

	[SerializeField] private Image leftDoor, middleDoor, rightDoor;
	private int leftPos, middlePos, rightPos, randSelect, doorSelect;
	private bool firstShuffle;
	private Dictionary<int, int[]> posTable = new Dictionary<int, int[]>();

	// Start is called before the first frame update
	void Start() {
		firstShuffle = true;
		leftPos = -1;
		middlePos = 0;
		rightPos = 1;
		posTable.Add(-1, new int[] {0,1});
		posTable.Add(0, new int[] {-1,1});
		posTable.Add(1, new int[] {-1,0});
	}

	// Update is called once per frame
	void Update() {

	}

	public void shuffle() {
		StartCoroutine("shuffleCoroutine");
	}

	private IEnumerator shuffleCoroutine() {
		for(int i = 0; i < 1; i++) {

			doorSelect = Random.Range(-1,2);
			switch(doorSelect) {
				case -1:
					Debug.Log("STAT LEFT");
					do { randSelect = Random.Range(0,2); } while(posTable[middlePos][randSelect] == -1);	
					middlePos = posTable[middlePos][randSelect];
					do { randSelect = Random.Range(0,2); } while(posTable[rightPos][randSelect] == middlePos && posTable[rightPos][randSelect] == -1);	
					rightPos = posTable[rightPos][randSelect];
					break;
				case 0:
					Debug.Log("STAT MID");
					do { randSelect = Random.Range(0,2); } while(posTable[leftPos][randSelect] == 0);
					leftPos = posTable[leftPos][randSelect];
					do { randSelect = Random.Range(0,2); } while(posTable[rightPos][randSelect] == leftPos && posTable[rightPos][randSelect] == 0);	
					rightPos = posTable[rightPos][randSelect];
					break;
				case 1:
					Debug.Log("STAT RIGHT");
					do { randSelect = Random.Range(0,2); } while(posTable[leftPos][randSelect] == 1);
					leftPos = posTable[leftPos][randSelect];
					do { randSelect = Random.Range(0,2); } while(posTable[middlePos][randSelect] == leftPos && posTable[middlePos][randSelect] == 1);	
					middlePos = posTable[middlePos][randSelect];
					break;
			}
			leftDoor.gameObject.GetComponent<DoorMovement>().makeTransition(leftPos);
			middleDoor.gameObject.GetComponent<DoorMovement>().makeTransition(middlePos);
			rightDoor.gameObject.GetComponent<DoorMovement>().makeTransition(rightPos);

			yield return new WaitForSeconds(0.25f);
		}
	}

}



