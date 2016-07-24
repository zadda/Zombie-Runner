using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
   
    [SerializeField]
    private GameObject landingArea;
    [SerializeField]
    private Transform playerSpawnPoints;
    [SerializeField]
    private bool respawnPlayer = false;

    private Transform[] spawnPoints;
    
   


    // Use this for initialization
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
      
        //SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (respawnPlayer) //lastToggle !=
        {
            SpawnPlayer();
        }
    }

    private void SpawnPlayer()
    {
        respawnPlayer = false;
        int randomNumber = Random.Range(1, spawnPoints.Length); //.Length = 6, ok want het laatste nummers i Exclusief, ook "optie2 ▼" van random.range for INT
        transform.position = spawnPoints[randomNumber].transform.position;
    }

    void OnFindClearArea()
    {
        Invoke("DropFlare", 3f); // 3" delay
    }

    void DropFlare()
    {
        Instantiate(landingArea, transform.position, Quaternion.identity);
    }
}