using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : IPlayerInput
{
  public float Vertical
    {
        get => Input.GetAxis("Vertical");
       

    }
}
