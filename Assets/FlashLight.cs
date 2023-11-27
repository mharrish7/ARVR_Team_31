using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Player;
    GameObject Light;
    Rigidbody FlashLightPickUp;
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "MyGameObjectName")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "MyGameObjectTag")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
