using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    public Text countText;
    public Text winText;
    private int count;
    private Rigidbody rb;
    public AudioClip audio1;
    public AudioClip audio2;
    private AudioSource source;
    private float volume;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        count = 0;
        volume = 0.1f;
        CountUpdate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ES")
        {
            other.gameObject.SetActive(false);
            count++;
            CountUpdate();

            if (count < 12)
            {
                source.PlayOneShot(audio1, volume);
            }
            else
            {
                source.PlayOneShot(audio2, volume);
            }
        }
    }

    void CountUpdate()
    {
        countText.text = "ES tölkkejä: " + count.ToString() + "/12";
        volume += 0.1f;

        if (volume > 1)
        {
            volume = 1f;
        }

        if (count >= 12)
        {
            winText.text = " Voitit pelin!";
        }
        else
        {
            winText.text = "";
        }
    }
}
