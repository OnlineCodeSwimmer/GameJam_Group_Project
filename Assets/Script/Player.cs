using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //Component
    private Rigidbody2D rb;


    //Move Parameter
    private Vector2 inputDireciton;
    private PlayerController playerController;
    private float speed=5f;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerController = new PlayerController();
    }

    private void OnEnable()
    {
        playerController.Enable();
    }

    private void OnDisable()
    {
        playerController.Disable();
    }



    private void Update()
    {
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = Vector2.right * speed;
    }
    private void InputCheck()
    {
    }
}
