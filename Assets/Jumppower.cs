using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumppower : MonoBehaviour
{
public float JumppowerDuration = 3; 
public float Jumppoweramount = 800;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player")
        {
             collision.GetComponent<playermovement>().JumpPowerUp(JumppowerDuration, Jumppoweramount);
        Destroy(gameObject); 
        }
       
    }
}
