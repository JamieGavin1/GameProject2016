using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour
{
	public float movementSpeed = 1.0f;

	// Update is called once per frame
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontal,vertical,0);
		Vector3 finalDirection = new Vector3(horizontal,vertical,5.0f);
		transform.position += direction*movementSpeed*Time.deltaTime;
		transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation
		                                              (finalDirection),Mathf.Deg2Rad*30.0f);


		if (transform.position.x <= -7.5f)
			transform.position = new Vector3(-7.5f, transform.position.y, transform.position.z);
		else if (transform.position.x >=7.5f)
			transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);
		else if (transform.position.y <= -7.5f)
			transform.position = new Vector3(transform.position.x, -7.5f, transform.position.z);
		else if (transform.position.y >=7.5f)
			transform.position = new Vector3(transform.position.x, 7.5f, transform.position.z);
		
	}
}
