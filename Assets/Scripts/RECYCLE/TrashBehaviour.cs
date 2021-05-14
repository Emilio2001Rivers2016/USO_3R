using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashBehaviour : MonoBehaviour {

	[SerializeField] private Sprite organicImg1, organicImg2, organicImg3,
								inorganicImg1, inorganicImg2, inorganicImg3,
								specialImg1, specialImg2, specialImg3;
	private string thisTag, otherTag, otherTag_wrong1, otherTag_wrong2;

	// Start is called before the first frame update
	void Start() {
		switch((int) Random.Range(0f, 3f)) {
			case 0:
				thisTag = "Organic";
				otherTag_wrong1 = "InorganicLaser";
				otherTag_wrong2 = "SpecialLaser";
				RandomPick(organicImg1, organicImg2, organicImg3);
				break;
			case 1:
				thisTag = "Inorganic";
				otherTag_wrong1 = "OrganicLaser";
				otherTag_wrong2 = "SpecialLaser";
				RandomPick(inorganicImg1, inorganicImg2, inorganicImg3);
				break;
			case 2:
				thisTag = "Special";
				otherTag_wrong1 = "InorganicLaser";
				otherTag_wrong2 = "OrganicLaser";
				RandomPick(specialImg1, specialImg2, specialImg3);
				break;
		}
		otherTag = thisTag+"Laser";
		gameObject.tag = thisTag;
		// Modifies both image size and box collider size
		gameObject.GetComponent<BoxCollider2D>().size = new Vector2((float) Screen.width*0.1f, (float) Screen.height*0.1f);
		gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2((float) Screen.width*0.1f, (float) Screen.height*0.1f);
	}

	// Update is called once per frame
	void Update() {
		if(gameObject.transform.position.y <= -6f) {
			Destroy(gameObject);	
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if(gameObject.CompareTag(thisTag) && other.gameObject.CompareTag(otherTag)) {
			Destroy(gameObject);
			GameLogic.recycleScore++;
		} else if(other.gameObject.CompareTag(otherTag_wrong1) || other.gameObject.CompareTag(otherTag_wrong2)) {
			GameLogic.defeat = true;
		}
	}

	private void RandomPick(Sprite img1, Sprite img2, Sprite img3) {
		switch((int) Random.Range(0f, 3f)) {
			case 0:
				GetComponent<Image>().sprite = img1; break;
			case 1:
				GetComponent<Image>().sprite = img2; break;
			case 2:
				GetComponent<Image>().sprite = img3; break;
		}
	}
}





