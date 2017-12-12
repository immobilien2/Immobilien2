using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class mode_change : MonoBehaviour {

	IEnumerator LoadCardBoard()
	{
		XRSettings.LoadDeviceByName("Cardboard");
		yield return null;
		XRSettings.enabled = true;
	}

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (LoadCardBoard ());
	}
		
	// Update is called once per frame
	void Update () {
		
	}

	public void change()
	{
		if (XRSettings.enabled) 
		{
			XRSettings.enabled = false;
			Camera.main.ResetAspect ();
			InputTracking.Recenter ();
		} 
		else 
		{
			XRSettings.enabled = true;
		}
	}
}
