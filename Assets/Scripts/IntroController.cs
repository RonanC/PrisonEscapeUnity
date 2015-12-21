using UnityEngine;
using System.Collections;

public class IntroController : MonoBehaviour {
	// post new score

	void Start () {
		//Invoke ("LoadLevel", 3f);
	}

	void LoadLevel () {
		Application.LoadLevel ("GameScene");
	}

	private void PostScore(){
		string name;
		int score;

		// TODO: post score to server
	}
}
