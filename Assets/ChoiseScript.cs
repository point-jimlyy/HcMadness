using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiseScript : MonoBehaviour {
    public GameObject c;
    public GameObject q;
    public GameObject cB;
    public Sprite s;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public SpriteRenderer sr;
    public SpriteRenderer sr2;

    // Use this for initialization
    void Start () {
		c = GameObject.Find("C");
        q = GameObject.Find("Q");
        cB = GameObject.Find("ContBlack");

        sr2 = cB.GetComponent<SpriteRenderer>();
        s2 = sr2.sprite;
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("StageOne");
            //is C or Q
            //sr = c.GetComponent<SpriteRenderer>();
            //sr.sprite = s2;
            //Select(c);
            //s2 = c.GetComponent<Sprite>();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //is C or Q
            Destroy(gameObject);
            Application.Quit(); 
        }

    }
    void Select(GameObject choise)
    {
        //sr = choise.GetComponent<SpriteRenderer>(); 
        //sr.sprite = s2;
        //s = sr.sprite;
    }
}
