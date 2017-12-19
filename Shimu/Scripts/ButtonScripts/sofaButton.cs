using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofaButton : MonoBehaviour {
	public GameObject sofa;

	void Start(){
		gameObject.SetActive(false);
	}
	public void OnClick() {
    Debug.Log("sofaButton click!");
    // 非表示にする
    gameObject.SetActive(false);
		// MyCanvas.SetActive("Button3", true);
		sofa.SetActive(true);
    // Button2を表示する（※ここを追加）
    MyCanvas.SetActive("PutDownButton", true);
		MyCanvas.SetActive("CancelButon", true);
  }
}
