using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GotoLevel1() {
        SceneManager.LoadScene("level 1");
    }

    public void GotoLevel2()
    {
        SceneManager.LoadScene("level 2");
    }
}
