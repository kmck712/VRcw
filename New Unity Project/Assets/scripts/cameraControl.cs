using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float mouseSpeed = 80;
 
    public float mousexInput;
    public float mouseyInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        mousexInput = Input.GetAxis("Mouse Y");
        mouseyInput = Input.GetAxis("Mouse X");
        mousexInput = Mathf.Clamp(mousexInput, -90, 90);

        transform.eulerAngles = new Vector3(mousexInput, mouseyInput, 0.0f);

       // transform.Rotate(Vector3.left * mousexInput * mouseSpeed * Time.deltaTime);
        //transform.Rotate(Vector3.up * mouseyInput * mouseSpeed * Time.deltaTime);
     
    }
}
