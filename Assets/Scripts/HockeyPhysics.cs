using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HockeyPhysics : MonoBehaviour {


    public GameObject pk = GameObject.Find("PK");
    public GameObject pg = GameObject.Find("PG");
    public GameObject pld = GameObject.Find("PLD");
    public GameObject prd = GameObject.Find("PRD");
    public GameObject plfw = GameObject.Find("PLFW");
    public GameObject prfw = GameObject.Find("PRFW");
    public GameObject pc = GameObject.Find("PC");

    public GameObject ec = GameObject.Find("EC");

    Vector2 pos;
    Vector2 pos2;
    Vector2 pkATT;

    Collider crash;
    Collider crash2;

    int MoveSpeed = 1;
    int MaxDist = 10;
    int MinDist = 1;


    void Start ()
    {
        
    }

    void Awake()
    {
        //pk.GetComponent<PKscript>().ATTarget(pg);
    }

    

    void Update ()
    {

    }

}
