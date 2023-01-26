using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.localEulerAngles.z;
        zRotation = zRotation + Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(10, 0, zRotation);

        if(Input.touchCount>0 || Input.GetMouseButton(0))
        {
            Debug.Log("mouse down" + Input.mousePosition);
            
            if(Input.mousePosition.x < Screen.width / 2) 
            {
                transform.localEulerAngles = new Vector3(10, 0, transform.localEulerAngles.z + 1.0f);
            }

            else
            {
                transform.localEulerAngles = new Vector3(10, 0, transform.localEulerAngles.z - 1.0f);
            }
        }
    }
}
