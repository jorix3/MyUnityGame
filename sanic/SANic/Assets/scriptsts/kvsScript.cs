using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kvsScript : MonoBehaviour {

    public float speed;
    private bool goingRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (goingRight) {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        goingRight = !goingRight;
    }
}
