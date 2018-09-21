using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class TextData : ScriptableObject
{ 
    public Text text;

    public virtual Text Text
    {
        get { return text; }
    }

}
