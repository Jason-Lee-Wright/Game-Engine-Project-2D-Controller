using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;

    public Vector2 moveDirection = Vector2.left;

    public float MoveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
