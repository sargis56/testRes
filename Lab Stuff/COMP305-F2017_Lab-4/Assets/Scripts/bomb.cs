using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {

    public GameObject boom;
    private GameObject instantiated;
    public float time = 3;

    // Use this for initialization
    void Start () {
        time = 3;
    }
    void Update()
    {
        time -= Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate () {
        if ((boom != null) && (time <= 0.0f))
        {
            instantiated = Instantiate(boom, this.transform.position, this.transform.rotation);
            Destroy(instantiated, 1.0f);

        }
    }
}
