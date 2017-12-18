using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIDropdownItem : MonoBehaviour {

	public Dropdown dropdownItem;
	List<string> tempNames;
	public InputField XScale;
	public InputField YScale;
	public InputField ZScale;
	public GameObject Bed;

	void Awake()
	{
		tempNames = new List<string>();
	}

	void Start()
	{
		AddNames();
		UpdateDropdownView(tempNames);
	}
		

	public void Putdown()
	{
		if (dropdownItem.value == 0) {
			
		}
		if (dropdownItem.value == 1) {
			Vector3 pos = new Vector3 (0, 0, 0);
			float x = float.Parse(XScale.text);
			float y = float.Parse(YScale.text);
			float z = float.Parse(ZScale.text);
			Bed.transform.localScale = new Vector3(x,y,z);
			Instantiate (Bed, pos, Quaternion.identity);
		}

	}

	private void UpdateDropdownView(List<string> showNames)
	{
		dropdownItem.options.Clear();
		Dropdown.OptionData tempData;
		for (int i = 0; i < showNames.Count; i++)
		{
			tempData = new Dropdown.OptionData();
			tempData.text = showNames[i];
			dropdownItem.options.Add(tempData);
		}
		dropdownItem.captionText.text = showNames[0];
	}

	private void AddNames()
	{
		string s1 = "Select Furniture";
		string s2 = "Bed";

		tempNames.Add(s1);
		tempNames.Add(s2);
	}
}
