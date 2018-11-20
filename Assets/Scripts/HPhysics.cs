using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPhysics : MonoBehaviour {
    //Objects and variables

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

    Collider crash;
    Collider crash2;

    int MoveSpeed = 1;
    int MaxDist = 10;
    int MinDist = 1;

    // Use this for initialization
    void Start () {

        pos = transform.position;
        pos2 = transform.position;

        //pk.GetComponent<PKscript>().ATTarget(pg);

        //crash.GetComponent<Collider>();
        //Disable collisions with the object being attached


    }

void PuckATT()
    {
        //pk.GetComponent<PKscript>().ATTarget(pld);
        if (pk.GetComponent<Collider>() == true)
        {

        }

        //}
        //// Disable collisions with the object being attached
        //if (pk.GetComponent<Collider>())
        //{
        //    pk.GetComponent<Collider>().enabled = false;
        //}

        //// Don't allow physics to affect the object
        //if (pk.GetComponent<Rigidbody>())
        //{
        //    pk.GetComponent<Rigidbody>().isKinematic = true;
        //}
        //do
        //{
        //    pk.transform.position = Vector2.MoveTowards(transform.position, pld.transform.position, 0.5f);

        //} while (true);
        // pk.transform.parent = pld.transform;
        //pk.transform.localPosition = Vector2.zero;
    }
    

    // Update is called once per frame
    void Update () {

        //ec.GetComponent<ECscript>().Attack(pk);
        
        SetActivePlayer();
        //PuckATT();
        //pk.transform.parent = pld.transform; "takes same steps"
        //pk.GetComponent<PKscript>().OnCollisionEnter(crash);
        //pk.GetComponent<PKscript>().ATTarget(pld);
        //pk.GetComponent<PKscript>().OnCollitionEnter2D();
        //pk.GetComponent<PKscript>().CollisionEnter();
    }

    //void CollisionEnter(Collision crash)
    //{
    //    crash2 = crash.collider;

    //    if (crash.collider == pg || pld || prd || plfw || prfw || pc)
    //    {
    //        crash.collider;
    //    }
    //}
        void SetActivePlayer()
    {
        //if (pk.GetComponent<Collider>().collider() == true)
        //{

        //}

        //select the active player that needs to pass
        //pld.GetComponent<PLDscript>().MovePlayer();
    }

    
}
