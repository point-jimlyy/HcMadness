using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PKscript : MonoBehaviour {

    
    public GameObject pg = GameObject.FindGameObjectWithTag("PG");
    public GameObject pld = GameObject.FindGameObjectWithTag("PLD");
    public GameObject prd = GameObject.Find("PRD");
    public GameObject plfw = GameObject.Find("PLFW");
    public GameObject prfw = GameObject.Find("PRFW");
    public GameObject pc = GameObject.Find("PC");

    public GameObject ec = GameObject.Find("EC");

    public GameObject puck;
    public GameObject targetPlayer;

    Vector2 pos;
    Vector2 pos2;

    int MoveSpeed = 1;
    int MaxDist = 10;
    int MinDist = 1;

    void Start()
    {
        pos = transform.position;
        transform.localPosition = pg.transform.position;
    }
    void Update ()
    {

    }
    public void ATTarget(GameObject player)
    {
        //targetPlayer = player;
        pos2 = player.transform.position;
        transform.localPosition = pos2;
    }

}



////
////void OnCollisionEnter2D()
////{
////    Destroy(gameObject);
////}

//void OnCollisionEnter2D(Collision2D crash2)
//{
//    Destroy(gameObject);
//    var getInp = Input.inputString;
//    Debug.Log(getInp);
//    //transform.position = Vector2.Lerp(transform.position, pld.transform.position, 0.02f);
//    //pg.GetComponent<PGscript>().MovePlayer();
//    //dtransform.position = GameObject.FindGameObjectWithTag("PLD").transform.position;
//    //pos = Vector2.MoveTowards(transform.position, crash2.collider.transform.position, 0.02f);
//    if (crash2.gameObject.tag == "PG")
//    {
//        Destroy(gameObject);
//        //pg.GetComponent<PGscript>().enabled = false;
//        //Destroy(gameObject);
//        //Destroy(gameObject); -Works
//        //transform.position = GameObject.FindGameObjectWithTag("PLD").transform.position;
//        if (Input.GetKeyDown(KeyCode.W))
//        {
//            Destroy(gameObject);
//            transform.position = GameObject.FindGameObjectWithTag("PLD").transform.position;
//        }
//        if (Input.GetKeyDown(KeyCode.W))
//        {
//            transform.position = GameObject.FindGameObjectWithTag("PRD").transform.position;
//        }
//    }
//    if (crash2.gameObject.tag == "PLD")
//    {
//        //transform.position = Vector2.MoveTowards(transform.position, pg.transform.position, 0.02f);
//        Destroy(gameObject);
//        if (Input.GetKeyDown(KeyCode.W))
//        {
//            transform.position = GameObject.FindGameObjectWithTag("PLD").transform.position;
//        }
//        if (Input.GetKeyDown(KeyCode.W))
//        {
//            transform.position = GameObject.FindGameObjectWithTag("PRD").transform.position;
//        }
//    }


//}

//void SetControlls(GameObject playerOne)
//{
//    pg.GetComponent<PGscript>().MovePlayer();
//}

////transform.position += transform.forward * MoveSpeed * Time.deltaTime;

//if (crash == true)
//{
//    transform.position = pos2;
//}

//if (crash.collider == true)
//{
//    crash.collider.enabled = false;


//    do
//    {
//        //transform.position = crash.collider.transform.position;
//        //transform.localPosition = Vector2.zero;
//        //transform.position = pos2;
//        //transform.parent = crash.collider.transform;


//    } while (true);
//}
//GameObject one = GameObject.Find("PLD");
//GameObject two = GameObject.Find("PLFW");
//GameObject tree = GameObject.Find("PRD");
//GameObject four = GameObject.Find("PRFW");

//if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
//{        // Up+Right
//    pos = Vector2.Lerp(transform.position, one.transform.position, 1f);
//}
//if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
//{        // Down+Right
//    pos = Vector2.Lerp(transform.position, tree.transform.position, 1f);
//}


//if (Input.GetKeyDown(KeyCode.W))
//{        // Up
//    pos += Vector2.up;
//}
//if (Input.GetKeyDown(KeyCode.S))
//{        // Down
//    pos += Vector2.down;
//}


//crash2.gameObject.tag = "Player";
//pos = Vector2.MoveTowards(transform.position, crash2.collider.transform.position, 0.02f);
//transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;