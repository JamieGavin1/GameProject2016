using UnityEngine;
using System.Collections;

public class FOV : MonoBehaviour {
<<<<<<< HEAD
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
=======
	public float fov = 90f;
	public bool warp,startwarp = false;

	// Use this for initialization

	void Start (){
		Camera.main.fieldOfView = 60;		 
		warp = false;
		startwarp = false;




	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space") && MoveForward.speed >= 50 ) {
			warp = true;
		}
		if (warp == true) {
			Warp ();
		}
		if (Camera.main.fieldOfView >= 350) {
			int i = Application.loadedLevel;
			Application.LoadLevel(i + 1);
			}

		}


	void Warp(){
		Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, 400, 1 * Time.deltaTime);		 
	}


}
>>>>>>> f9a0990c42c7e179d0cfa1417419459b4f5b0f3c
