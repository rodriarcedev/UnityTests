using Codice.Client.Common.GameUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{


    public IPlayerInput PlayerInput { get;
        set;
    }

    private void Awake()
    {
       
    }

    private void Update()
    {
        float vertical = PlayerInput.Vertical;      
         
        float moveSpeed = 0.5f;
        transform.Translate(transform.forward * PlayerInput.Vertical * 2f * Time.deltaTime);

    }
}
