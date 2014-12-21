using UnityEngine;
using System.Collections;

public class ClearMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown () {
		TriggerClear ();
	}
	void TriggerClear () {
		foreach (GameObject block in GameObject.FindGameObjectsWithTag ("Block")) {
			block.transform.position = new Vector3 (
				block.transform.position.x,
				block.transform.position.y,
				50);
		}
	}
}
