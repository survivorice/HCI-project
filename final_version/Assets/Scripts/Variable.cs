using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//用于存放所有共享的变量
public static class common
{
    // 标签
    public static string[] tag = { "3207", "3206", "3203", "3201", "3207outside", "3206outside","3203outside","3201outside" };

    // 房间信息
    public static Vector3[] pos =
    {
        new Vector3(2.95f, 1.39f, 15.6f),
        new Vector3(2.95f, 1.39f, 9.31f),
        new Vector3(2.95f, 1.39f, -1.94f),
        new Vector3(2.95f, 1.39f, -13.44f),
        new Vector3(-4.8f,1.39f,15.6f),
        new Vector3(-4.8f, 1.39f, 9.31f),
        new Vector3(-4.8f, 1.39f, -1.94f),
        new Vector3(-4.8f, 1.39f,-13.44f)
    };

    public static Vector3[] scale =
    {
        new Vector3(9.8f, 2.7f, 6.3f),
        new Vector3(9.8f, 2.7f, 6.3f),
        new Vector3(9.8f, 2.7f, 16.0f),
        new Vector3(9.8f, 2.7f, 7.4f),
        new Vector3(5.0f,2.7f,6.3f),
        new Vector3(5.0f, 2.7f, 6.3f),
        new Vector3(5.0f, 2.7f, 16.0f),
        new Vector3(5.0f, 2.7f, 7.4f)
    };

   
    public static string re="";		// 用于存放语音结果
	public static bool ac = false;      //语音是否更新
	public static bool ta = false;

	public static string anylseTag;     //分析结果
	public static bool io = false;      //室内false，室外true
	public static bool iouse = false;
	public static bool guess = false;   //模糊结果，猜测。表示所得结果只是猜测

	public static HashSet<string> ba = new HashSet<string>();	//存放多选择结果；
}
