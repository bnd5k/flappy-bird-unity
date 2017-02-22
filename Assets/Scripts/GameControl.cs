using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Awake () {
		// Awake method called before Start method

		if (instance == null) {
			instance = this;
		} else if (instance != this) 
		{
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown (0)) 
		{
			EditorSceneManager.LoadScene (EditorSceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void BirdDied() 
	{
		gameOverText.SetActive(true);
		gameOver = true;

	}
}
