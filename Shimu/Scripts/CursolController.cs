using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursolController : MonoBehaviour {

	public GameObject homestuffPrefab;
	//リストを作成
	List<GameObject> list_toggle_ = new List<GameObject>();
	GameObject toggle_instance;
	void Start(){
		gameObject.SetActive(false);
	}

	void Update () {
		Ray ray = new Ray (Camera.main.transform.position,
			Camera.main.transform.rotation * Vector3.forward);

		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			if (hit.transform.gameObject.name == "Plane") {
				transform.position = hit.point + new Vector3(0, 0.1f, 0);
			}
		}
		// 右矢印が押されたら
		var theta = 0;
		if (Input.GetKeyDown(KeyCode.RightArrow)){
		theta = theta + 90;
		transform.Rotate(new Vector3(0,theta,0));
		}
		// 左矢印が押されたら
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
		theta = theta - 90;
		transform.Rotate(new Vector3(0,theta,0));
		}
		//家具配置コード
		// if (Input.GetMouseButtonDown (0)) {
		// 	Vector3 pos = transform.position;
		// 	//pos.y = -0.8f;
		// 	for (int i=0; i<5; i++) {
		// 		toggle_instance = Instantiate (homestuffPrefab, pos, transform.rotation);
		// 		list_toggle_.Add(toggle_instance);
		// 	}
		// 	gameObject.SetActive(false);
		// }
		//家具デリートコード
		// if (Input.GetMouseButtonDown(1)) {
		// 	Debug.Log("test");
		// 	for (int i = 0; i < list_toggle_.Count; i++){
    //       Destroy(list_toggle_[i]);
    //   }
		// 	//リスト自体をキレイにする
    //   list_toggle_.Clear();
		// }
	}
	public void putDown(){
		Debug.Log("putdownButton click!");
    // 非表示にする
		MyCanvas.SetActive("CancelButon",false);
		MyCanvas.SetActive("PutDownButton",false);

		Vector3 pos = transform.position;
		//pos.y = -0.8f;
		for (int i=0; i<5; i++) {
			toggle_instance = Instantiate (homestuffPrefab, pos, transform.rotation);
			list_toggle_.Add(toggle_instance);
		}
		gameObject.SetActive(false);
	}
	public void cancelClick(){
		Debug.Log("CancelButton click!");
    // 非表示にする
		MyCanvas.SetActive("CancelButon",false);
		MyCanvas.SetActive("PutDownButton",false);
		gameObject.SetActive(false);
	}
	public void delit(){
		for (int i = 0; i < list_toggle_.Count; i++){
        Destroy(list_toggle_[i]);
    }
		//リスト自体をキレイにする
    list_toggle_.Clear();
	}
}
