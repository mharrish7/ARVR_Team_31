using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoadCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Scenes/GameOver");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
