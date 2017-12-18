using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour {

	public float xSpeed = 2000.0f;
	public float ySpeed = 1000.0f;

	private float x = 0.0f;
	private float y = 0.0f;

	private int yMinLimit = -90;
	private int yMaxLimit = 90;

	private Quaternion rotation = Quaternion.Euler(new Vector3(30f,0f,0f));

	void Update ()
	{

		if(Input.GetMouseButton(0))
		{
			x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			y -= Input.GetAxis ("Mouse Y") * ySpeed * 0.02f;
			y = ClampAngle (y, yMinLimit, yMaxLimit);
			var rotation = Quaternion.Euler(y, x, 0);
			transform.rotation = rotation;
		}
			
	}

	static float ClampAngle(float angle, float min, float max) {
		if(angle < -360)
			angle += 360;
		if (angle > 360)
			angle -= 360;
		return Mathf.Clamp (angle, min, max);
	}

}
