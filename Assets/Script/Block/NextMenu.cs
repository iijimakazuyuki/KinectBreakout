using UnityEngine;
using System.Collections;

public class NextMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown () {
		GameObject.Find ("Stage").SendMessage ("NextProblem");
		GameObject.Find ("Restart").SendMessage ("TriggerRestart");
	}
}
