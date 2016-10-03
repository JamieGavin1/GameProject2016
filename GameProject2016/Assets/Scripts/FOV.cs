using UnityEngine;
using System.Collections;

public class FOV : MonoBehaviour {
	public float fov = 150f;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if (fov != 60f) {
			fov -= 1;
			Camera.main.fieldOfView = fov;
		}
	}
}
