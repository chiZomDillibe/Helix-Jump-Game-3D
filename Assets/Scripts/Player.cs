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
      string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

     if(materialName == "Safe (Instance)")
     {
      //The ball hits the safe area
     }else if (materialName == "Unsafe (Instance)")
     {
        //The ball hits the unsafe area
        GameManager.gameOver=true;
     }else if (materialName == "LastRing (Instance)")
     {
      // We completed the level
      GameManager.levelCompleted=true;
     }
    
    }

}
