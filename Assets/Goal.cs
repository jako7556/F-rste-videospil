using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Timemanager TM;

    public int nextlvl;
    public float TimeUntilNextLVL;

private void OnTriggerEnter2D(Collider2D collision){
    if(collision.tag== "Player"){
        TM.Stopandsavescore();
        StartCoroutine(WaitAndChangeLevel());
    }
}
IEnumerator WaitAndChangeLevel(){
    yield return new WaitForSeconds(TimeUntilNextLVL);
    SceneManager.LoadScene(nextlvl);
}

}
