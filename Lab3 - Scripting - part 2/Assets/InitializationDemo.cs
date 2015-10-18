using UnityEngine;
using System.Collections;

public class InitializationDemo : MonoBehaviour {


	void Awake()
	{
		//Debug.Log ("Cube 1 - Awake");
	}
	// Use this for initialization
	void Start () {
		//Debug.Log ("Cube 1 - Start");

	}
	
	// Update is called once per frame
	void Update () {
		Debug .Log ("Cube 1 - Update - " + Time.deltaTime );
	}

	void FixedUpdate() {
		Debug .Log ("Cube 1 - Fixed update - " + Time.deltaTime );
	}

} 