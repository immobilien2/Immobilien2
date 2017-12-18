using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofaControl : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
				float x = hit.point.x;
				float z = hit.point.z;
			}
		}
	}
}
