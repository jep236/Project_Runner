using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool combat;
    public bool conversation;
    public bool turn;
    public GameObject currentUnit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey("space"))
        {
            if (combat == true)
            {
                combat = false;
                Debug.Log("Combat is false");
            }
            else
            {
                combat = true;

                Debug.Log("Combat is true");
            }
        }
        
    }
}
