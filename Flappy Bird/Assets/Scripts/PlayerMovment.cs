using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Vector3 dir;
    public float gravity;
    public float strength;
    private void Update()
    {
        input();
        positionUpdate();
    }
    void input()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            dir = Vector3.up*strength;
            Debug.Log("aa");
        }
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Began)
            {
                dir = Vector3.up * strength;
            }
        }
      
    }
    void positionUpdate()
    {
         dir.y += gravity * Time.deltaTime;
        transform.position += dir * Time.deltaTime;
    }
}
