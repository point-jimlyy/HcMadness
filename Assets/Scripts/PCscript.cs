using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCscript : MonoBehaviour {

    public GameObject pk;
    public GameObject plfw;
    public GameObject prfw;

    public GameObject puck;
    public GameObject targetPlayer;

    private bool onOff;


    void Start()
    {
        pk = GameObject.FindGameObjectWithTag("PK");
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
    public void PassPlayer()
    {
        if (Input.GetKeyDown(KeyCode.W) /*&& Input.GetKey(KeyCode.A)*/)
        {
            pk.GetComponent<PKscript>().ATTarget(plfw);
        }
        if (Input.GetKeyDown(KeyCode.S) /*&& Input.GetKey(KeyCode.A)*/)
        {
            pk.GetComponent<PKscript>().ATTarget(prfw);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene("StageTwo");
        }

    }
}
