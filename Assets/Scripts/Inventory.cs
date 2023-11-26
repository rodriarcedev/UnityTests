using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory 
{
    private Dictionary<EquipSlots, Items> equippedItems = new Dictionary<EquipSlots, Items>();
    private List<Items> unequippedItems = new List<Items>();
    private readonly ICharacter character;


    public Inventory(ICharacter character)
    {
        this.character = character;
    }

    public void EquipItem(Items item)
    {
        if (equippedItems.ContainsKey(item.EquipSlots))
        {
            unequippedItems.Add(equippedItems[item.EquipSlots]);
        }
        equippedItems[item.EquipSlots] = item;
        character.OnItemEquipped(item);
    }

    public Items GetItem(EquipSlots equipSlots)
    {
        if (equippedItems.ContainsKey(equipSlots))
        {
            return equippedItems[equipSlots];
        
        }
        return null;

    }



    public int GetTotalArmor()
    {
        int totalArmor = equippedItems.Values.Sum(t => t.ArmorAmount);

        return totalArmor;
    }










}
