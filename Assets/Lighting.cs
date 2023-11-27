using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    // Start is called before the first frame update
    public Light l1;
    public float dimmer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (l1.color[0] > 0.1)
        {
            l1.color = new Color(l1.color[0] - dimmer * Time.deltaTime, l1.color[1] - dimmer * Time.deltaTime, l1.color[2] - dimmer * Time.deltaTime);
        }
        
    }
}
