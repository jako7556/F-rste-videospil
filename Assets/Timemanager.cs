using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timemanager : MonoBehaviour{

    public TextMeshProUGUI Texttid;
    public TextMeshProUGUI TextHighscore;

    private float timeInLevel;
    private bool runtimer = true;
    private string currentlvlname;
    // Start is called before the first frame update
    void Start()
    {
        currentlvlname = SceneManager.GetActiveScene().name;
         string score ="Highscore: "+PlayerPrefs.GetFloat(currentlvlname).ToString("F1");
         TextHighscore.text = score;
    }

    // Update is called once per frame
    void Update()
    {
        if (runtimer == true){
         timeInLevel += Time.deltaTime;
        }
        Texttid.text = "Time: " + timeInLevel.ToString("F1");
    }

    public void Stopandsavescore(){
        runtimer = false;

        float lastscore = PlayerPrefs.GetFloat(currentlvlname);
        if(lastscore > timeInLevel || lastscore == 0)
        {
        PlayerPrefs.SetFloat(currentlvlname, timeInLevel);
        }
    }
}
