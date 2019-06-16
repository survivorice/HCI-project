using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


struct Room
{
    public string tag;
    public Vector3 pos;
    public Vector3 scale;
}



public class Rooms
{
    public ArrayList rooms = new ArrayList();

    public Dictionary<string, bool> onoff = new Dictionary<string, bool>();

    private int room_numbers;


    public void setRooms()
    {
        for (int i = 0; i < common.tag.Length; i++)
        {
            Room room = new Room();
            room.tag = common.tag[i];
            room.pos = common.pos[i];
            room.scale = common.scale[i];
            rooms.Add(room);
            // onoff.Add(tag[i], false);
        }
    }
}

public class HighLightController : MonoBehaviour
{

    private Room room;

    private HighlightableObject ho;

	public InputField tag;//debug


    // 申请房间信息
    public Rooms rooms = new Rooms();

    // 初始化
    void Start()
    {
        ho = GetComponent<HighlightableObject>();
        rooms.setRooms();
        //ho.ConstantOn(Color.yellow);
        
    }

    // 移动位置并开启边缘高亮

    public bool movePosition(string tag)
    {
        
        for(int i = 0; i < rooms.rooms.Count; i++)
        {
            room = (Room)rooms.rooms[i];
            if (room.tag == tag)
            {
                transform.position = room.pos;
                transform.localScale = room.scale;
                ho.ConstantOn(Color.cyan);
                return true;
            }
            
        }
        return false;
    }

   

    void Update()
    {


		if (common.anylseTag != "")
		{
			if (common.io && !common.iouse)
			{
				common.anylseTag = common.anylseTag + "outside";
				common.iouse = true;
			}	
		}
		else
		{
			if (common.ta)
			{
				common.ta = false;
				SceneManager.LoadScene("ciao");

			}
			
		}
		movePosition(common.anylseTag);
		tag.text = common.anylseTag;//debug
    }
}
