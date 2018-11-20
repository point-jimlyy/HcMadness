using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLDscript : MonoBehaviour {

    public GameObject pk;
    public GameObject pg;
    public GameObject prd;
    public GameObject plfw;
    public GameObject prfw;

    public GameObject puck;
    public GameObject targetPlayer;

    public PLDscript script;
    private bool onOff;

    Vector2 pos;

    void Start()
    {
    pk = GameObject.FindGameObjectWithTag("PK");
    pg = GameObject.FindGameObjectWithTag("PG");
    prd = GameObject.FindGameObjectWithTag("PRD");
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
    void OnCollisionEnter2D(Collision2D crash)
    {
        onOff = true;
    }
    void OnCollisionExit2D(Collision2D crash)
    {
        onOff = false;
    }
    void TargetPuck(GameObject targetpuck)
    {
        //objectplayer.transform.position = targetplayer.transform.position;
    }

    public void PassPlayer()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            pk.GetComponent<PKscript>().ATTarget(pg);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pk.GetComponent<PKscript>().ATTarget(plfw);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            pk.GetComponent<PKscript>().ATTarget(prd);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            pk.GetComponent<PKscript>().ATTarget(prfw);
        }

    }
}
