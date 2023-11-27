using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heliStop2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody heli;
    void Start()
    {
        heli.velocity = Vector3.forward * Time.deltaTime * 100;
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("HEli stop");
        heli.velocity = Vector3.zero;
        SceneManager.LoadScene("Scenes/Scene3");

    }

    void Update()
    {
        
    }
}
