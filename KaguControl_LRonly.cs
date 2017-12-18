using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour {

	private float xSpeed = 200.0f;

	private float x = 0.0f;

	private Quaternion rotation = Quaternion.Euler(new Vector3(30f,0f,0f));

	void Update ()
	{

		if(Input.GetMouseButton(0))
		{
			x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			var rotation = Quaternion.Euler(0, x, 0);
			transform.rotation = rotation;
		}

	}
	
}
