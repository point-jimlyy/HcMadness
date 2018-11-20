using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public Transform Player;

    int MoveSpeed = 1;
    int MaxDist = 10;
    int MinDist = 1;

   
    Vector2 pos;

    void Start()
    {
        pos = transform.position;
        Vector2 eM = new Vector2(transform.position.x, transform.position.y);
    }

    void Update()
    {

    }

    public void MoveEnemy()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {        // Left
            pos = Vector2.MoveTowards(transform.position, Player.position, 1.5f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {        // Right
            pos = Vector2.MoveTowards(transform.position, Player.position, 1.5f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {        // Up
            pos = Vector2.MoveTowards(transform.position, Player.position, 1.5f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {        // Down
            pos = Vector2.MoveTowards(transform.position, Player.position, 1.5f);
        }

        transform.position = pos;
    }

    public void MoveEnemyT()
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
            pos += Vector2.MoveTowards(transform.position, Player.position, 2f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {        // Down
            pos += Vector2.MoveTowards(transform.position, Player.position, -2f);
        }

        transform.position = Vector2.MoveTowards(transform.position, Player.position, 1);

        //this.Player = GameObject.FindGameObjectWithTag("Player").transform;
        //transform.position = Vector2.MoveTowards(transform.position, Player.position, 1);
        //transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }

}
