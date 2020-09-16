using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject pinPrefab;
    void Update(){
        if (
            Input.GetButtonDown("Fire1") ||
            Input.GetButtonDown("Jump") ||
            Input.GetKeyDown(KeyCode.Space) ||
            (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        ){
            SpawnPin();
        }
    }
    void SpawnPin(){
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
