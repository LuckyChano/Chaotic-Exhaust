using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables Estaticas

    //Variables Publicas por Referencia
    public Rigidbody rb;

    //Variables Privadas por Referencia
    private PlayerMove _playerMove;
    private PlayerControl _playerControl;

    //Variables Publicas
    public float walkSpeed = 7f;
    public float runSpeedMultiplier = 1.5f;
    public float jumpForce = 10f;
    public float dashForce = 12f;

    //Variables Privadas

    //Propiedades

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        _playerMove = new PlayerMove(transform, rb, walkSpeed, runSpeedMultiplier, jumpForce, dashForce);
        _playerControl = new PlayerControl(_playerMove);

    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}
