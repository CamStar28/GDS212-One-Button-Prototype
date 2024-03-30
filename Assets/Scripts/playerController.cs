using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    //public List<string> playerDirection = new List<string>(){"playerUp", "playerUpLeft", "playerLeft", "playerDownLeft", "playerDown", "playerDownRight", "playerRight", "playerUpRight"}; 

    public string playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerDirection = "playerUp"; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            //Debug.Log("hit da space");
            
            if (playerDirection == "playerUp")
            {
                transform.position += new Vector3(0, 0, 5) * Time.deltaTime;
            }

            if (playerDirection == "playerUpRight")
            {
                transform.position += new Vector3(5, 0, 5) * Time.deltaTime;
            }

            if (playerDirection == "playerRight")
            {
                transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
            }

            if (playerDirection == "playerDownRight")
            {
                transform.position += new Vector3(5, 0, -5) * Time.deltaTime;
            }

            if (playerDirection == "playerDown")
            {
                transform.position += new Vector3(0, 0, -5) * Time.deltaTime;
            }

            if (playerDirection == "playerDownLeft")
            {
                transform.position += new Vector3(-5, 0, -5) * Time.deltaTime;
            }

            if (playerDirection == "playerLeft")
            {
                transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
            }

            if (playerDirection == "playerUpLeft")
            {
                transform.position += new Vector3(-5, 0, 5) * Time.deltaTime;
            }
        }

        if (Input.GetKeyUp("space")) 
        {
            if (playerDirection == "playerUp")
            {
                playerDirection = "playerUpRight";
            }
            else if (playerDirection == "playerUpRight")
            {
                playerDirection = "playerRight";
            }
            else if (playerDirection == "playerRight")
            {
                playerDirection = "playerDownRight";
            }
            else if (playerDirection == "playerDownRight")
            {
                playerDirection = "playerDown";
            }
            else if (playerDirection == "playerDown")
            {
                playerDirection = "playerDownLeft";
            }
            else if (playerDirection == "playerDownLeft")
            {
                playerDirection = "playerLeft";
            }
            else if (playerDirection == "playerLeft")
            {
                playerDirection = "playerUpLeft";
            }
            else if (playerDirection == "playerUpLeft")
            {
                playerDirection = "playerUp";
            }

            Debug.Log("Current direction " + playerDirection);
        }
    }
}
