using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
    public float speed = 20f;
    public Rigidbody2D rb;

    private bool isPinned = false;

    void Update(){
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D (Collider2D col){
        if(col.tag == "Pin"){
            // END GAME
            // Debug.Log("END GAME!");
            FindObjectOfType<GameManager>().EndGame(true);
        } else if(col.tag == "Rotator"){
            Score.PinCount++;
            transform.SetParent(col.transform);
            col.GetComponent<Rotator>().speed *= -1f;
            col.GetComponent<Rotator>().speed += Random.Range(-50.0f, 50.0f);
            isPinned = true;
            if(Score.PinCount%10 == 0){
                FindObjectOfType<GameManager>().EndGame(false);
            }
        } 
    }
}
