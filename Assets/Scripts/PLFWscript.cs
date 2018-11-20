using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLFWscript : MonoBehaviour {

    public GameObject pk;
    public GameObject pc;
    public GameObject prd;
    public GameObject pld;
    public GameObject prfw;

    public GameObject puck;
    public GameObject targetPlayer;

    private bool onOff;

    Vector2 pos;

    void Start()
    {
        pk = GameObject.FindGameObjectWithTag("PK");
        pc = GameObject.FindGameObjectWithTag("PC");
        prd = GameObject.FindGameObjectWithTag("PRD");
        pld = GameObject.Find("PLD");
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
    public void PassPlayer()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            pk.GetComponent<PKscript>().ATTarget(pld);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pk.GetComponent<PKscript>().ATTarget(pc);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            pk.GetComponent<PKscript>().ATTarget(prfw);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            pk.GetComponent<PKscript>().ATTarget(prd);
        }
    }
}
