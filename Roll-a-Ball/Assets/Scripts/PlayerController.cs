using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	private int count;
	private float playTime;
	private bool stopTiming;

	public Text countText;
	public Text winText;
	public Text playTimeText;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> (); 
		count = 0;
		playTime = 0.0f;
		stopTiming = false;
		SetCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		playTime = playTime + Time.deltaTime;
		if (!stopTiming )
			playTimeText.text = "Play time: " + Mathf.RoundToInt (playTime ).ToString ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVerticial = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVerticial);
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count++;
			SetCountText();

			//Debug.Log ("count = " + count.ToString());
		
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		playTimeText.text = "Play time: " + Mathf.RoundToInt (playTime ).ToString ();
		if (count == 10) {
			stopTiming = true;
			winText.text = "You Win!";
			Debug.Log ("all objects are collected!");
		}
	}
	
}
