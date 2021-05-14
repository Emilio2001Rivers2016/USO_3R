using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public static int recycleScore;
	public static bool defeat;

	[SerializeField] private GameObject TrashPrefab;
	[SerializeField] private Text scoreText;

	private float minX = 0-(Screen.width/2)+Screen.width*0.2f;
	private float maxX = 0+(Screen.width/2)-Screen.width*0.2f;
	private float theY =  (float) 0+Screen.height*0.25f;
	

	// Start is called before the first frame update
	void Start() {
		// Resets necessary variables to the corresponding value
		recycleScore = 0;
		defeat = false;
		// Starts creating trash
		StartCoroutine("GenerateTrash");
	}

	// Update is called once per frame
	void Update()  {
		scoreText.text = "Puntaje: " + GameLogic.recycleScore;
		if(defeat) Time.timeScale = 0;
	}

	private IEnumerator GenerateTrash() {
		while(true) {
			var nova = Instantiate(TrashPrefab, new Vector3(Random.Range(minX, maxX), theY, 0), Quaternion.identity) as GameObject;
			nova.transform.SetParent(transform, false);
			yield return new WaitForSeconds(0.5f);
		}
	}
}
