using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{

    private int count;
    public Text money;

    public bool canCount;

    private void Start()
    {
        count = 1;
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            
            canCount = true;
            SetMoney();
            
            int number = count + 10;

            while (count < number)
            {
                yield return new WaitForSeconds(0.02F);
                money.text = "$ " + count.ToString();
                count++;
            }
        }

    }
 
     private void SetMoney()
        {
            money.text = "$ " + count.ToString();
        }
}
    
    
