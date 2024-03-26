using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public List<string> playerDirection = new List<string>(){"playerUp", "playerUpLeft", "playerLeft", "playerDownLeft", "playerDown", "playerDownRight", "playerRight", "playerUpRight"}; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKeyDown("space");
        {

        }
    }
}
