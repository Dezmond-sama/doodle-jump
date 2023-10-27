using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int count;
    public float levelWidth = 3f;
    public float startY = -3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    public float maxX = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPoint = new Vector3();
        spawnPoint.y = startY;
        for (int i = 0; i < count; i++)
        {
            spawnPoint.y += Random.Range(minY, maxY);
            spawnPoint.x = Mathf.Clamp(Random.Range(-levelWidth, levelWidth), spawnPoint.x-maxX, spawnPoint.x + maxX);
            Instantiate(platformPrefab, spawnPoint, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
