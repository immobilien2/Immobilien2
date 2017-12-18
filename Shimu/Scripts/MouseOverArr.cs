using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverArr : MonoBehaviour {

	//テクスチャを用意
// public Texture image;
// public Texture image2;
// public Renderer renderer;
// public Object buttonSerif;

	void Start(){
		//renderer = GetComponent<Renderer>();
	}

		//オブジェクトにマウスカーソルが重なっている際実行
	void OnMouseOver(){
		Debug.Log( "OnMouseOver" );
		gameObject.GetComponent<Image>().color =
		new Color(13.0f/255.0f, 249.0f/255.0f, 240.0f/255.0f, 255.0f/255.0f);
	}

		//オブジェクトからマウスカーソルが離れた際実行
	void OnMouseExit(){
		gameObject.GetComponent<Image>().color =
		new Color(11.0f/255.0f, 221.0f/255.0f, 91.0f/255.0f, 255.0f/255.0f);
	}
}
