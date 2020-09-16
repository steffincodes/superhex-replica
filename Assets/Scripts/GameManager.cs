using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public bool gamehasEnded = false;
    public Player player;
    public Spawner spawner;
    public Animator animator;
    public void EndGame(){
        if(gamehasEnded) return;
        gamehasEnded = true;
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("LostGame");
    } 
}