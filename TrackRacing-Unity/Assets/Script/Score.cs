using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text score;
    public int i = 0;
    void FixedUpdate () {
        score.text = (i * Time.deltaTime).ToString("0");
        i++;
	}
}
