using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {

	public void DisplayTutorial() {
		gameObject.GetComponent<Animator> ().SetTrigger ("displayTutorial");
		// TODO: add in tutorial
	}
}
