using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parser : MonoBehaviour
{
	// Start is called before the first frame update
	private GetKey KeyManager;
	public InputField keyword;//debug
	void Start()
	{
		KeyManager = new GetKey();

	}

	// Update is called once per frame
	void Update()
	{
		if (common.re != "" && common.ac)
		{
			common.ac = false;
			common.anylseTag = "";
			common.io = false;
			common.iouse = false;
			common.ta = true;
			common.ba.Clear();
			

			string keyw = "";//debug

			KeyManager.resline = common.re;
			KeyManager.parse();
			foreach(string key in KeyManager.keywords)
			{
				keyw += key;//debug
				switch (key)
				{
					case "3201":
					case "3203":
					case "3206":
					case "3207":
							if (common.anylseTag == "" || common.guess)
							{
								common.anylseTag = key;
								common.ba.Add(key);
								common.guess = false;
								
							}
							else
							{
								//-多可能结果，跳转选择
								common.ba.Add(key);
							}
							break;
					case "外":
					case "门":
					case "廊":
						if (common.anylseTag == "")
						{
							common.anylseTag = "3203";
							common.guess = true;
						}
						
						common.ba.Add("3201");
						common.ba.Add("3207");
						common.ba.Add("3203");
						common.ba.Add("3206");

						common.io = true;
						break;
					case "内":
						common.io = false;
						break;
					case "梯":
						common.io = true;
						if (common.anylseTag== "")
						{
							common.anylseTag = "3201";
							common.guess = true;
							common.ba.Add("3201");
							common.ba.Add("3207");
						}
						break;
					case "桌":
						common.anylseTag = "3203";
						common.ba.Add("3203");
						common.io = false;
						break;
					case "圆":
					case "弧":
					case "环":
						common.anylseTag = "3201";
						common.ba.Add("3201");
						common.io = true;
						break;
					default:
						foreach(char c in key)
						{
							switch (c)
							{
								case '1':
									common.ba.Add("3201");
									break;
								case '3':
									common.ba.Add("3203");
									break;
								case '6':
									common.ba.Add("3206");
									break;
								case '7':
									common.ba.Add("3207");
									break;
								default:
									break;
							}
						}
						break;
					

				}
			}
			KeyManager.Clear();

			//debug
			keyword.text = keyw;
			
		}
		
	}
}
