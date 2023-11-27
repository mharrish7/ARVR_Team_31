using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject r1;
    public bool landed = false;
    void Start()
    {
        
    }


    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {   
        if(!landed) SceneManager.LoadScene("Scenes/GameOver");
    
    }
    void Update()
    {
        

    }
}
