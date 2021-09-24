using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    public int movementSpeed;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveUnit(int x, int y, int z, GameObject unit)
    {
        
            //y+1 is so that we don't move the unit into the ground
            unit.transform.position = new Vector3(x, y + 1, z);
        
    }

}
