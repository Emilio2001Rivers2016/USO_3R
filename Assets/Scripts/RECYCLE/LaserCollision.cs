using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserCollision : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("OrganicLaserTag")) {
			Debug.Log("ABER");
			Destroy(gameObject, 0.3f);
		}
	}

}
