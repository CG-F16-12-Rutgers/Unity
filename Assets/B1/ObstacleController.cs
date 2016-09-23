using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
		
	public void move (Vector3 dir) {
		transform.Translate (dir * speed);
	}
}
