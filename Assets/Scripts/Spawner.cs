using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour {
    public float spawnRate = 10f;
    public GameObject hexagonPrefab;
    private float nexTimeToSpawn = 0f;
    void Update() {
        if(Time.time >= nexTimeToSpawn){
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nexTimeToSpawn = Time.time + 3f / spawnRate;
        }
    }
}
