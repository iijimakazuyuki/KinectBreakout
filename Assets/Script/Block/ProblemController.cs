using UnityEngine;
using System.Collections;

public class ProblemController : MonoBehaviour {
	public int problemId = 0;
	public string[] problemName;
	private const float CURRENT_PROBLEM_X = 0.39678f;
	private const float HIDDEN_PROBLEM_X = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void NextProblem() {
		GameObject currentProblem = GameObject.Find (problemName [problemId]);
		currentProblem.transform.position = new Vector3 (
			HIDDEN_PROBLEM_X,
			currentProblem.transform.position.y,
			currentProblem.transform.position.z);
		problemId++;
		if (problemId >= problemName.Length) {
			problemId = 0;
		}
		guiText.text = problemName [problemId];
		GameObject nextProblem = GameObject.Find (problemName [problemId]);
		nextProblem.transform.position = new Vector3 (
			CURRENT_PROBLEM_X,
			nextProblem.transform.position.y,
			nextProblem.transform.position.z);
	}

	void PrevProblem() {
		GameObject currentProblem = GameObject.Find (problemName [problemId]);
		currentProblem.transform.position = new Vector3 (
			HIDDEN_PROBLEM_X,
			currentProblem.transform.position.y,
			currentProblem.transform.position.z);
		problemId--;
		if (problemId < 0) {
			problemId = problemName.Length - 1;
		}
		guiText.text = problemName [problemId];
		GameObject nextProblem = GameObject.Find (problemName [problemId]);
		nextProblem.transform.position = new Vector3 (
			CURRENT_PROBLEM_X,
			nextProblem.transform.position.y,
			nextProblem.transform.position.z);
	}
}
