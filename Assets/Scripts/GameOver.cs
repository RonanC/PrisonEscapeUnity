using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public string userName;
	public int wave;
	public int health;
	public int cash;
	public string timeStamp;
	GameManagerBehaviour gameManager;

	// Use this for initialization
	void RestartLevel () {
		getData ();
		StartCoroutine(PostScore());

		//GameObject
		Invoke ("LoadLevel", 3f);
	}

	void LoadLevel () {
		Application.LoadLevel ("ScoreBoardScene");
		// or lose scene
	}

	void getData(){
//		GameObject dataObject = GameObject.FindGameObjectWithTag ("GameManager");
		gameManager = GameObject.Find ("GameManager").GetComponent<GameManagerBehaviour>();

		userName = gameManager.UserName;
		wave = gameManager.Wave;
		health = gameManager.Health;
		cash = gameManager.Cash;
		timeStamp = "22ndDec2015";
	}

	public float btnWidth = .1f;
	public float btnHeight = .01f;

	void OnGUI(){
		// get name on home page

//		gameManager.UserName = GUI.TextField (new Rect(Screen.width * .3f, Screen.height * .25f, Screen.width * btnWidth, Screen.height * btnHeight), "Paddy");
//		gameManager.UserName = GUI.TextField (new Rect(100,100, 100, 25), "Paddy");

//		GUI.Button (new Rect (0, 0, 100, 25), "Continue");

//		GUI.Button (new Rect (Screen.width * .3f, Screen.height * .5f, Screen.width * btnWidth, Screen.height * btnHeight), "Continue");
//
//		if (GUI.Button (new Rect (Screen.width * .3f, Screen.height * .25f, Screen.width * btnWidth, Screen.height * btnHeight), "Continue")) {
//			getData ();
//			StartCoroutine(PostScore());
//
//			//GameObject
//			Invoke ("LoadLevel", 3f);
//		}
	}

	private string requestedData;

	IEnumerator PostScore () {
//		Time time = System.DateTime.Now;
		Debug.Log("Time: " + System.DateTime.Now);
		string url = string.Format("https://prisonbreakws.herokuapp.com/prisonEscape/scores/{0}/{1}/{2}/{3}/{4}", userName, wave, health, cash, timeStamp);
		Debug.Log (url);
		WWW www = new WWW(url);
		yield return StartCoroutine(WaitForRequest(www));

//		WWWForm form = new WWWForm();
//		form.AddField("Name", "Roncon");
//		form.AddField("Wave", "4");
//		form.AddField("Health", "3");
//		form.AddField("Cash", "150");
//
//		WWW www = new WWW(url, form);
//		StartCoroutine(WaitForRequest(www));

	}
		

	// sending GET request to web service
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.data);
//			itemData = JsonMapper.ToObject(www.data);

//			string tempData = "Num\tWave\tHealth\tCASH\tNAME\n";
//			for(int i = 0; i < 10; i++){
//				tempData += string.Format ("#{0}\t{2}\t{3}\t{4}\t{1}\n", itemData[i][0], itemData[i][1], itemData[i][2], itemData[i][3], itemData[i][4]); 
//			}
//
//			requestedData = tempData;

			//			dynamic stuff = JsonConvert.DeserializeObject (requestedData);

//			Debug.Log (itemData[0][1]);

		} else {
			Debug.Log("WWW Error: "+ www.error);
//			requestedData = "Unable to access scoreboard web service, try again later...";
		}    
	}
}
