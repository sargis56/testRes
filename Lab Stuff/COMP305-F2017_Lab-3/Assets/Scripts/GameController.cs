using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject player;
    public GameObject camera;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((player.GetComponent<Rigidbody2D>().position.x >= 9.46) && (player.GetComponent<Rigidbody2D>().position.x < 30.36485))
        {
            camera.GetComponent<Rigidbody2D>().transform.position = new Vector3(20.64f, 0, -10f);
            camera.GetComponent<Camera>().orthographicSize = 5;
        }
        else if (player.GetComponent<Rigidbody2D>().position.x >= 30.36485)
        {
            camera.GetComponent<Rigidbody2D>().transform.position = new Vector3(player.GetComponent<Rigidbody2D>().transform.position.x, player.GetComponent<Rigidbody2D>().transform.position.y, -10f);
            camera.GetComponent<Camera>().orthographicSize = 50 - (player.GetComponent<Rigidbody2D>().transform.position.x);
        }
        else
        {
            camera.GetComponent<Rigidbody2D>().transform.position = new Vector3(player.GetComponent<Rigidbody2D>().transform.position.x, player.GetComponent<Rigidbody2D>().transform.position.y, -10f);
            camera.GetComponent<Camera>().orthographicSize = 5;
        }
    }
}
