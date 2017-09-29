using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : MonoBehaviour {

    public float speed = 10.0f;

    private Rigidbody2D rigBody;

    // Use this for initialization
    void Start () {
        rigBody = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        float horizMove = Input.GetAxis("Horizontal");
        float vertMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizMove, vertMove, 0);
        rigBody.velocity = movement * speed;
    }
}
