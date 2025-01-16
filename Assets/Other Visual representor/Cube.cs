using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void OnEnable()
    {
        InputActions.InteractEvent += Teliport;
    }

    private void OnDisable()
    {
        InputActions.InteractEvent -= Teliport;
    }

    void Teliport()
    {
        transform.position = transform.position * -1;
    }
}
