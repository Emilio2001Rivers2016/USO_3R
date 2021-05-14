using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatScreenLogic : MonoBehaviour {

	// Start is called before the first frame update
	void Start() {
		Debug.Log(GameLogic.recycleScore);
		Debug.Log(PlayerPrefs.GetInt("RecycleRecord"));

		if(GameLogic.recycleScore > PlayerPrefs.GetInt("RecycleRecord")) {
			PlayerPrefs.SetInt("RecycleRecord", GameLogic.recycleScore);
		}
	}

	// Update is called once per frame
	void Update() {

	}
}
