using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMenu : MonoBehaviour
{
	void Start()
	{
		//Button btn = yourButton.GetComponent<Button>();
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
	}

	public void test()
    {
		Debug.Log("Enter");
	}
}
