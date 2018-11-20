using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PenaltyPscript : MonoBehaviour {

    Vector2 LB;
    Vector2 LM;
    Vector2 LT;

    Vector2 RB;
    Vector2 RM;
    Vector2 RT;

    Vector2[] shotDir;

    float mSpeed = 0.5f;

    Vector2 pos;
    Vector2 pos2 = new Vector2(0, -5);
    Vector2 destination;
    Vector2 pos3 = new Vector2(0, 0);
    Vector2 size = new Vector2(4, 4);
    Vector2 chk;
    Event e;
    KeyCode key;
    bool toggle;
    Input get;

    // Use this for initialization
    void Start () {

        transform.position = pos2;

        LB = new Vector2(-3, -2);
        LM = new Vector2(-3, 0);
        LT = new Vector2(-3, 1);

        RB = new Vector2(3, -2);
        RM = new Vector2(3, 0);
        RT = new Vector2(3, 1);

        shotDir = new Vector2 [] { LB, LM, LT, RB, RM, RT};

        

    }
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            destination = LB;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {       
            destination = LM;
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.A))
        {      
            destination = LT;
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.D))
        {       
            destination = RB;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            destination = RM;
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.D))
        {       
            destination = RT;
        }

        Shoot();

    }
    void Shoot()
    {
        chk = transform.position;

        foreach (Vector2 value in shotDir)
        {
            if ( chk == value)
            {
               SceneManager.LoadScene("StageThree");
            }
        }
        foreach (Vector2 value in shotDir)
        {
            if (destination == value)
            {  
                transform.position = Vector2.MoveTowards(transform.position, destination, mSpeed);
            }
        }
    }

    void OnCollisionEnter2D()
    {
        //GUI.Label(new Rect(pos3, size), "Hello World!");
        toggle = true;
        //penaltyMiss.text = "Save by golie!";
        //Destroy(gameObject);
        SceneManager.LoadScene("StageTwo");
        //SceneManager.LoadScene("StageOne"); //<--------PRIMARY

    }

}
