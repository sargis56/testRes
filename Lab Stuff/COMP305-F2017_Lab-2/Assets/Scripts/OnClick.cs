using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {

    public Button butt1;
    public Button butt2;
    public Button butt3;

    public GameObject iamgeBlue;
    public GameObject imageRed;
    public GameObject imageYellow;

    // Use this for initialization
    void Start () {
        butt1.GetComponent<Button>().onClick.AddListener(ClickedBlue);
        butt2.GetComponent<Button>().onClick.AddListener(ClickedRed);
        butt3.GetComponent<Button>().onClick.AddListener(ClickedYellow);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void ClickedBlue()
    {
        iamgeBlue.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 0);
        imageRed.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 1);
        imageYellow.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 2);
    }
    public void ClickedRed()
    {
        iamgeBlue.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 1);
        imageRed.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 0);
        imageYellow.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 2);
    }
    public void ClickedYellow()
    {
        iamgeBlue.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 2);
        imageRed.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 1);
        imageYellow.GetComponent<Rigidbody2D>().transform.position = new Vector3(-2, 5, 0);
    }
}
