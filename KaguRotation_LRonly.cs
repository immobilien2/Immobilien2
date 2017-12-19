// This Code is about rotation of left and right only.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaguRotation_LRonly : MonoBehaviour {

	private float xSpeed = 200.0f;

	private float xKaiten = 0.0f;

	private Quaternion rotation = Quaternion.Euler(new Vector3(0f,0f,0f));

	void Update ()
	{

		if(Input.GetMouseButton(0))
		{
			xKaiten += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			var rotation = Quaternion.Euler(0, xKaiten, 0);
			transform.rotation = rotation;
		}

	}
	
}
