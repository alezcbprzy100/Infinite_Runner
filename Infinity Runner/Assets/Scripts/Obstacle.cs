using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

Player_Movement Playermovement;

    // Start is called before the first frame update
    private void Start()
    {
        Playermovement = GameObject.FindObjectOfType<Player_Movement>();
    }

private void OnCollisionEnter (Collision collision)
{
    if (collision.gameObject.name == "Player")
    // upadek z rowerka
     Playermovement.Die();
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
