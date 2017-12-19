using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {

	private float xPlane = 0.0f;
	private float yPlane = -300.0f;
	private float zPlane = 0.0f;
	private float xpScale = 1.0f;
	private float ypScale = 1.0f;
	private float zpScale = 1.0f;

	private float xTree1 = 0.0f;
	private float zTree1 = 0.0f;
	private float xTree2 = 0.0f;
	private float zTree2 = 0.0f;

	GameObject Tree1;
	GameObject Tree2;

	// Use this for initialization
	void Start () {
		this.Tree1 = GameObject.Find ("Tree1");
		this.Tree2 = GameObject.Find ("Tree2");
	}
	
	// Update is called once per frame
	void Update () {
		xTree1 = Tree1.GetComponent<Transform> ().position.x;
		zTree1 = Tree1.GetComponent<Transform> ().position.z;
		xTree2 = Tree2.GetComponent<Transform> ().position.x;
		zTree2 = Tree2.GetComponent<Transform> ().position.z;

		xPlane = (xTree1 + xTree2) / 2;
		zPlane = (zTree1 + zTree2) / 2;
		xpScale = (xTree1 - xTree2) / 10;
		zpScale = (zTree1 - zTree2) / 10;

		if (xPlane < 0) {
			xPlane = -xPlane;
		}
		if (zPlane < 0) {
			zPlane = -zPlane;
		}
		if (xpScale < 0) {
			xpScale = -xpScale;
		}
		if (zpScale < 0) {
			zpScale = -zpScale;
		}

		transform.position = new Vector3 (xPlane,yPlane,zPlane);
		transform.localScale = new Vector3 (xpScale, ypScale, zpScale);
	}
}
