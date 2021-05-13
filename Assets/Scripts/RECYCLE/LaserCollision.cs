using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserCollision : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other) {
		if(gameObject.CompareTag("OrganicTrash") && other.gameObject.CompareTag("OrganicLaserTag")) {
			Destroy(gameObject);
		}
	}

}
