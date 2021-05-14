using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	[SerializeField] private GameObject TrashPrefab;

	private float minX = 0-(Screen.width/2)+Screen.width*0.2f;
	private float maxX = 0+(Screen.width/2)-Screen.width*0.2f;
	private float theY =  (float) 0+Screen.height*0.25f;
	

	// Start is called before the first frame update
	void Start() {
		// Starts creating trash
		StartCoroutine("GenerateTrash");
	}

	// Update is called once per frame
	void Update()  {

	}

	private IEnumerator GenerateTrash() {
		while(true) {
			var nova = Instantiate(TrashPrefab, new Vector3(Random.Range(minX, maxX), theY, 0), Quaternion.identity) as GameObject;
			nova.transform.SetParent(transform, false);
			yield return new WaitForSeconds(0.5f);
		}
	}
}
