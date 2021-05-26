using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic_Reduce : MonoBehaviour {

	public static int reduceScore;

	private int index, resources, time;
	private bool chooseStage, clicked;
	private string[] doors = new string[3];

	[SerializeField] private Text scoreText, timeText;
	[SerializeField] private Image defeatScreen;

	// Start is called before the first frame update
	void Start() {
		// Resets necessary variables to the corresponding value
		chooseStage = false;
		clicked = false;
		time = 5;
		reduceScore = 0;
		resources = 1;
		doors[0] = "LeftDoor";
		doors[1] = "MiddleDoor";
		doors[2] = "RightDoor";
		StartCoroutine("timeControl");
	}

	// Update is called once per frame
	void Update() {
		scoreText.text = "Puntaje:\n" + reduceScore;
		timeText.text = time.ToString();
		if(resources <= 0) {
			DefeatScreenLogic.levelFinished = "Reduce";
			defeatScreen.gameObject.SetActive(true);
		}
		if(clicked) {
			StopCoroutine("timeControl");
			time = 6;
			chooseStage = false;
			clicked = false;
			StartCoroutine("timeControl");
		}
	}

	public void validateClick(string doorTag) {
		if(chooseStage && !clicked) {
			if(doors[index] == doorTag) {
				reduceScore++;
				if(resources < 3) resources++;
			} else {
				resources--;
			}
			clicked = true;
		}
	}

	private IEnumerator timeControl() {
		while(true) {
			for(int i = 0; i < 5; i++) {
				time--;
				yield return new WaitForSeconds(1);
			}
			index = (int) Random.Range(0,3);
			DoorShuffle.instance.shuffle();
			time = 5;
			yield return new WaitForSeconds(2.5f);
			chooseStage = true;
			for(int i = 0; i < 5; i++) {
				time--;
				yield return new WaitForSeconds(1);
			}
			time = 6;
			chooseStage = false;
		}
	}

}










