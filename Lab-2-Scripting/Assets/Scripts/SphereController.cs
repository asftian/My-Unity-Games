using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {

    public float speed;

    public GameObject myCube;

	// Use this for initialization
	void Start () {
        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {

        //transform.Translate(1 * Time.deltaTime * speed, 0.0f, 3 * Time.deltaTime * speed);
        //myCube.transform.Translate(1 * Time.deltaTime * speed, 0.0f, 3 * Time.deltaTime * speed);
        ControlByArrowKeys(speed);
	}

    void ControlByArrowKeys(float speed)
    {
        float xMove = Input.GetAxis("Horizontal") * speed;
        float zMove = Input.GetAxis("Vertical") * speed;

        transform.Translate(xMove, 0.0f, zMove);
        myCube.transform.Translate(xMove, 0.0f, zMove);
    }
}
