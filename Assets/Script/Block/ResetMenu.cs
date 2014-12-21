using UnityEngine;
using System.Collections;

public class ResetMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown () {
		TriggerReset ();
	}
	void TriggerReset() {
		GameObject.Find("Ball").SendMessage("GameReset");
		GameObject.Find("Stop").SendMessage("TriggerStop");

	}
}
