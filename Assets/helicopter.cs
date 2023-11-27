using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Heli;
    public Rigidbody helir;
    public GameObject player;
    
    void Start()
    {
        Heli.SetActive(false);
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        Heli.SetActive(true);
        Debug.Log("HEli on the way!!!");
        helir.velocity = Vector3.back * Time.deltaTime * 1000;
    }

    void Update()
    {
        
    }
}
