using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;
    private void OnEnable()
    {
        InvokeRepeating(nameof(spawn), spawnRate, spawnRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(spawn));
    }
    void spawn()
    {
        GameObject newObstacle = Instantiate<GameObject>(pipes, transform.position, Quaternion.identity);
        newObstacle.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
