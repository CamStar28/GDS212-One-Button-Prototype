using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class projectileBehaviour : MonoBehaviour
{

    public int projPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (projPosition == 1) //Down
        {
            transform.position += new Vector3(0, 0, -5) * Time.deltaTime;
        }

        if (projPosition == 2) //Up
        {
            transform.position += new Vector3(0, 0, 5) * Time.deltaTime;
        }

        if (projPosition == 3) //Right
        {
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }

        if (projPosition == 4) //Left
        {
            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
        }

        if (projPosition == 5) //Down Left
        {
            transform.position += new Vector3(-5, 0, -5) * Time.deltaTime;
        }

        if (projPosition == 6) //Up Left
        {
            transform.position += new Vector3(-5, 0, 5) * Time.deltaTime;
        }

        if (projPosition == 7) //Up Right
        {
            transform.position += new Vector3(5, 0, 5) * Time.deltaTime;
        }

        if (projPosition == 8) //Down Right
        {
            transform.position += new Vector3(5, 0, -5) * Time.deltaTime;
        }
    }

    
}
