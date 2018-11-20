using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour {

    public GameObject pk = GameObject.Find("PK");
    public GameObject pg = GameObject.FindGameObjectWithTag("PG");
    public GameObject pld = GameObject.FindGameObjectWithTag("PLD");
    public GameObject prd = GameObject.Find("PRD");
    public GameObject plfw = GameObject.Find("PLFW");
    public GameObject prfw = GameObject.Find("PRFW");
    public GameObject pc = GameObject.Find("PC");


    Vector2 pos;
    Vector2 pos2;
    Collider2D crash2;
    string jotain;
    KeyCode inp;
    char inp2;
    KeyCode key1;
    KeyCode key2;
    KeyCode key3;

    char char1;
    char char2;
    char char3;

    GameObject objectPlayer;

    void Start ()
    {
        //pos = transform.position;
        //transform.position = GameObject.FindGameObjectWithTag("PG").transform.position;
        //pg.GetComponent<PGscript>().enabled = false;
    }
	void Update ()
    {   //transform.position = pos;
        //MoveTo();
        //Event e = Event.current;

        //key1 = e.keyCode;
        //char1 = e.character;

    }
    void OnCollisionEnter2D(Collision2D crash)
    {
        TargetPlayer(crash.gameObject);
        //pg.GetComponent<PGscript>().MovePlayer(e, k);
    }

    void TargetPlayer(GameObject targetPlayer)
    {
        objectPlayer = targetPlayer;
        //objectPlayer.transform.position = targetPlayer.transform.position;
        
        if (targetPlayer.tag == "PG")
        {
            //pos = pos2; //parent
            //Destroy(gameObject);
           // pg.GetComponent<PGscript>().enabled = true;//Make movecontrolls affect puck insted
            //pos = GameObject.FindGameObjectWithTag("PG").transform.position;        
        }

    }
    void MoveTo()
    {
        if (transform.position != objectPlayer.transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, objectPlayer.transform.position, 0.02f);
        }
    }
    void SendInfo()
    {
        
    }

    void Controlls(string jotain)
    {
        if (jotain == "PG")
        {
            pos = GameObject.FindGameObjectWithTag(jotain).transform.position;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {        // Left
            pos = GameObject.FindGameObjectWithTag(jotain).transform.position;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {        // Right
            pos = GameObject.FindGameObjectWithTag("PLD").transform.position;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {        // Up
            pos = GameObject.FindGameObjectWithTag(jotain).transform.position;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {        // Down
            pos = GameObject.FindGameObjectWithTag(jotain).transform.position;
        }

        if (jotain == "PLD")
        {
            //do pld stuff
        }
    }


    void OtherControll()
    {
        //Event e = Event.current;
        //inp2 = e.character;
        //if (inp2 == 'W')
        //{
        //    Destroy(gameObject);
        //    transform.position = GameObject.FindGameObjectWithTag("PLD").transform.position;
        //}
        //inp2 = e.keyCode;
        //if (inp2 == KeyCode.W)
        //{
        //    transform.position = GameObject.FindGameObjectWithTag("PLD").transform.position;
        //}

    }
    //Event e = Event.current;
    //if (Input.anyKeyDown)
    //{
    //    //inp2 = Input.GetKeyDown;
    //    inp = e.keyCode;
    //}
    //do
    //{
    //    GameObject.FindGameObjectWithTag(jotain).GetComponent<PGscript>().MovePlayer();
    //} while (true);
    //do PG stuff
    //Destroy(gameObject);
}
