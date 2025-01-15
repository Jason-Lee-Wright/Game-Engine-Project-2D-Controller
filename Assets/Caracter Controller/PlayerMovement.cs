using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;

    //private Vector2 moveDirection = new Vector2(0.00f, -1.00f);

    public float MoveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HandleMovement(Vector2 moveDirection)
    {
        characterController.Move(moveDirection * Time.deltaTime);
    }

    private void Awake()
    {
        InputActions.MoveEvent += HandleMovement;
    }

    private void OnDisable()
    {
        InputActions.MoveEvent -= HandleMovement;
    }
}
