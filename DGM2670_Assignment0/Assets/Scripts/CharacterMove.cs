using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMove : MonoBehaviour {

    private CharacterController controller;
    public MovePattern Pattern;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Pattern.Invoke(controller, transform);
    }

}
