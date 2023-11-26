using System;
using Unity.Collections;
using UnityEngine;

public class DamageCalculator 
{
 public static int CalculateDamage(int amount, float mitigationPercentage)
    {

        float mitigatin = 1f - mitigationPercentage;

        int value = Mathf.RoundToInt(amount * mitigatin);

        return value;
    }


    public static int CalculateDamage(int amount, ICharacter character)
    {

        int total = character.Inventory.GetTotalArmor();
        float multiplayer = 100 - total;
        multiplayer /= 100f;
        return Convert.ToInt32(amount * multiplayer);
    }
}
