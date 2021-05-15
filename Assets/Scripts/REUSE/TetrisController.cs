using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TetrisController : MonoBehaviour
{
    //public GameObject rig;
    float timer = 0f; 
    //GameLogic2 gameLogic;
    public string tage;
    bool move = true;
    public GameObject rig;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool CheckValid()
    {
        foreach(Transform subBlock in rig.transform)
        {
            if(subBlock.transform.position.x >= GameLogic2.width ||
            subBlock.transform.position.x < 0 ||
            subBlock.transform.position.y < 0)
            {
                return false;
            }
        }

        return true;
    }


    // Update is called once per frame
    void Update()
    {
        if (move)
        {

            timer += 1 * Time.deltaTime;

            if (Input.GetKey(KeyCode.DownArrow) && timer > GameLogic2.quickDropTime)
            {
                gameObject.transform.position -= new Vector3(0,1,0);
                timer = 0;
                if (!CheckValid())
                {
                    move = false;
                    gameObject.transform.position += new Vector3(0,1,0);
                }
            } 
            else if (timer > GameLogic2.dropTime)
            {
                gameObject.transform.position -= new Vector3(0,1,0);
                timer = 0;
                if (!CheckValid())
                {
                    move = false;
                    gameObject.transform.position += new Vector3(0,1,0);
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gameObject.transform.position -= new Vector3(1,0,0);
                if (!CheckValid())
                {
                    
                    gameObject.transform.position += new Vector3(1,0,0);
                }
            } 
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gameObject.transform.position += new Vector3(1,0,0);
                if (!CheckValid())
                {
                    
                    gameObject.transform.position -= new Vector3(1,0,0);
                }
            }

        }

    }
}
