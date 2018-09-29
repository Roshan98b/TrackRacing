using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    public Text sc;
    public static int i;
    void FixedUpdate () {
        int i = PlayerPrefs.GetInt("Score");
        sc.text = (i * Time.deltaTime).ToString("0");
    }
}
