using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heliStop3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody heli;
    public GameObject explo;
    void Start()
    {
        explo.SetActive(false);
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        explo.SetActive(true);
        heli.angularVelocity = new Vector3(1, 1, 1) * Time.deltaTime*10 ;

    }

    private void OnTriggerExit(Collider other)
    {
        explo.SetActive(false);
    }

    void Update()
    {
        
    }
}
