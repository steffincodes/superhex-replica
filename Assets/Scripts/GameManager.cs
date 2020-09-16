using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
    private bool gamehasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame(bool status = true){
        if(gamehasEnded) return;
        gamehasEnded = true;

        rotator.enabled = false;
        spawner.enabled = false;
        if (status){
            animator.SetTrigger("LostGame");
        } else{
            animator.SetTrigger("WonGame");
        }

        Debug.Log("EndGame : status = "+status);
        Debug.Log("EndGame : gamehasEnded = "+gamehasEnded);
    }

    public void LostRestartLevel () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.PinCount = 0;
        Debug.Log("LostRestartLevel");

	}

    public void WonRestartLevel () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("WonRestartLevel");

	}
}
