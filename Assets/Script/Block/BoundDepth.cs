using UnityEngine;
using System.Collections;

public class BoundDepth : MonoBehaviour {
    public float fixedX;
    public float fixedY;
    public float fixedZ;
/*    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;*/
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(fixedX, fixedY, fixedZ);
/*        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.position = new Vector3(Mathf.Clamp(child.position.x, minX, maxX),
                Mathf.Clamp(child.position.y, minY, maxY),
                Mathf.Clamp(child.position.z, minZ, maxZ));
        }*/
	}
}
