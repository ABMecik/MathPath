using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardSpeed = 2000f;
    public float horizontalSpeed = 500f;

	// Update is called once per frame
	void FixedUpdate () {

        forwardSpeed += rb.position.z/100;

        float horizontal = Input.GetAxisRaw("Horizontal");

        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if(horizontal > 0) {
            rb.AddForce(horizontalSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(horizontal < 0) {
            rb.AddForce(-horizontalSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
	}
}
