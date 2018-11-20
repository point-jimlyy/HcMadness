using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRDscript : MonoBehaviour {

    public GameObject pk;
    public GameObject pg;
    public GameObject pld;
    public GameObject plfw;
    public GameObject prfw;

    public GameObject puck;
    public GameObject targetPlayer;

    private PRDscript script;
    private bool onOff;

    

    Vector2 pos;

    void Start()
    {
        pk = GameObject.FindGameObjectWithTag("PK");
        pg = GameObject.FindGameObjectWithTag("PG");
        pld = GameObject.FindGameObjectWithTag("PLD");
        plfw = GameObject.Find("PLFW");
        prfw = GameObject.Find("PRFW");
    }

    void Update()
    {
        if (onOff)
        {
            PassPlayer();
        }
    }

    public void PassPlayer()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            pk.GetComponent<PKscript>().ATTarget(pg);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pk.GetComponent<PKscript>().ATTarget(prfw);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            pk.GetComponent<PKscript>().ATTarget(pld);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            pk.GetComponent<PKscript>().ATTarget(plfw);
        }
    }
    void OnCollisionEnter2D(Collision2D crash)
    {
        onOff = true;
    }
    void OnCollisionExit2D(Collision2D crash)
    {
        onOff = false;
    }
}
