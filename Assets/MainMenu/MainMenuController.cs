﻿/// <summary>
/// Main menu.
/// Attached to Main Camera
/// </summary>

using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {
	public Texture backgroundTexture;
	public float guiPlacementX = .3f;
	public float guiPlacementY1 = .2f;
	public float guiPlacementY2 = .4f;
	public float guiPlacementY3 = .6f;
	public float guiPlacementY4 = .8f;

	public float btnWidth = .4f;
	public float btnHeight = .2f;

	public GUIStyle btnStyle;

	// audio
//	public AudioSource audioSource;
//	public AudioClip sound1;
	public AudioSource audioSource;


	GlobalController globalData;
	string newUserName = "Paddy";

	// Use this for initialization
	void Start () {
//		audioSource = gameObject.AddComponent<AudioSource>();
//		audioSource.playOnAwake = false;
//		sound1 = (AudioClip)Resources.Load("TOWER_PLACE2-Large Thump Or Bump-SoundBible.com-395560493");

		globalData = GameObject.Find ("GlobalSingleton").GetComponent<GlobalController>();
	}

	void OnGUI(){
		// display background texture
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

		// scale font size
		btnStyle.fontSize = Screen.width / 20;


		// display our buttons (play, highscore, credits)
		if(GUI.Button(new Rect(Screen.width * guiPlacementX, Screen.height * guiPlacementY1, Screen.width * btnWidth, Screen.height * btnHeight), "Play Game", btnStyle)){	// start in middle
			StartCoroutine(DelayedLoad("GameScene"));
		} 

		if(GUI.Button(new Rect(Screen.width * guiPlacementX, Screen.height * guiPlacementY2, Screen.width * btnWidth, Screen.height * btnHeight), "High Scores", btnStyle)){	// start in middle
			StartCoroutine(DelayedLoad("ScoreBoardScene"));
		} 

		if(GUI.Button(new Rect(Screen.width * guiPlacementX, Screen.height * guiPlacementY3, Screen.width * btnWidth, Screen.height * btnHeight), "Credits", btnStyle)){	// start in middle
			StartCoroutine(DelayedLoad("CreditsScene"));
		} 
//		globalData.UserName = 

		newUserName = GUI.TextField(new Rect(Screen.width * guiPlacementX, Screen.height * guiPlacementY4, Screen.width * btnWidth, Screen.height * btnHeight), newUserName, 7, btnStyle);
	}

	IEnumerator DelayedLoad(string scene){
		Debug.Log ("newUserName: " + newUserName);
		globalData.UserName = newUserName;
		audioSource.PlayOneShot (audioSource.clip);

		yield return new WaitForSeconds (audioSource.clip.length);

		Application.LoadLevel(scene);
	}
}
