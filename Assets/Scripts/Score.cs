using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static int HexCount = 0;
    public Text score;
    void Update(){
        score.text = HexCount.ToString();
        transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
    }
}
