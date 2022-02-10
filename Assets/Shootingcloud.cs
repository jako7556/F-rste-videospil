using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootingcloud : MonoBehaviour{
    public GameObject SpawnPoint;
    public GameObject Lightningprefab;
    public float speed = 10; 
    public float shootintervalMin;
    public float shootintervalMax;
    

IEnumerator Start(){
    GameObject spawn = Instantiate(Lightningprefab) as GameObject;
    spawn.transform.position =SpawnPoint.transform.position;
    spawn.GetComponent<Rigidbody2D>().velocity = SpawnPoint.transform.right*speed;
    Destroy(spawn, 2);
    yield return new WaitForSeconds(Random.Range(shootintervalMin, shootintervalMax));

    StartCoroutine(Start());
}
    
    }
