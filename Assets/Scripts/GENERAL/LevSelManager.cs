using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevSelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void gotoReduce() {
    	SceneManager.LoadScene("Reduce");
    }
    public void gotoReuse() {
    	SceneManager.LoadScene("Reuse");
    }
    public void gotoRecycle() {
    	SceneManager.LoadScene("Recycle");
    }
    public void gotoMainMenu() {
    	SceneManager.LoadScene("MainMenu");
    }
}
