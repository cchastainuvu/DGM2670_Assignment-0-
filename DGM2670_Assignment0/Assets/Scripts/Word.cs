using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Words : ScriptableObject 
{
 
    //PLAYER OBJECTIVE//
    //Solve words by dragging letters to a word zone.
    //Problem solving is fun, and bugs make it moreso.
    //Just hypothesizing. Goal is to make a living $$.
    
    //How are people solving, and why are they fun?
    //To have bugs walking off adds difficulty/fun.
    //People like to be challenged!
    
    //Scriptable Objects streamline the process and allow you to expand more easily.
    
    //HOMEWORK - SOFT ASSIGNMENT//
    //What is the single objective to your hyper-casual game? What is the challenge?
    //Replay value is a must. This game CAN be published. Make an agreement, or free.
    //Publish your game to public, and even put a nice tool in the Unity Asset Store.
    
    public UnityEvent Solved;
        //What event would make this true?
    public string TheWord;
    

    public void Solving()
    {
        foreach (var letter in TheWord)
        {
            //Mark as solved. Possible add a "letter" scriptable object to each bugs.            
        }
    }
    
    
    //World class will store the word as data and work on Solving.
    //Word data (var string) and work of solving (function void).
    
    //SLOT will have a trigger zone. When the bugs are triggered, they'll compare the slot.
    //Slot will be generated when it generates the word. Then associates a letter with each.
    //ENABLE and TRIGGER. (MonoBehaviour)
    
    //LETTERS (Enums) a drop-down of a letter. Letters can be enums - compare to the word.
    
    //THEBUG (MonoBehavior), AI NavMesh and LETTER, and BUGBRAIN (SO) - ???
    //WORLD contains WORDS.
    


}
