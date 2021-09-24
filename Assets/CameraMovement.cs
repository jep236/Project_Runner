using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject game;
    public int cameraSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Getting location
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");


        //Updating Location

        transform.position = transform.position + new Vector3(xDirection * cameraSpeed * Time.deltaTime, 0, yDirection * cameraSpeed * Time.deltaTime);
    }
}
