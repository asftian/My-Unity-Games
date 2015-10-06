using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public Text scoreText;
	private int score;

	public Text gameOverText;
	public Text restartText;

	private bool gameOver;
	private bool restart;

	void Start ()
	{

		gameOverText.text = "";
		restartText.text = "";
		gameOver = false;
		restart = false;

		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}

	public void Update()
	{
		if (restart) 
		{
			if(Input.GetKeyDown(KeyCode.R))
			{
				Application .LoadLevel (Application.loadedLevel );
			}

		}
	}


	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}

			
			if (gameOver)
			{
				restartText.text = "Press 'R' for Restart";
				restart = true;
				break;
			}

			yield return new WaitForSeconds (waveWait);
		}
	}

	//tian
	public void GameOver()
	{
		gameOverText.text = "Game Over!";
		gameOver  = true;

	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score.ToString ();
	}
}