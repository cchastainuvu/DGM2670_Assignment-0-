using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMove : MonoBehaviour {

    private CharacterController controller;
    public MovePattern Pattern;

    private void Start()
    {
        StartCoroutine(AllowMove());
    }

    private void Update()
    {
        Pattern.Invoke(controller, transform);
    }

    IEnumerator AllowMove()
    {
        yield return new WaitForSeconds(3F);
        controller = GetComponent<CharacterController>();   
    }
}
