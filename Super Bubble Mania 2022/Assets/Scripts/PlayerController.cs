using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;

    private float rightBorder = 10.2f;
    private float leftBorder = -10.2f;

    void Start()
    {
        
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.position = new Vector3(player.transform.position.x + 0.01f, player.transform.position.y, 0);
        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.position = new Vector3(player.transform.position.x - 0.01f, player.transform.position.y, 0);
        }

        if(player.transform.position.x > rightBorder)
        {
            player.transform.position = new Vector3(rightBorder, player.transform.position.y, 0);
        }else if (player.transform.position.x < leftBorder)
        {
            player.transform.position = new Vector3(leftBorder, player.transform.position.y, 0);
        }
    }
}
