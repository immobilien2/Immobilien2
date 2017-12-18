using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutDownButton : MonoBehaviour {

	void Start(){
		gameObject.SetActive(false);
	}
	public void OnClick() {
    // Debug.Log("Button5 click!");
    // // 非表示にする
    // gameObject.SetActive(false);
		// MyCanvas.SetActive("CancelButton",false);
		// CursolController.putDown();
    // Button2を表示する（※ここを追加）
    // MyCanvas.SetActive("Button2", true);
		// MyCanvas.SetActive("Button3", true);
  }
}
