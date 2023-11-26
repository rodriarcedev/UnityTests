using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using NSubstitute;

public class InventoryTests 
{

    [Test]
    public void FirstTestInventory()
    {
        // ARRANGE

        ICharacter character = Substitute.For<ICharacter>();
       Inventory inventory = new Inventory(character);
       Items itemOne = new Items()  { EquipSlots = EquipSlots.Chest};
        Items itemTwo = new Items() { EquipSlots = EquipSlots.Chest };

        //ACt
        inventory.EquipItem(itemOne);
        inventory.EquipItem(itemTwo);
        var result = inventory.GetItem(EquipSlots.Chest);


        //Assert
        Assert.AreEqual(result, itemTwo);

    }



    [Test]
    public void TestEquippedItem()
    {
        // ARRANGE

        ICharacter character = Substitute.For<ICharacter>();
        Inventory inventory = new Inventory(character);
        Items itemOne = new Items() { EquipSlots = EquipSlots.Chest };
        

        //ACt
        inventory.EquipItem(itemOne);
      
        var result = inventory.GetItem(EquipSlots.Chest);

        //Assert
        character.Received().OnItemEquipped(itemOne);

    }




}
