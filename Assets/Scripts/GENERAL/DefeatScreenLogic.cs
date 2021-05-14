using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefeatScreenLogic : MonoBehaviour {

	[SerializeField] private Text gameScore, highScore;

	// Start is called before the first frame update
	void Start() {
		if(GameLogic.recycleScore > PlayerPrefs.GetInt("RecycleRecord")) {
			PlayerPrefs.SetInt("RecycleRecord", GameLogic.recycleScore);
		}
		gameScore.text = "Puntaje de esta partida:\n" + GameLogic.recycleScore;
		highScore.text = "Puntaje récord:\n" + PlayerPrefs.GetInt("RecycleRecord");
	}

	// Update is called once per frame
	void Update() {

	}
}
