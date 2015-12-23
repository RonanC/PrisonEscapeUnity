using UnityEngine;
using System.Collections;

public class clickSingleton : MonoBehaviour {

	private static clickSingleton instance = null;
	public static clickSingleton Instance
	{
		get
		{
			if (instance == null)
			{
				instance = (clickSingleton)FindObjectOfType(typeof(clickSingleton));
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
}
