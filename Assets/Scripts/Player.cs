using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour {
    public float moveSpeed = 500f;
    float movement = 0f;
    void Update() {
        movement = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate() {
        transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
        if(movement != 0){
            transform.RotateAround(Vector3.zero, Vector3.forward, movement*Time.fixedDeltaTime*-moveSpeed);
        } else{
            transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * 20f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        FindObjectOfType<GameManager>().EndGame();
    }
}