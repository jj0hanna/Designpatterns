using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerMovment playerMovment;
    void Awake()
    { 
        playerInput = GetComponent<PlayerInput>();
        playerMovment = GetComponent<PlayerMovment>();
    }
    void FixedUpdate()
    {
        playerMovment.Move(playerInput.Dirr);
    }
}
