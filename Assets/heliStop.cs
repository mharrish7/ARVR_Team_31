using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heliStop : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody heli;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
            Debug.Log("HEli stop");
            heli.velocity = Vector3.zero;
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene("Scenes/Scene2");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
