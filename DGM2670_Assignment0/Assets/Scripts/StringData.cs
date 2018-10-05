using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string Message;

    private string DisplayMessage
    {
        get { return Message;}
    }
}
