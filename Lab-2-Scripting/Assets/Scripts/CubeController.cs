using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    //private float speed = 0.2f;
	public float speed = 0.02f;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

        // move the object by 1 meter per frame
        //transform.Translate(1, 0, 0);

        // move the object by 1 meter per second
        //transform.Translate(1 * Time.deltaTime, 0, 0);

        // rotate the cube
        //transform.Rotate(45, 45, 45);
        //transform.Rotate(45 * Time.deltaTime, 45 * Time.deltaTime, 45 * Time.deltaTime);

        //ControlByArrowKeys();
        //ControlByArrowKeys(speed);
	
	}

	void FixedUpdate()
	{
		ControlByArrowKeys (speed);
	}

    void ControlByArrowKeys()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        transform.Translate(xMove, 0.0f, zMove);
    }

    void ControlByArrowKeys(float speed)
    {
        float xMove = Input.GetAxis("Horizontal") * speed;
        float zMove = Input.GetAxis("Vertical") * speed;

        //transform.Translate(xMove, 0.0f, zMove);
		rb.AddForce (xMove, 0.0f, zMove);
    }
}
