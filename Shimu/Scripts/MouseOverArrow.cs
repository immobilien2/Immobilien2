using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverArrow : MonoBehaviour {

		//テクスチャを用意
	public Texture image;
	public Texture image2;
	public Renderer renderer;

	void Start(){
		renderer = GetComponent<Renderer>();
	}

		//オブジェクトにマウスカーソルが重なっている際実行
	void OnMouseOver(){
			renderer.material.mainTexture = image2; //新しいテクスチャを反映する
	}

		//オブジェクトからマウスカーソルが離れた際実行
	void OnMouseExit(){
			renderer.material.mainTexture = image; //元のテクスチャを反映する
	}
}
