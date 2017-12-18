using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bed : MonoBehaviour {
	public Dropdown dropdownItem;
	public GameObject homestuffPrefab;
	bool bed_runing;

	public void Start(){
//		dropdownItem = GetComponent<Dropdown>();
//		if (dropdownItem.captionText.text == "Bed") {
//			bed_runing = true;
//		}
	}

	public void Update () {
		bed_runing = true;
		Vector3 pos = new Vector3 (0, 0, 0);
//		Ray ray = new Ray (Camera.main.transform.position,
//			Camera.main.transform.rotation * Vector3.forward);
//
//		RaycastHit hit;
//		if (Physics.Raycast (ray, out hit)) {
//			if (hit.transform.gameObject.name == "Plane") {
//				transform.position = hit.point + new Vector3(0, 0.1f, 0);
//			}
//		}
		if (bed_runing) {
				Instantiate (homestuffPrefab, pos, Quaternion.identity);

		}
	}
}

