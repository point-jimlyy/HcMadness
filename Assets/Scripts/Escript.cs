using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escript : MonoBehaviour
{

    public GameObject pk;
    public Transform puck;

    int MoveSpeed = 1;
    int MaxDist = 6;
    int MinDist = 1;

    Vector2 pos;

    void Start()
    {
        pos = transform.position;
        pk = GameObject.Find("PK");
        puck = pk.transform;
        Attack(pk, puck);
    }
    void Update()
    {
        //pos = transform.position; does no follow from initiate pos
        Attack(pk, puck);
    }
    public void Attack(GameObject pk, Transform puck)
    {
        if (Vector2.Distance(pos, puck.position) <= MaxDist)
        {
            transform.position = Vector2.MoveTowards(transform.position, puck.position, 0.02f);
            //transform.localPosition += transform.forward * 0.03f;
        }
        
    }
    void OnCollisionEnter2D(Collision2D crash2)
    {
        if (crash2.gameObject.name == "PK")
        {
            //Activate something
            //Test
            //Destroy(gameObject);
        }
    }
}
/** script in Enemy from previous PlayerOne
 *     GameObject currentPlayer;

    void Start () {

        pos = transform.position;

        transform.position = GameObject.FindGameObjectWithTag("PG").transform.position;
        pg.GetComponent<PGscript>().enabled = false;
    }
	
	void Update () {

        transform.position = pos;
    }
    void OnCollisionEnter2D(Collision2D crash)
    {
        GetKeyCode(crash.gameObject);
        

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
    void GetKeyCode(GameObject gameObject)
    {
        currentPlayer = gameObject;
        pos2 = currentPlayer.transform.position;

        //Destroy(gameObject);
        
        //pos = pos2; //parent
        if (currentPlayer.tag == "PG")
        {

            //Destroy(gameObject);
            pg.GetComponent<PGscript>().enabled = true;//Make movecontrolls affect puck insted
            pos = GameObject.FindGameObjectWithTag("PG").transform.position;
        }
    }

    void OtherControll()
    {
        Event e = Event.current;
        inp2 = e.character;
        if (inp2 == 'W')
        {
            Destroy(gameObject);
            transform.position = GameObject.FindGameObjectWithTag("PLD").transform.position;
        }


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

    **/
