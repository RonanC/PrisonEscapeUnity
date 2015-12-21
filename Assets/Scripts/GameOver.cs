using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void RestartLevel () {
		//Application.LoadLevel (Application.loadedLevel);
		//PostScore();

		//GameObject
		Invoke ("LoadLevel", 3f);
	}

	void LoadLevel () {
		Application.LoadLevel ("WinScene");
		// or lose scene
	}
}
