using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndControl : MonoBehaviour {

    public Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        rb.GetComponent<UnityStandardAssets.Vehicles.Car.CarUserControl>().enabled = false;
        rb.AddForce(-transform.forward * 9000000 * Time.deltaTime);
        FindObjectOfType<Score>().enabled = false;
        int i = FindObjectOfType<Score>().i;
        PlayerPrefs.SetInt("Score", i);
        Debug.Log("High Score: "+(i*Time.deltaTime).ToString("0"));
        FindObjectOfType<GameControl>().Completegame(i);

    }

}
