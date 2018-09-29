using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    bool gameover = false;
    public float delay = 1f;

    public void Completegame (int i)
    {
        if(!gameover)
        {
            Debug.Log("Success");
            gameover = true;
            Invoke("Success", time: delay);
        }
    }

    public void EndGame ()
    {
        if(!gameover)
        {
            Debug.Log("Game Over");
            gameover = true;
            Invoke("GameOver", time: delay);
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("Gameover");
    }

    void Success()
    {
        SceneManager.LoadScene("Success");
    }

}
