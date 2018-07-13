using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    public Transform paddle;
    public Rigidbody2D rbBall;

    public AudioSource ballAudio;
    public AudioSource pointAudio;

    public bool gameStarted = false;

    float posDif = 0;

    // Use this for initialization
    void Start () {
        posDif = paddle.position.x - transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {
        if (!gameStarted)
        {
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);

            //Left Clic=0
            if (Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(8, 8);
                gameStarted = true;
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballAudio.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pointAudio.Play();
    }
}
