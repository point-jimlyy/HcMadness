using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    public Transform Player;
    int MoveSpeed = 1;
    int MaxDist = 10;
    int MinDist = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Player);
        if(Vector2.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            if(Vector2.Distance(transform.position, Player.position) <= MaxDist)
            {

            }
        }

	}
}
