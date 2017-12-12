using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleApi : MonoBehaviour {

	public RawImage img;

	string url = "";
	string newurl = "";

	public float lat = 33.57831f;
	public float lon = 130.25987f;

	LocationInfo li;

	public float zoom = 1;
	public int mapWidth = 640;
	public int mapHeight = 640;

	public enum mapType {roadmap,satellite,hybrid,terrain}
	public mapType mapSelected;
	public int scale;

	private bool loadingMap = false;

	private IEnumerator mapCoroutine;

	IEnumerator Map(float lat,float lon)
	{
		url = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lon +
			"&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale +
			"&maptype=" + mapSelected + 
			"&key=AIzaSyAVwPOh8_RK0nXPp6X4c0V8-udMvIeKjMM";
		loadingMap = true;
		WWW www = new WWW (url);
		yield return www;
		loadingMap = false;
		//img.texture = www.texture;
		//img.SetNativeSize ();
		gameObject.GetComponent<RawImage>().texture = www.texture;
		StopCoroutine (mapCoroutine);
	}

	public void zoom_change (float newzoom){
		zoom = newzoom;
		newurl = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lon +
			"&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale +
			"&maptype=" + mapSelected + 
			"&key=AIzaSyAVwPOh8_RK0nXPp6X4c0V8-udMvIeKjMM";
	}

	public void center_change (int index){
		if (index == 1) {
			lat = 33.57831f;
			lon = 130.25987f;
			newurl = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lon +
				"&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale +
				"&maptype=" + mapSelected + 
				"&key=AIzaSyAVwPOh8_RK0nXPp6X4c0V8-udMvIeKjMM";
		}
		if (index == 2) {
			lat = 33.57068f;
			lon = 130.246091f;
			newurl = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lon +
				"&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale +
				"&maptype=" + mapSelected + 
				"&key=AIzaSyAVwPOh8_RK0nXPp6X4c0V8-udMvIeKjMM";
		}
		if (index == 3) {
			lat = 33.579234f;
			lon = 130.273698f;
			newurl = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lon +
				"&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale +
				"&maptype=" + mapSelected + 
				"&key=AIzaSyAVwPOh8_RK0nXPp6X4c0V8-udMvIeKjMM";
		}

	}

	// Use this for initialization
	void Start () {
		mapCoroutine = Map (lat, lon);
		StartCoroutine (mapCoroutine);
	}
	
	// Update is called once per frame
	void Update () {
		if (newurl != url){
			mapCoroutine = Map (lat, lon);
			StartCoroutine (mapCoroutine);
		}
	}
}
