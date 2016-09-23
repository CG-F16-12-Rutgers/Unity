using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Director : MonoBehaviour {

	public Text text_select1, text_select2, text_select3, text_select4, text_select5;
	public NavAgentController agent1, agent2, agent3, agent4, agent5;
	private bool selected1, selected2, selected3, selected4, selected5;

	public Text obstacle_text1, obstacle_text2, not_carve_text;
	public ObstacleController obstacle1, obstacle2, not_carve;
	private bool obstacle_sel1, obstacle_sel2, not_carve_sel;

	// Use this for initialization
	void Start () {
		selected1 = false;
		selected2 = false;
		selected3 = false;
		selected4 = false;
		selected5 = false;

		text_select1.text = set_text(selected1, 1);
		text_select2.text = set_text (selected2, 2);
		text_select3.text = set_text (selected3, 3);
		text_select4.text = set_text (selected4, 4);
		text_select5.text = set_text (selected5, 5);

		obstacle_sel1 = false;
		obstacle_sel2 = false;

		obstacle_text1.text = set_obstacle_text (obstacle_sel1, 1);
		obstacle_text2.text = set_obstacle_text (obstacle_sel2, 2);

		not_carve_sel = false;
		not_carve_text.text = "not selected";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// functions for agents

	string set_text(bool selected, int agentN) {
		if (selected) {
			return "agent " + agentN + " is selected";
		} else {
			return "agent " + agentN + " is not selected";
		}
	}

	public void reverse_select1 () {
		selected1 = !selected1;
		text_select1.text = set_text (selected1, 1);
	}

	public void reverse_select2 () {
		selected2 = !selected2;
		text_select2.text = set_text (selected2, 2);
	}

	public void reverse_select3 () {
		selected3 = !selected3;
		text_select3.text = set_text (selected3, 3);
	}

	public void reverse_select4 () {
		selected4 = !selected4;
		text_select4.text = set_text (selected4, 4);
	}

	public void reverse_select5 () {
		selected5 = !selected5;
		text_select5.text = set_text (selected5, 5);
	}

	public void go_to_destination (Vector3 target) {
		if (selected1) {
			agent1.go_to_target (target);
		}
		if (selected2) {
			agent2.go_to_target (target);
		}
		if (selected3) {
			agent3.go_to_target (target);
		}
		if (selected4) {
			agent4.go_to_target (target);
		}
		if (selected5) {
			agent5.go_to_target (target);
		}

	}

	// functions for obstacles

	string set_obstacle_text (bool selected, int obstacleN) {
		if (selected) {
			return "obstacle " + obstacleN + " is selected";
		} else {
			return "obstacle " + obstacleN + " is not selected";
		}
	}

	public void reverse_obstacle_selected1 () {
		obstacle_sel1 = !obstacle_sel1;
		obstacle_text1.text = set_obstacle_text (obstacle_sel1, 1);
	}

	public void reverse_obstacle_selected2 () {
		obstacle_sel2 = !obstacle_sel2;
		obstacle_text2.text = set_obstacle_text (obstacle_sel2, 2);
	}

	public void reverse_not_carve () {
		not_carve_sel = !not_carve_sel;
		if (not_carve_sel) {
			not_carve_text.text = "selected";
		} else {
			not_carve_text.text = "not selected";
		}
	}

	public void move_obstacle (Vector3 dir) {
		if (obstacle_sel1) {
			obstacle1.move (dir);
		}
		if (obstacle_sel2) {
			obstacle2.move (dir);
		}
		if (not_carve_sel) {
			not_carve.move (dir);
		}
	}
}
