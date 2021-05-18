using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public Rigidbody2D rb;
    //private bool moving = false;
    [SerializeField]
    //public static bool spawnPermit = true;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(3.0f, -1f);
            //moving = true;
        }

        //Press the Down arrow key to move the RigidBody downwards
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-3.0f,-1f);
            //moving = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity += new Vector2(0f,-1.0f);
            //moving = true;
        } 
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!(other.tag=="Wall"))
        {
            StartCoroutine(checkSpawn());
            
        }
        
        if(other.tag == this.tag && !(other.tag =="Respawn"))
        {
            PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+100);
            GameLogic2.SpawnPermit = true;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            
        }
    }
    public IEnumerator checkSpawn()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
            Debug.Log("Congele este y aparecere uno nuevo");
        yield return new WaitForSeconds(2);
        GameLogic2.SpawnPermit = true;
        
    }
    
    


}
