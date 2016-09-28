using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float speed = 1.0f;
	public float maxspeed = 100.0f;
	// Update is called once per frame
	void Update () {
		if (speed < maxspeed) {
			speed += 0.05f;
		}
		transform.position += transform.forward*speed*Time.deltaTime;
	}
}
