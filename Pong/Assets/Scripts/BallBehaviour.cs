using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    public Transform paddle;
    bool gameStarted = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameStarted)
        {
            float posDif = paddle.position.x - transform.position.x;
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);

            //Left Clic=0
            if (Input.GetMouseButtonDown(0))
            {
                gameStarted = true;
            }
        }
        else
        {

        }
        
	}
}
