using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerContr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn") {
            SceneManager.LoadScene("scene1");
        }
        if (other.tag == "Finish") {
            SceneManager.LoadScene("scene2");
        }
    }
}
