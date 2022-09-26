using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRB;
    public float bounceForce = 6;
    private void OnCollisionEnter(Collision collision)
    {
      playerRB.velocity = new Vector3(playerRB.velocity.x,bounceForce,playerRB.velocity.z);
    }
}
