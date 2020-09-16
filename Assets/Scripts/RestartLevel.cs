using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
    public void LostRestartLevel () {
        Score.HexCount = 0;
        // Debug.Log("LostRestartLevel");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
