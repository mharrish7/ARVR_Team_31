using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject r1;
    public float Health;
    public float WaterDamage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Health <= 0)
        {
            SceneManager.LoadScene("Scenes/GameOver");

        }
        else
        {
            if (r1.transform.position.y > gameObject.transform.position.y)
            {
                Health -= WaterDamage * Time.deltaTime;
                Debug.Log("Health : " + Health);
            }
        }
        
        
    }
}
