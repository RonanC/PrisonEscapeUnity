using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// allows this class to be editable from the inspector (great for balancing a game)
[System.Serializable]
public class GuardLevel {
	public int cost;
	public GameObject visualisation;

	// bullets
	public GameObject bullet;
	public float fireRate;
}

public class GuardData : MonoBehaviour {
	public List<GuardLevel> levels;
	private GuardLevel currentLevel;

	public GuardLevel CurrentLevel {
		get { 
			return currentLevel;
		}

		set { 
			currentLevel = value;
			int currentLevelIndex = levels.IndexOf (currentLevel);

			GameObject levelVisualisation = levels[currentLevelIndex].visualisation;
			for(int i = 0; i < levels.Count; i++){
				if(levelVisualisation != null){
					if (i == currentLevelIndex) {
						levels [i].visualisation.SetActive (true);
					} else {
						levels [i].visualisation.SetActive (false);
					}
				}
			}
		}
	}

	// happens once the prefab is created (OnStart isn't called until the object starts running in the scene)
	void OnEnable() {
		CurrentLevel = levels[0];
	}

	public GuardLevel getNextLevel(){
		int currentLevelIndex = levels.IndexOf (currentLevel);
		int maxLevelIndex = levels.Count - 1;

		if(currentLevelIndex < maxLevelIndex){
			return levels[currentLevelIndex+1];
		} else{
			return null;
		}
	}

	public void increaseLevel(){
		int currentLevelIndex = levels.IndexOf (currentLevel);
		if(currentLevelIndex < levels.Count - 1){
			CurrentLevel = levels[currentLevelIndex + 1];
		}
	}
}
