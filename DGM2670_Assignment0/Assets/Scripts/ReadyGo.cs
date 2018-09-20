using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyGo : MonoBehaviour
{

    private Text label;
    public AudioClip ready;

    IEnumerator Start()
    {

        yield return new WaitForSeconds(1F);
        AudioSource ready = GetComponent<AudioSource>();
        ready.Play();
        
         label = GetComponent<Text>();
         label.text = "Ready?";
         
         yield return new WaitForSeconds(0.5F);
         label.text = "GO!";

        yield return new WaitForSeconds(1F);
        label.text = "";
    }
}
