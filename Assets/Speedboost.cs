using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedboost : MonoBehaviour {

public float fastassfuckboiDuration = 3; 
public float fastassfuckboiamount = 800;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player")
        {
             collision.GetComponent<playermovement>().SpeedPowerUp(fastassfuckboiDuration, fastassfuckboiamount);
        Destroy(gameObject); 
        }
       
    }
}

