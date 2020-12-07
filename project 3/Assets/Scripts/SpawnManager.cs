using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(25, 0, 0);

    private PlayerController PlayerControllerScript;

    private float startDelay = 2;
    private float repeatDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        //Spawns Obstacle
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void SpawnObstacle()
    {
        //Stops spawn of Obstacles
        if(PlayerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
