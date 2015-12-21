using UnityEngine;
using System.Collections;

public class PlaceGuard : MonoBehaviour {
	public GameObject guardPrefab;
	private GameObject guard;
	private GameManagerBehaviour gameManager;

	void Start(){
		gameManager = GameObject.Find ("GameManager").GetComponent<GameManagerBehaviour>();
	}

	private bool canPlaceGuard(){
		int cost = guardPrefab.GetComponent<GuardData> ().levels [0].cost;
		return guard == null && gameManager.Cash >= cost;
	}

	void OnMouseUp(){
		if(canPlaceGuard()){
			guard = (GameObject)Instantiate (guardPrefab, transform.position, Quaternion.identity);

			AudioSource audioSource = gameObject.GetComponent<AudioSource> ();
			audioSource.PlayOneShot (audioSource.clip);

			gameManager.Cash -= guard.GetComponent<GuardData> ().CurrentLevel.cost;
		} else if(canUpgradeGuard()){
			guard.GetComponent<GuardData> ().increaseLevel ();
			AudioSource audiosource = gameObject.GetComponent<AudioSource> ();
			audiosource.PlayOneShot (audiosource.clip);

			gameManager.Cash -= guard.GetComponent<GuardData> ().CurrentLevel.cost;
		}
	}

	private bool canUpgradeGuard(){
		if(guard != null){
			GuardData guardData = guard.GetComponent<GuardData> ();
			GuardLevel nextLevel = guardData.getNextLevel ();

			if(nextLevel != null){
				return gameManager.Cash >= nextLevel.cost;
			}
		}
		return false;
	}
}
