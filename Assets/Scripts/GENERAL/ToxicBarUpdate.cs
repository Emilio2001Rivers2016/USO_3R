using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToxicBarUpdate : MonoBehaviour {

	[SerializeField] private Image[] levelBars = new Image[10];
	private int toxicLevel;

    // Start is called before the first frame update
    void Start() {
    	PlayerPrefs.SetInt("toxLev", (int) Random.Range(1,11)); //// SOLUTION THAT NEEDS TO BE CHANGED
    	
        toxicLevel = PlayerPrefs.GetInt("toxLev");
    }

    // Update is called once per frame
    void Update() {
    	activeColorBars(toxicLevel);
    }
    
    void activeColorBars(int val) {
    	for(int i = 0; i < val; ++i) {
    		levelBars[i].gameObject.SetActive(true);
    	}
    	for(int j = val; j < 10; j++) {
    		levelBars[j].gameObject.SetActive(false);    	
    	}
    }
    
}
