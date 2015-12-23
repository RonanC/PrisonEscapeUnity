using UnityEngine;
using System.Collections;

// singleton

[RequireComponent(typeof(AudioSource))]
public class BGMusicPlayer : MonoBehaviour {
//	public static BGMusicPlayer Instance { get { return instance; } }

	private static BGMusicPlayer instance = null;
	public static BGMusicPlayer Instance
	{
		get
		{
			if (instance == null)
			{
				instance = (BGMusicPlayer)FindObjectOfType(typeof(BGMusicPlayer));
			}
			return instance;
		}
	}

	void Awake ()
	{
		if (Instance != this)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
			Play ();
		}
	}

	public void Play() {
		GetComponent<AudioSource>().Play();
	}


	public void Stop() {
		GetComponent<AudioSource>().Stop();
	}

	//	void Awake() {
	//		if (instance != null) {
	//			return;
	//		} else {
	//			instance = this;
	//			DontDestroyOnLoad(gameObject);
	//			Play ();
	//		}
	//
	//	}
	//		

}
