using UnityEngine;
using System.Collections;

public class StopMenu : MonoBehaviour {
	public bool moving = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown () {
		if (moving) {
			TriggerStop();
		} else {
			TriggerStart();
		}
	}

	void TriggerStop() {
		GameObject.Find("Ball").SendMessage("GameStop");
		guiText.text = "START";
		moving = false;
	}
	void TriggerStart() {
		GameObject.Find("Ball").SendMessage("GameStart");
		guiText.text = "STOP";
		moving = true;
	}

}
