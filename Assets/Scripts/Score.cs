using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static int PinCount = 0;
    public Text score;
    void Update(){
        score.text = PinCount.ToString();
    }
}
