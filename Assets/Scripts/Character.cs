using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, ICharacter
{
    public Inventory Inventory
    {
        get;
        set;
            
    }    
    public int Health
    {
        get;
        set;
    }
    public int Level
    {
        get;
        set;
    }

    public void OnItemEquipped(Items item)
    {
        Debug.Log($"Item Equipeed{item} in {item.EquipSlots}");
    }
}
