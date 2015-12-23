using System.IO;
using UnityEngine;
using System.Collections;
//using SimpleJSON;
using LitJson;


public class CreditsController : MonoBehaviour {
	public Texture backgroundTexture;
	public Texture scorePanel;

	public float guiPlacementX = .3f;
	public float guiPlacementY1 = .25f;
	public float guiPlacementY2 = .5f;
	public float guiPlacementY3 = .84f;

	public float btnWidth = .4f;
	public float btnHeight = .2f;

	public GUIStyle btnStyle;
	public GUIStyle lblStyle;
	public GUIStyle lblScoresStyle;

	public Sprite sprite;

	public AudioSource audioSource;

	void OnGUI(){
		// display background texture
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

		//AudioSource audioSource = btnClick.GetComponent<AudioSource> ();

		// Heading
		lblStyle.fontSize = Screen.width / 8;
		GUI.Label(new Rect(Screen.width * .5f, Screen.height * .02f, 0, 0), "Credits", lblStyle);

		// scale font size
		btnStyle.fontSize = Screen.width / 20;

		// draw man
		// sprite.rect.width * (
//		GUI.DrawTexture(new Rect(Screen.width * -0.02f, Screen.height * .6f, Screen.width / 4, Screen.width / 4), sprite.texture);

		// display our buttons (play, highscore, credits)
//		if(GUI.Button(new Rect(Screen.width * guiPlacementX, Screen.height * guiPlacementY1, Screen.width * btnWidth, Screen.height * btnHeight), "Play Game", btnStyle)){	// start in middle
//			audioSource.PlayOneShot (audioSource.clip);
//			Application.LoadLevel("GameScene");
//		} 
//
//		if(GUI.Button(new Rect(Screen.width * guiPlacementX, Screen.height * guiPlacementY2, Screen.width * btnWidth, Screen.height * btnHeight), "High Scores", btnStyle)){	// start in middle
//			audioSource.PlayOneShot (audioSource.clip);
//			Application.LoadLevel("ScoreScene");
//		} 



		// score panel
		GUI.DrawTexture(new Rect(Screen.width * .16f, Screen.height * .20f, Screen.width * .7f, Screen.height * .65f), scorePanel);



		// home button
		if(GUI.Button(new Rect(Screen.width * guiPlacementX, Screen.height * guiPlacementY3, Screen.width * btnWidth, Screen.height * btnHeight), "Main Menu", btnStyle)){	// start in middle
			StartCoroutine(DelayedLoad("MainMenuScene"));
//			DontDestroyOnLoad(audioSource);
//			audioSource.PlayOneShot (audioSource.clip);
//			Application.LoadLevel("MainMenuScene");
		} 

		// score test data
		string credits = 
			"Programming\t\tRonan Connolly\n" +
			"Art/Design\t\tRonan Connolly\n" +
			"Business\t\t\tRonan Connolly\n";

		// score label
		lblScoresStyle.fontSize = Screen.width / 40;
		lblScoresStyle.padding.left = Screen.width / 35;
		lblScoresStyle.padding.top = Screen.width / 35;
		lblScoresStyle.wordWrap = true;
		lblScoresStyle.fixedWidth = 600;

		// scores
		GUI.Label(new Rect(Screen.width * .17f, Screen.height * .20f, 0, 0), credits, lblScoresStyle);
	}

//	IEnumerator DrawScoreData(){
//		
//	}

	IEnumerator DelayedLoad(string scene){
		audioSource.PlayOneShot (audioSource.clip);

		yield return new WaitForSeconds (audioSource.clip.length);

		Application.LoadLevel(scene);
	}

//	void Start () {
////		jsonString = File.ReadAllText (Application.dataPath  + "/Resources/Items.json");
//		Debug.Log (jsonString);
//
//		string url = "https://prisonbreakws.herokuapp.com/prisonEscape/scores";
//		WWW www = new WWW(url);
//		StartCoroutine(WaitForRequest(www));
//	}
//
//	private string requestedData;
//
//	// sending GET request to web service
//	IEnumerator WaitForRequest(WWW www)
//	{
//		yield return www;
//		// check for errors
//		if (www.error == null)
//		{
//			Debug.Log("WWW Ok!: " + www.data);
//			itemData = JsonMapper.ToObject(www.data);
//
//			string tempData = "Num\tWave\tHealth\tCASH\tNAME\n";
//			for(int i = 0; i < 10; i++){
//				tempData += string.Format ("#{0}\t{2}\t{3}\t{4}\t{1}\n", itemData[i][0], itemData[i][1], itemData[i][2], itemData[i][3], itemData[i][4]); 
//			}
//
//			requestedData = tempData;
//
////			dynamic stuff = JsonConvert.DeserializeObject (requestedData);
//
//			Debug.Log (itemData[0][1]);
//
//		} else {
//			Debug.Log("WWW Error: "+ www.error);
//			requestedData = "Unable to access scoreboard web service, try again later...";
//		}    
//	}
//
//	private string jsonString;
//	private JsonData itemData;
}
