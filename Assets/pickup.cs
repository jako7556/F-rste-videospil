using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private Pointmanager pm;
    public AudioClip PickUpAudioClip;

    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.Find("PointManager").GetComponent<Pointmanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag  == "Player"){
            pm.AddPoint(1);
            AudioSource.PlayClipAtPoint(PickUpAudioClip, transform.position);   
            Destroy(gameObject);
        }
    }
}

