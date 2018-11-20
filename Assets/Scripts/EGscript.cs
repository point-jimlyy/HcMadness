using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGscript : MonoBehaviour {

    //public GameObject ec = GameObject.Find("EC");

    public GameObject puck;
    public GameObject targetPlayer;
    public Transform pointA, pointB;

    Vector2 pos;
    Vector2 pos2;
    Vector2 traveller;
    Vector2 destination;

    Vector2 rim1;
    Vector2 rim2;

    float mSpeed = 0.05f;
    float tDistance;

    int MoveSpeed = 1;
    int MaxDist = 10;
    int MinDist = 1;

    // Use this for initialization
    void Start () {

        pos = transform.position;
        pos2 = transform.position;

        rim1 = new Vector2(-3, -1);
        rim2 =  new Vector2(3, -1);
        //pointA.position = rim1;
        //pointB.position = rim2;
        
        transform.position = rim1;
    }
	
	void Update () {

        pos2 = transform.position;

        if (pos2 == rim1)
        {
            //set traveller and destination
            destination = rim2;
            //Destroy(gameObject);
        }

        if (pos2 == rim2)
        {
            destination = rim1;
        }

        GolieAi();

    }

    void GolieAi()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination, mSpeed);
        //if (destination == rim2)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, rim2, mSpeed);
        //}
        //if (destination == rim1)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, rim1, mSpeed);
        //}
    }

    void GolieAii()
    {
        //if (pos = rim1)
        //{
        //    while (traveller != destination)
        //    {
        //        transform.position = Vector2.MoveTowards(traveller, destination, mSpeed);
        //    }
        //}

    }

}
//if (pos2 != rim2 /*|| Vector2.Distance(pos2, rim1) <= 0.1f*/)
//{
//    transform.position = Vector2.MoveTowards(transform.position, rim2, 0.1f);
//}
//if (pos2 != rim1 /*|| Vector2.Distance(pos2, rim2) <= 0.1f*/)
//{
//    transform.position = Vector2.MoveTowards(transform.position, rim1, 0.1f);
//}
//if (pos2 != pointA || pos2 != pointA.position)
//{
//    transform.position = Vector2.MoveTowards(transform.position, rim1, 0.1f);
//    pos3 = transform.position;
//}
//if (pos3 == rim1 /*&& Vector2.Distance(pos, rim1) <= 0.2*/ )
//{
//    transform.position = Vector2.MoveTowards(transform.position, rim2, 0.1f);

//}
//if (pos3 == rim2 /*&& Vector2.Distance(pos2, rim2) <= 0.2*/)
//{
//    //Destroy(gameObject);
//    transform.position = Vector2.MoveTowards(transform.position, rim1, 0.1f);

//}
//if (pos2 != rim2 /*|| Vector2.Distance(pos2, rim1) <= 0.1f*/)
//{
//    transform.position = Vector2.MoveTowards(transform.position, rim2, 0.1f);
//}
//if (pos2 != rim1 /*|| Vector2.Distance(pos2, rim2) <= 0.1f*/)
//{
//    transform.position = Vector2.MoveTowards(transform.position, rim1, 0.1f);
//}
//pos2 = transform.position;

//GolieAii();


//transform.position = Vector2.MoveTowards(pos, rim1, 0.02f);
