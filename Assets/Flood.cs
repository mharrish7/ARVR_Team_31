using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flood : MonoBehaviour
{
    public Rigidbody myrigid;
    // Start is called before the first frame update
    void Start()
    {
        myrigid.velocity =  Vector3.up * Time.deltaTime*20 ;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
