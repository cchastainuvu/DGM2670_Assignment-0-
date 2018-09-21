using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMessage : MonoBehaviour
{

    public Text winText;
    
    void Start () 
    {
        winText.GetComponent<Text>().enabled = false;
    }


}
