using System.Collections;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class RunCountdown : MonoBehaviour
{

    private Text label;
    IEnumerator Start()
    {
        label = GetComponent<Text>();

        int number = 1000;
        
        
        while (number > 0)
           {
               yield return new WaitForSeconds(0.01F);
               label.text = number.ToString();
               number--;
           }
           
           label.text = "";
           yield return new WaitForSeconds(1);
           label.text = "GO"; 
    }
        
     //For Each loops are great for lists, like randomizing from a pool of FloatData.
     //While loops could be used for a money counter!
//        
//     IEnumerator Start()
//     {
//         label = GetComponent<Text>();
//         label.text = "3";
//
//         yield return new WaitForSeconds(1);
//         label.text = "2";
//         
//         yield return new WaitForSeconds(1);
//         label.text = "1";
//         
//         yield return new WaitForSeconds(1);
//         label.text = "GO!";
//     }


}
