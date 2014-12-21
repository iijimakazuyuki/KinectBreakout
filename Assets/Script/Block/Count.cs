using UnityEngine;
using System.Collections;

public class Count : MonoBehaviour {
	public int count = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CountUp() {
		count++;
		guiText.text = count + " ERROR";
	}
}
