using Codice.Client.Common.GameUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{

    private Rigidbody rbPlayer;
    public IPlayerInput PlayerInput { get;
        set;
    }

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float vertical = PlayerInput.Vertical;
        rbPlayer.useGravity = false;
        float moveSpeed = 0.5f;
        rbPlayer.velocity = Vector3.forward * moveSpeed;

    }
}
