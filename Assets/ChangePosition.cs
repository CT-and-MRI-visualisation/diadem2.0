using UnityEngine;
using System.Collections;

public class ChangePosition : MonoBehaviour {
	public GameObject curr;
	public float delt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = curr.transform.position;
		if (Input.GetKeyDown (KeyCode.A)) {
			pos.x += delt;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			pos.x -= delt;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			pos.y += delt;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			pos.y -= delt;
		} else if (Input.GetKeyDown (KeyCode.Q)) {
			pos.z += delt;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			pos.z -= delt;
		}
		curr.transform.position = pos;
	}
}
