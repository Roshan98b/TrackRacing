using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Rigidbody rb;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstracles")
        {
            rb.GetComponent<UnityStandardAssets.Vehicles.Car.CarUserControl>().enabled = false;
            rb.AddForce(-transform.forward * 9000000 * Time.deltaTime);
            FindObjectOfType<Score>().enabled = false;
            FindObjectOfType<GameControl>().EndGame();
        }    
    }

}
