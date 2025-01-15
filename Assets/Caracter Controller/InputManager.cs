using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, GamePlay.IPlayerActions
{
    private GamePlay gameplay;

    void Awake()
    {
        gameplay = new GamePlay();

        gameplay.Player.Enable();

        gameplay.Player.SetCallbacks(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("Receving Move input : " +  context.ReadValue<Vector2>());
    }
}



public static class InputActions
{
    public static Action<Vector2> MoveEvent;
}