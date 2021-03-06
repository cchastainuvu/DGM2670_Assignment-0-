﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class ForEachLoops : ScriptableObject
{

public StringData RandomMessage;
    
public List <StringData> MessageOptions;

    private void OnEnable()
    {
        var randomNum = Random.Range(0, MessageOptions.Count - 1);
        //0 , Size of the Collection, so however many have been set.
        //Minus 1, because Unity starts counting at zero.

        for (var i = 0; i < MessageOptions.Count-1; i++)
        {
            //Checks to see if i is zero, then checks to see if i is less than count, then add to i.
            // "i" loops through every single number and compares, then takes the speed and sets it.

            if (i == randomNum)
            {
                RandomMessage = MessageOptions[i];
            }
            
        }
    
    }
}

//This is kind of what I did with the respawn location for the wolves and the ChickenHat.