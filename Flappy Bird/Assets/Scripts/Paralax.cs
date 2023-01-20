using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshRenderer))]
public class Paralax : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        GetComponent<MeshRenderer>().material.mainTextureOffset += new Vector2(speed*Time.deltaTime,0);
    }
}
