using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    public Renderer rend;
    int timerCount = 225;

    // Start is called before the first frame update
    void Start()
    {
        timerCount = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;

        if ((gameObject.tag == "Red") && (i >= 100))
        {
            gameObject.SetActive(false);
        }

        if ((gameObject.tag == "Blue") && (i == timerCount)) 
        {
            Debug.Log("Deleted at:" + i);
            rend.enabled = false;
        }
    }
}