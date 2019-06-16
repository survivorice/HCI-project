using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XunfeiManager : MonoBehaviour
{
	public InputField resultText;
	private AndroidJavaObject currentActivity;

	private void Start()
	{
		currentActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
	}

	/// <summary>
	/// 点击按钮，开始语音输入
	/// </summary>
	public void OnClick()
	{
		currentActivity.Call("startListen");
	}

	/// <summary>
	/// 方法名要与安卓Java代码中规定的一致
	/// </summary>
	public void OnResult(string s)
	{
		if (s != "")
		{
			resultText.text = s;
			common.re = s;
			common.ac = true;
		}
		
	}
}
