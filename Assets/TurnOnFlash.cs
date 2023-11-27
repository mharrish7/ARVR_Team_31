using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnFlash : MonoBehaviour
{
    // Start is called before the first frame update
    public Light l1;
    public bool enabled;
    public bool toogle;
    public GameObject textToDisplay;
    void Start()
    {
        l1.intensity = 0;
        textToDisplay.SetActive(false);
    }

    // Update is called once per frame

    private void OnTriggerStay()
    {
        textToDisplay.SetActive(true);
    }

    private void OnTriggerExit()
    {
        textToDisplay.SetActive(false);
    }
    void Update()
    {

        if (enabled && Input.GetKeyDown(KeyCode.E))
        {
            toogle = !toogle;
        }

        if (enabled)
        {
            if (toogle)
            {
                l1.intensity = 5;
            }
            else
            {
                l1.intensity = 0;
            }
        }
    }
}
