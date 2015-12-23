using UnityEngine;
using System.Collections;

public class GlobalController : MonoBehaviour {
	// shared instance
	private static GlobalController _instance = null;

	// cannet be instantiated directly
	private GlobalController(){ }

	// get the instance
	private static GlobalController Instance
	{
		get
		{
			if(_instance == null)
				_instance = new GlobalController(); // only creates a new one if this does not exist

			return _instance;
		}
	}
		
	private string userName;

	public string UserName {
		get { return userName; }
		set {
			userName = value;
			Debug.Log ("SET: newUserName: "+ userName);
		}
	}

	void Start(){
		DontDestroyOnLoad (this);
	}
}
