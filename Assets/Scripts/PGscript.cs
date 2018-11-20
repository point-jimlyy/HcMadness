using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGscript : MonoBehaviour {

    public GameObject pk;
    public GameObject pld;
    public GameObject prd;

    public GameObject puck;
    public GameObject targetPlayer;

    private PGscript script;
    private bool onOff;

    Vector2 pos;
    Vector2 inp2;

    KeyCode key1;
    KeyCode key2;
    KeyCode key3;

    char char1;
    char char2;
    char char3;



    void Start ()
    {
        pk = GameObject.FindGameObjectWithTag("PK");
        pld = GameObject.FindGameObjectWithTag("PLD");
        prd = GameObject.FindGameObjectWithTag("PRD");
        key2 = KeyCode.W;
        char2 = 'W';
    }

    void TargetPuck(GameObject targetPuck)
    {
        //objectPuck = targetPuck;
        //objectPlayer.transform.position = targetPlayer.transform.position;
    }

    void Update ()
    {
        if (onOff)
        {
            PassPlayer();
        }
    }
    void OnCollisionEnter2D(Collision2D crash)
    {
        onOff = true;
        TargetPuck(crash.gameObject);
    }
    void OnCollisionExit2D(Collision2D crash)
    {
        onOff = false;
    }
    public void PassPlayer() {

        if (Input.GetKeyDown(KeyCode.W) /*&& Input.GetKey(KeyCode.D)*/)
        {
            pk.GetComponent<PKscript>().ATTarget(pld);
        }
        if (Input.GetKeyDown(KeyCode.S) /*&& Input.GetKey(KeyCode.D)*/)
        {
            pk.GetComponent<PKscript>().ATTarget(prd);
        }
    }
    public void Moveplayer2(Event e, char c)
    {
        if (e.keyCode == key2)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
        {        // Up+Right
            puck.transform.position = Vector2.Lerp(puck.transform.position, pld.transform.position, 1f);
            //puck.transform.position = Vector2.MoveTowards(transform.position, pld.transform.position, 0.02f);
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
        {        // Down+Right
            puck.transform.position = Vector2.Lerp(puck.transform.position, prd.transform.position, 1f);
            //puck.transform.position = Vector2.MoveTowards(transform.position, pld.transform.position, 0.02f);
        }
    }
}
//Event e = Event.current;
//key1 = e.keyCode;
//char1 = e.character; 
////MovePlayer(e);
//if (Input.anyKeyDown)
//{
//    key2 = e.keyCode;
//    char2 = e.character;
//}
//MovePlayer(e, e.keyCode);
