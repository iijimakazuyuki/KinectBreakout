using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float velocity;
    private RigidbodyConstraints stopConstraint = RigidbodyConstraints.FreezeRotationX
        | RigidbodyConstraints.FreezeRotationY
        | RigidbodyConstraints.FreezeRotationZ
        | RigidbodyConstraints.FreezePositionX
        | RigidbodyConstraints.FreezePositionY
        | RigidbodyConstraints.FreezePositionZ;
    private RigidbodyConstraints moveConstraint = RigidbodyConstraints.FreezeRotationX
        | RigidbodyConstraints.FreezeRotationY
        | RigidbodyConstraints.FreezeRotationZ
        | RigidbodyConstraints.FreezePositionZ;
	private Vector3 initVelocity;
	private Vector3 initPosition;
	private Vector3 prevVelocity;
    // Use this for initialization
	void Start () {
		initVelocity = velocity * (Vector3.up + Vector3.right).normalized;
		initPosition = transform.position;
		prevVelocity = initVelocity;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rigidbody.velocity = velocity * transform.rigidbody.velocity.normalized;
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag.Equals ("Block")) {
			collision.gameObject.transform.position = new Vector3(
				collision.gameObject.transform.position.x,
				collision.gameObject.transform.position.y,
				50);
		}
		if (collision.gameObject.tag.Equals ("Abyss")) {
			GameObject.Find ("Count").SendMessage ("CountUp");
		}
	}
    void GameStop()
    {
		prevVelocity = transform.rigidbody.velocity;
        transform.rigidbody.constraints = stopConstraint;
    }

    void GameStart()
    {
        transform.rigidbody.constraints = moveConstraint;
		transform.rigidbody.velocity = prevVelocity;
    }

	void GameReset()
	{
		transform.position = initPosition;
		transform.rigidbody.velocity = initVelocity;
	}
}
