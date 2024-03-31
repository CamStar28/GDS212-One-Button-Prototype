using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerController : MonoBehaviour
{

    public int spawnerValue; //this public field allows the same script to be used on all the triggers, with it's value being changed on the objects themselves 
    
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
        other.gameObject.GetComponent<projectileBehaviour>().projPosition = spawnerValue; //uses the spawnerValue assigned to each object to change the direction the projectiles move (see projetileBehaviour script)
    }
}
