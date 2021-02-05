using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControls : MonoBehaviour
{
    public GameObject player;
    public float mouseInputX;
    public float mouseInputY;
    public float mouseSpeed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseInputX = Input.GetAxis("Mouse X");
        mouseInputY = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * mouseInputX * mouseSpeed * Time.deltaTime);

        float angle = player.transform.rotation.eulerAngles.x;
        if (angle <= 45)
        {
            if (angle >= -45)
            {
                player.transform.Rotate(Vector3.right * mouseInputY * mouseSpeed * Time.deltaTime);
            }
            else
            {
                player.transform.rotation = Quaternion.Euler(45, player.transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.z);
            }
        }
        else
        {
            player.transform.rotation = Quaternion.Euler(45, player.transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.z);
        }
  
    }
    private void checkAngle(float ngle)
    {
        
    }
}
