using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerContr : MonoBehaviour {

    private Rigidbody2D my_rb;
    public float speed;
    public float jumpForce;
    private Animator my_animator;
    private SpriteRenderer my_renderer;
    private bool grounded;
    public LayerMask floorLayer;
    public Transform groundCheckPosition;

	// Use this for initialization
	void Start () {
        my_rb = GetComponent<Rigidbody2D>();
        my_animator = GetComponent<Animator>();
        my_renderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        Move();
        Jump();
        grounded = Physics2D.Linecast(transform.position, groundCheckPosition.position, floorLayer);
	}

    public void Move() {
        if (Input.GetKey(KeyCode.A))
        {
            my_rb.AddForce(Vector2.left * speed * Time.deltaTime);
            my_animator.SetBool("isMoving", true);
            my_renderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            my_rb.AddForce(Vector2.right * speed * Time.deltaTime);
            my_animator.SetBool("isMoving", true);
            my_renderer.flipX = false;
        }
        else
        {
            my_animator.SetBool("isMoving", false);
        }
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            my_rb.AddForce(Vector2.up * jumpForce * Time.deltaTime,ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "goal")
        {
            SceneManager.LoadScene("sanic");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "kvs")
        {
            SceneManager.LoadScene("level 1");
        }
    }
}
