using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayScript : MonoBehaviour
{
    // Start is called before the first frame update
    public DeadScript h1;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            Debug.Log("WIN!");
            h1.landed = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
