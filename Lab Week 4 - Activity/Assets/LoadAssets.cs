using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{

    public GameObject redObj;
    Vector3 redObjVector = new Vector3(2.0f, 0.0f, 0.0f);

    [SerializeField] private GameObject blueObj;
    Vector3 blueObjVector = new Vector3(-2.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj, redObjVector, Quaternion.identity);
        Instantiate(blueObj, blueObjVector, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
