using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour {
	public GameObject sofa;
	void Start(){
		gameObject.SetActive(false);
	}
	public void OnClick() {
    // Debug.Log("Button3 click!");
    // // 非表示にする
    // gameObject.SetActive(false);
		// MyCanvas.SetActive("PutDownButton",false);
		// sofa.SetActive(false);
    // Button2を表示する（※ここを追加）
    // MyCanvas.SetActive("Button2", true);
		// MyCanvas.SetActive("Button3", true);
  }
}
