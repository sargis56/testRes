using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

    public GameObject bomb;
    private GameObject instantiated;
    Plane plane;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float fDist = 0.0f;
        plane.Raycast(ray, out fDist);
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log(Input.mousePosition);
            instantiated = (GameObject) Instantiate(bomb, ray.GetPoint (fDist), this.transform.rotation);
            Destroy(instantiated, 3.1f);
        }
    }
}
