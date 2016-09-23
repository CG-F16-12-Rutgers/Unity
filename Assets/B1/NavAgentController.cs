using UnityEngine;
using System.Collections;

public class NavAgentController : MonoBehaviour {

	private NavMeshAgent navAgent;
	private Vector3 targetPosition;

	// Use this for initialization
	void Awake () {
		navAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void go_to_target (Vector3 newTarget) {
		targetPosition = newTarget;
		navAgent.SetDestination (targetPosition);
	} 
}
