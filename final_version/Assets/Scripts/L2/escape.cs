using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escape : MonoBehaviour
{
	public void getmore()
	{
		common.ba.Add("3201");
		common.ba.Add("3203");
		common.ba.Add("3206");
		common.ba.Add("3207");
		SceneManager.LoadScene("ciao");
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}

	}
	
}
