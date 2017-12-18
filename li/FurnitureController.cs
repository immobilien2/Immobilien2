using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureController : MonoBehaviour {
	InputField xScale;
	InputField yScale;
	InputField zScale;
	Button putDown;
	Button cancel;
	Dropdown furMenu;
	bool runing;

	void Start(){
		InputField[] scale = GameObject.Find("FurnitureController").GetComponentsInChildren<InputField>();
		xScale = scale [0];
		yScale = scale [1];
		zScale = scale [2];

		Button[] button = GameObject.Find("FurnitureController").GetComponentsInChildren<Button>();
		putDown = button [0];
		cancel = button [1];

		furMenu = GameObject.Find ("FurnitureController").GetComponentInChildren<Dropdown> ();

		putDown.onClick.AddListener (delegate() {
			runing = false;
			putDown.onClick.RemoveAllListeners ();
			furMenu.onValueChanged.RemoveAllListeners ();
		});

		furMenu.onValueChanged.AddListener (delegate(int n) {
			Destroy (gameObject);	
		});

		runing = true;
	}

	void Update () {
		if (runing) {
			if (xScale.text.Length > 0 && yScale.text.Length > 0 && zScale.text.Length > 0) {
				float x = float.Parse (xScale.text);
				float y = float.Parse (yScale.text);
				float z = float.Parse (zScale.text);
				transform.localScale = new Vector3 (x, y, z);
			}

			Ray ray = new Ray (Camera.main.transform.position,
				          Camera.main.transform.rotation * Vector3.forward);
			
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.gameObject.name == "Plane") {
					transform.position = hit.point + new Vector3 (0, 0.1f, 0);
				}
			}
		}
	}
}
