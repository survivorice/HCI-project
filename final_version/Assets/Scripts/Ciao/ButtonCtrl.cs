using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonCtrl : MonoBehaviour
{
	public GameObject b1;
	public GameObject b3;
	public GameObject b6;
	public GameObject b7;
	public Text inf;

	void Start()
	{
		b1.SetActive(false);
		b3.SetActive(false);
		b6.SetActive(false);
		b7.SetActive(false);
		if (common.ba.Count > 0)
		{
			inf.text = "请选择可能结果";
			foreach (string key in common.ba)
			{
				switch (key)
				{
					case "3201":
						b1.SetActive(true);
						break;
					case "3203":
						b3.SetActive(true);
						break;
					case "3206":
						b6.SetActive(true);
						break;
					case "3207":
						b7.SetActive(true);
						break;
					default:
						break;
				}
			}
		}
		else
		{
			inf.text = "找不到可能结果";
		}
	}


	public void TagTo3201()
	{
		common.anylseTag = "3201";
		common.iouse = false;
		SceneManager.LoadScene("JD_L2");
	}

	public void TagTo3203()
	{
		common.anylseTag = "3203";
		common.iouse = false;
		SceneManager.LoadScene("JD_L2");
	}

	public void TagTo3206()
	{
		common.anylseTag = "3206";
		common.iouse = false;
		SceneManager.LoadScene("JD_L2");
	}

	public void TagTo3207()
	{
		common.anylseTag = "3207";
		common.iouse = false;
		SceneManager.LoadScene("JD_L2");
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			common.ac = false;
			SceneManager.LoadScene("JD_L2");

		}

	}
}
