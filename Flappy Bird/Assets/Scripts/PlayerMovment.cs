using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerMovment : MonoBehaviour
{
    private Vector3 dir;
    private int spriteInd;
    public Sprite [] sprites;

    public float gravity;
    public float strength;
    private void Start()
    {
        InvokeRepeating(nameof(spriteUpdate),0.15f,0.15f);
    }
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
    void spriteUpdate()
    {
        spriteInd = (spriteInd + 1) % sprites.Length;
        GetComponent<SpriteRenderer>().sprite = sprites[spriteInd];
    }
}
