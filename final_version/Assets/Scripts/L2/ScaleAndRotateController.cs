using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScaleAndRotateController : MonoBehaviour
{
    private Touch oldTouch1;
    private Touch oldTouch2;


    private float radius;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        //text = GetComponent<Text>();
        //text.text = "";
        radius = transform.position.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0) return;

        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 deltaPos = touch.deltaPosition;

            transform.RotateAround(target.transform.position, Vector3.up, deltaPos.x / 50.0f);
            transform.RotateAround(target.transform.position, Vector3.forward, deltaPos.y / 50.0f);

        }

        Touch newTouch1 = Input.GetTouch(0);
        Touch newTouch2 = Input.GetTouch(1);
        
        if (newTouch2.phase == TouchPhase.Began)
        {
            oldTouch2 = newTouch2;
            oldTouch1 = newTouch1;
            return;
        }
        
        float oldDistance = Vector2.Distance(oldTouch1.position, oldTouch2.position);
        float newDistance = Vector2.Distance(newTouch1.position, newTouch2.position);
        
        float offset = newDistance - oldDistance;

        float scaleFactor = offset / 2000f;
        Vector3 currentPos = transform.position;
        currentPos -= currentPos * scaleFactor;

        transform.position = currentPos;


        //记住最新的触摸点，下次使用
        oldTouch1 = newTouch1;
        oldTouch2 = newTouch2;
    }
}
