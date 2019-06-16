using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey 
{
	public string resline;

	private HashSet<string> database;
	public  HashSet<string> keywords;

	public GetKey()
	{
		this.resline = "";
		database = new HashSet<string>();
		keywords = new HashSet<string>();
		database.Add("梯");
		database.Add("门");
		database.Add("桌");
		database.Add("廊");
		database.Add("里");
		database.Add("外");
		database.Add("圆");
		database.Add("环");
		database.Add("弧");
	}

	public void parse()
	{
		string key = "";
		int sz = resline.Length;

		for(int i = 0; i < sz; i++)
		{
			char c = resline[i];

			//提取数字
			while (c>='0' && c <= '9')
			{
				key = key + c.ToString();
				if (i < sz-1)
				{
					i++;
					c = resline[i];
				}
				else
				{
					break;
				}

			}

			if (key != "")
			{
				keywords.Add(key);
				key = "";
			}

			if (database.Contains(c.ToString()))
			{
				keywords.Add(c.ToString());
			}

		}
	}

	public void Clear()
	{
		keywords.Clear();
		resline = "";
	}

}
