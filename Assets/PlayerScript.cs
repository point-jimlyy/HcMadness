using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Transform Enemy;
    public Transform Collectable;

    int MoveSpeed = 1;
    int MaxDist = 10;
    int MinDist = 1;
    Vector2 pos;

    void Start ()
    {
        pos = transform.position;
    }
	
	void Update ()
    {

    }

    public void MovePlayer()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {        // Left
            pos += Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {        // Right
            pos += Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {        // Up
            pos += Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {        // Down
            pos += Vector2.down;
        }

        
        transform.position = pos;
    }
}
