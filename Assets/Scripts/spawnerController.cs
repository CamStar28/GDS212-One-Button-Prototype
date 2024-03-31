using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerController : MonoBehaviour
{

    public int spawnerValue; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Sending Magic Right");
        other.gameObject.GetComponent<projectileBehaviour>().projPosition = spawnerValue;
    }
}
