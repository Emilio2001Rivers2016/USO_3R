using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public float timer = 3;
    bool reduce = false;
    public GameObject DeadScene;

    void OnTriggerEnter2D (Collider2D col){
    
        reduce = true;
        
    }

    void OnTriggerExit2D (Collider2D col){
        
            reduce = false;
            timer = 3;
        
    }
    
     // Update is called once per frame
    void Update () {

        if (reduce == true) {
            Debug.Log (timer);
             timer -= 1 * Time.deltaTime;
        }

        if (timer <= 0) {
            Debug.Log ("Perdiste");
            DeadScene.SetActive(true);
            Time.timeScale = 0;
            reduce = false;
             //put teleport part here
        }
    }
}
