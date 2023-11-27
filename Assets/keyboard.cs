using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody myrigidbody;

    public float sensX;
    public float sensY;

    float xRotation;
    float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        gameObject.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
 
        if(Input.GetKey(KeyCode.A) == true)
        {
            myrigidbody.velocity += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            myrigidbody.velocity += Vector3.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            myrigidbody.velocity += Vector3.up * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            myrigidbody.velocity += Vector3.down  * Time.deltaTime;
        }
    }
}

