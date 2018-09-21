using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEditor;
using UnityEngine;

//[CreateAssetMenu]
public class ForEachLoops : ScriptableObject
{

public FloatData RandomSpeed;
public List <FloatData> SpeedOptions;


    private void OnEnable()
    {
        var randomNum = Random.Range(0, SpeedOptions.Count - 1);
        //0 , Size of the Collection, so however many have been set.
        //Minus 1, because Unity starts counting at zero.

        for (int i = 0; i < SpeedOptions.Count-1; i++)
        {
            //Checks to see if i is zero, then checks to see if i is less than count, then add to i.
            // "i" loops through every single number and compares, then takes the speed and sets it.

            if (i == randomNum)
            {
                RandomSpeed = SpeedOptions[i];
            }
            
        }
    
    }
}

//This is kind of what I did with the respawn location for the wolves and the ChickenHat.