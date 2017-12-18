using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRToggle : MonoBehaviour {
	public GameObject GvrEditorEmulator;
	public GameObject GvrEventSystem;
	public GameObject GvrReticlePointer;
	public GameObject drop;
	public GameObject EventSystem;
	// Use this for initialization
	void Start () {
//		if (XRSettings.enabled) {
//			drop.SetActive (false);
//			Input.gyro.enabled = true;
//		} else {
//			drop.SetActive (true);
//			Input.gyro.enabled = false;
//		}
		drop.SetActive (false);
		StartCoroutine (LoadCardBoard ());
		Debug.Log (XRSettings.loadedDeviceName);
		Debug.Log (XRSettings.enabled);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Toggle(){
		Debug.Log (XRSettings.enabled);
		if (XRSettings.enabled) {
			drop.SetActive (true);
			//			GvrEditorEmulator.SetActive (false);
			GvrEventSystem.SetActive (false);
			//			GvrReticlePointer.SetActive (false);
			EventSystem.SetActive (true);
			Input.gyro.enabled = false;
			XRSettings.enabled = false;

		} else {
			drop.SetActive (false);
			//			GvrEditorEmulator.SetActive (true);
			GvrEventSystem.SetActive (true);
			//			GvrReticlePointer.SetActive (true);
			EventSystem.SetActive (false);
			Input.gyro.enabled = true;	
			XRSettings.enabled = true;
		}
	}

	IEnumerator LoadCardBoard(){
		XRSettings.LoadDeviceByName ("cardboard");
		yield return new WaitUntil (() => XRSettings.loadedDeviceName == "cardboard");
		yield return null;
		XRSettings.enabled = true;
	}
}
