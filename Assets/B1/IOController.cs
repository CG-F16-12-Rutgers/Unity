using UnityEngine;
using System.Collections;
using System;

public class IOController : MonoBehaviour {

	public Director director;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 key_dir = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		director.move_obstacle (key_dir);

		if (Input.GetMouseButtonDown (0) && Input.mousePosition.x >= 150 && Input.mousePosition.x <= 910) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			Physics.Raycast (ray, out hit, 500);
			director.go_to_destination (hit.point);
		}
	
	}
}
