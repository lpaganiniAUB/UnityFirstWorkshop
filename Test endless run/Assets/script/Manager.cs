using System.Collections;
using System.Collections.Generic;           //namespace area 
using UnityEngine;

public class Manager : MonoBehaviour
{
    //Stuff that you can see in Unity if public
    public GameObject platform;
    public GameObject Player;
    public float velocity = 3.0f;
    public float playerSpeed = 0.5f;
    public bool restart=true;
    public KeyCode leftKey;
    public KeyCode rightKey;



    //functions what it gives back/name/what you want to send
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
        PlayerMovement();

    }



    void MovePlatform()
    {
        platform.transform.position -= new Vector3(0.0f, 0.0f, velocity * Time.deltaTime);
        if (restart)
        {
            if (platform.transform.position.z < -10.0f)
            {
                platform.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            }
        }
    }


    void PlayerMovement()
    {
        //  true                    and this one as well true
        if(Input.GetKeyDown(leftKey)&& Player.transform.position.x>-2)
        {
            Player.transform.position -= new Vector3(playerSpeed, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(rightKey) && Player.transform.position.x < 2)
        {
            Player.transform.position += new Vector3(playerSpeed, 0.0f, 0.0f);
        }

    }
}
