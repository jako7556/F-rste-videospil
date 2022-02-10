using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Quit(){
        Application.Quit();
    }
public void Loadlvl(int scene){
    SceneManager.LoadScene(scene);
} 
    
}
