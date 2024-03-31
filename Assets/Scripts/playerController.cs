using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro; 

public class playerController : MonoBehaviour
{

    //public List<string> playerDirection = new List<string>(){"playerUp", "playerUpLeft", "playerLeft", "playerDownLeft", "playerDown", "playerDownRight", "playerRight", "playerUpRight"}; 

    public string playerDirection;

    public TextMeshProUGUI directionText; 

    // Start is called before the first frame update
    void Start()
    {
        playerDirection = "playerUp";
        directionText.text = "Current direction: Up";
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

                directionText.text = "Current direction: Up Right";
            }
            else if (playerDirection == "playerUpRight")
            {
                playerDirection = "playerRight";

                directionText.text = "Current direction: Right";
            }
            else if (playerDirection == "playerRight")
            {
                playerDirection = "playerDownRight";

                directionText.text = "Current direction: Down Right";
            }
            else if (playerDirection == "playerDownRight")
            {
                playerDirection = "playerDown";

                directionText.text = "Current direction: Down";
            }
            else if (playerDirection == "playerDown")
            {
                playerDirection = "playerDownLeft";

                directionText.text = "Current direction: Down Left";
            }
            else if (playerDirection == "playerDownLeft")
            {
                playerDirection = "playerLeft";

                directionText.text = "Current direction: Left";
            }
            else if (playerDirection == "playerLeft")
            {
                playerDirection = "playerUpLeft";

                directionText.text = "Current direction: Up Left";
            }
            else if (playerDirection == "playerUpLeft")
            {
                playerDirection = "playerUp";

                directionText.text = "Current direction: Up";
            }

            //Debug.Log("Current direction " + playerDirection);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
