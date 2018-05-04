using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    [SerializeField]
    private Transform playerSpawnPoints;

    public bool initRespawn = false;
	
	// Update is called once per frame
	void Update () {
		if(initRespawn)
        {
            Respawn();
            initRespawn = false;
        }
	}

    private void Respawn()
    {
        Transform[] spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
    }
}
