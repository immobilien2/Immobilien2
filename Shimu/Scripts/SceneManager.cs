using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(LoadCardBoard());
		VRSettings.enabled = false;
	}
	// LoadCardBoard
	IEnumerator LoadCardBoard()
	{
	    VRSettings.LoadDeviceByName("cardboard");
	    yield return null;
	    VRSettings.enabled = true;
	}
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown(KeyCode.Escape))) {
				if (VRSettings.enabled){
					VRSettings.enabled = false;
					Camera.main.ResetAspect();
					InputTracking.Recenter();
				}
		}
	}
	public static void ChangeMode(){
		if (VRSettings.enabled) {
			VRSettings.enabled = false;
			Camera.main.ResetAspect ();
			InputTracking.Recenter ();
		}
		else {
			VRSettings.enabled = true;
		}
	}
}
