using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic_Reduce : MonoBehaviour {

	private int index, reduceScore, resources;
	private string[] doors = new string[3];

	[SerializeField] private Text scoreText;
	[SerializeField] private Image defeatScreen;

	// Start is called before the first frame update
	void Start() {
		// Resets necessary variables to the corresponding value
		reduceScore = 0;
		resources = 1;
		doors[0] = "LeftDoor";
		doors[1] = "MiddleDoor";
		doors[2] = "RightDoor";
	}

	// Update is called once per frame
	void Update() {
		scoreText.text = "Puntaje:\n" + reduceScore;
		if(resources <= 0) {
			defeatScreen.gameObject.SetActive(true);
		}
	}

	public void gameShuffle() {
		index = (int) Random.Range(0, 3);
		Debug.Log(index);
		DoorShuffle.instance.shuffle();
	}

	public void validateLeftClick() {
		if(doors[index] == "LeftDoor") {
			reduceScore++;
			resources++;
		} else {
			resources--;
		}
	}

	public void validateMiddleClick() {
		if(doors[index] == "MiddleDoor") {
			reduceScore++;
			resources++;
		} else {
			resources--;
		}
	}

	public void validateRightClick() {
		if(doors[index] == "RightDoor") {
			reduceScore++;
			resources++;
		} else {
			resources--;
		}
	}

}
